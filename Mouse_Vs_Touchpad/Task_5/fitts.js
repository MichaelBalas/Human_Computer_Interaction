var FittsLawExperiment = Class.create();
var dTemp;
var startTime;

var menuDisplayed = false;
var menuBox = null;

FittsLawExperiment.kStateStopped = 0;
FittsLawExperiment.kStateSuspend = 1;
FittsLawExperiment.kStateRunning = 2;


FittsLawExperiment.prototype = {
    initialize: function (trialsradius, trialsampl, trialsinput, startbtn, options) {
	this.trialsradius = $(trialsradius);
	this.trialsampl = $(trialsampl);
	this.trialsinput = $(trialsinput);
	this.startbtn = $(startbtn);
	this.options = Object.extend(
	    {
		activeColor: "blue",
		inactiveColor: "grey",
		minTrials: 3,
		// 	radiusOptions: [16, 32, 64, 128, 192],
		// 	amplitudeOptions: [64, 128, 256, 512],
 		radiusOptions: [64, 128, 192],
		homingRadius: 32,
		amplitudeOptions: [128, 256, 512, 1024],
		angleOptions: [0, Math.PI * 0.25, Math.PI * 0.5, Math.PI * 0.75,
			       Math.PI * 1.0, Math.PI * 1.25, Math.PI * 1.5, Math.PI * 1.75]
	    }, options || {});
	this.state = FittsLawExperiment.kStateStopped;
	this.expwidth = top.window.innerWidth;
	this.expheight = top.window.innerHeight - 50;
	this.createTargets();
	this.observeEvents();
	//      this.rawRecords = [[128, 192, 100], [128, 192, 100], [256, 192, 1], [512, 192, 100]];
	//      this.plotResults();
    },

    createTargets: function() {
	this.homingTarget = document.createElement('canvas');
	this.clickTarget = document.createElement('canvas');
	document.body.appendChild(this.homingTarget);
	document.body.appendChild(this.clickTarget);
	this.homingTarget.hide();
	this.clickTarget.hide();
    },

    generateConditions: function() {
	this.conditions = [];
	var othis = this;
	this.options.radiusOptions.each(function(radius) {
	    othis.options.amplitudeOptions.each(function(amplitude) {
		if (amplitude > radius) {
		    othis.options.angleOptions.each(function(angle) {
			othis.conditions.push({'radius': radius, 'amplitude': amplitude, 'angle': angle});
		    });
		}
	    });
	});
	this.fisherYates(this.conditions);
    },

    fisherYates: function(myArray) {
	var i = myArray.length;
	if ( i == 0 ) return;
	while ( --i ) {
	    var j = Math.floor( Math.random() * ( i + 1 ) );
	    var tempi = myArray[i];
	    var tempj = myArray[j];
	    myArray[i] = tempj;
	    myArray[j] = tempi;
	}
    },

    observeEvents: function () {
	this.startbtn.observe('click', this.startbtnHandler.bindAsEventListener(this));
	//document.body.observe('contextmenu', this.rClickHandler.bindAsEventListener(this));
	document.body.observe('contextmenu', this.rClickHandler.bindAsEventListener(this));
	document.body.observe('click', this.clickHandler.bindAsEventListener(this));
	//this.homingTarget.observe('click', this.homingHandler.bindAsEventListener(this));
    },

    rClickHandler: function (e) {
	//if (!Event.isRightClick(e)) return;
	if (this.state == FittsLawExperiment.kStateRunning) {
		e.preventDefault();
	    var xorigin = parseInt(e.target.style.left);
	    var yorigin = parseInt(e.target.style.top);
	    var insidetarget = (e.target.className == 'active-target' &&
		this.isInsideCircle(e.clientX-xorigin, e.clientY-yorigin, this.getCurrentCondition().radius));
	    if (insidetarget && e.target == this.clickTarget) {
	    	//var menuPosX = getMenuPosition(e.clientX, e.clientY)[0];
	    	//var menuPosY = getMenuPosition(e.clientX, e.clientY)[1];
	    	//var left = e.clientX;
	    	//var top = e.clientY;

	    	menuBox = window.document.querySelector(".menu");
	    	if (e.clientX + 120 > $j(window).width() + $j(window).scrollLeft()) {
	    		menuBox.style.left = e.clientX - 150;
	    	} else {menuBox.style.left = e.clientX + "px"; }
	    	if (e.clientY + 150 > $j(window).height() + $j(window).scrollTop()) {
	    		menuBox.style.top = e.clientY - 150;
	    	} else {menuBox.style.top = e.clientY + "px"; }
	    	menuBox.style.display = "block";
	    	menuBox.style.zIndex = 1000;
	    	menuDisplayed = true;	    	
			menuBox.style.zIndex = 1000;
			menuBox.innerHTML = '';
			var target = Math.floor(Math.random() * 4) + 1;
			for (var i = 1; i < 5; i++) {
				var item = document.createElement("div");
				item.innerHTML = "Option " + i.toString();
				item.className = "menu-item";
				//item.id = 'not-target'
				if (i == target) { item.id = 'target'; } // FIX
				menuBox.appendChild(item);
			}
			Event.stop(e);
	    } else {
		if (this.clickTarget.className == 'active-target') {
		    this.finishTrial(false);
		}
	    }
	}
    },

    clickHandler: function(e) {
    	if (this.state == FittsLawExperiment.kStateRunning) {
    		if (menuDisplayed == true) {
    			if (e.target.id == 'target') {
    				this.finishTrial(true);
    			} else {
    				this.finishTrial(false);
    			}
    			menuBox.style.display = "none";
    			menuDisplayed = false; 
    		} else if (this.homingTarget.className == 'active-target') {
    			var xorigin = parseInt(e.target.style.left);
    			var yorigin = parseInt(e.target.style.top);
    			var insidetarget = (e.target.className == 'active-target' &&
				this.isInsideCircle(e.clientX-xorigin, e.clientY-yorigin, this.getCurrentCondition().radius));
				Event.stop(e);
				if (e.detail > 1) {
					this.errorRecords.pop();
					if (insidetarget && e.target == this.homingTarget) {
						this.finishHoming(true);
					} else {
						this.finishHoming(false);
					}
				} else {
					this.errorRecords.push(this.getCurrentCondition());
				} //too many errors (double double clickss)
			} else {
    			this.errorRecords.push(this.getCurrentCondition());
    		}
    	}
    },

    unobserveEvents: function () {
	this.startbtn.stopObserving();
    },

    resetStats: function () {
	this.curCondition = 0;
	this.rawRecords = new Array();
	this.errorRecords = new Array();
    },

    start: function () {
	if (this.state != FittsLawExperiment.kStateStopped) return;
	this.trials = parseInt(this.trialsinput.value);
	if (isNaN(this.trials) || this.trials < this.options.minTrials) {
	    alert("Enter a number for trial that is greater than " + this.options.minTrials);
	    return;
	}
	this.options.radiusOptions = this.trialsradius.value.split(',').collect(function(x) {
										  return parseInt(x);
									      });
	this.options.amplitudeOptions = this.trialsampl.value.split(',').collect(function(x) {
										     return parseInt(x);
										 });
	this.generateConditions();
	//alert(this.conditions.inspect());
	if (isNaN(this.trials) || this.trials <= 1) {
	    alert('trials should be greater than 1.');
	    return;
	}
	this.startbtn.value = 'Running';
	this.state = FittsLawExperiment.kStateSuspend;
	dTemp = new Date();
	startTime = 'Start Time: ' + dTemp.getHours() + ":" + dTemp.getMinutes() + ":" + dTemp.getSeconds() + ":" + dTemp.getMilliseconds();
	this.resetStats();
	this.startCondition();

	$('toolbar').fade();
	$('toolbar-label').fade();
	this.homingTarget.appear();
	this.clickTarget.appear();
    },

    getCurrentCondition: function() {
	return this.conditions[this.curCondition];
    },

    startCondition: function() {
	this.curTrial = 0;
	//this.errorCount[this.getCurrentCondition()] = 0.0;
	this.startHoming();
	this.state = FittsLawExperiment.kStateRunning;
    },

    finishCondition: function() {
	this.curCondition++;
	if (this.curCondition == this.conditions.length) {
	    this.finish();
	} else {
	    this.state = FittsLawExperiment.kStateSuspend;
	    this.startCondition();
	}
    },

     switchTarget: function(el) {
	var condition = this.getCurrentCondition();
	var radius = condition.radius;
	var amplitude = condition.amplitude;
	var angle = condition.angle;

	var centerx = this.expwidth / 2.0;
	var centery = this.expheight / 2.0;
	var deltax = amplitude * Math.cos(angle);
	var deltay = amplitude * Math.sin(angle);
	if (this.clickTarget == el) {
	    this.homingTarget.className = 'inactive-target';
	    this.clickTarget.className = 'active-target';
            this.createCircle(this.homingTarget, centerx, centery, this.options.homingRadius, 'gray');
            this.createCircle(this.clickTarget, centerx + deltax, centery + deltay, radius, '#3CB371');
	} else {
	    this.homingTarget.className = 'active-target';
	    this.clickTarget.className = 'inactive-target';
            this.createCircle(this.homingTarget, centerx, centery, this.options.homingRadius, 'red');
            this.createCircle(this.clickTarget, centerx + deltax, centery + deltay, radius, 'gray');
	}
    },

    addRecord: function () {
	if (this.curTrial < 1) return;
	var condition = this.getCurrentCondition();
	var T = new Date().getTime() - this.trialBeginTime;
	this.rawRecords.push([condition, T]);
    },

    startTrial: function () {
	this.switchTarget(this.clickTarget);
	this.trialBeginTime = new Date().getTime();
    },

    finishTrial: function (successful) {
	if (successful) {
	    this.addRecord();
	    this.curTrial++;
	} else {
	    this.errorRecords.push(this.getCurrentCondition());
	    this.curTrial++;
	}
	if (this.curTrial >= this.trials) {
	    this.finishCondition();
	} else {
	    this.startHoming();
	}
    },

    startHoming: function() {
	this.switchTarget(this.homingTarget);
	//this.trialBeginTime = new Date().getTime();
    },

    finishHoming: function(successful) {
    	if (successful) {
    		this.addRecord();
    		this.curTrial++;
    	} else {
    		this.errorRecords.push(this.getCurrentCondition());
    		this.curTrial++;
    	}
    	if (this.curTrial >= this.trials) {
    		this.finishCondition();
    	} else {
    		this.startTrial();
    	}
    },

    finish: function () {
	this.state = FittsLawExperiment.kStateStopped;
	this.plotResults();
	this.startbtn.value = 'Done';
	this.unobserveEvents();
	this.homingTarget.fade();
	this.clickTarget.fade();
	$('placeholder').hide();
	//alert("DONE!");
    },

    isInsideCircle: function(x, y, radius) {
	return this.distance(x, y, radius, radius) <= radius;
    },

    startbtnHandler: function(e) {
	this.start();
	Event.stop(e);
    },

    calculateRegression: function () {
	var othis = this;
	var records = [];
	this.conditions.each(function(cond) {
				 var count = 0;
				 var sum = 0;
				 othis.rawRecords.each(function(r) {
							   if (r[0] == cond) {
							       count++;
							       sum += r[1];
							   }
						       });
				 var errorcnt = 0;
				 othis.errorRecords.each(function(r) {
							   if (r == cond) {
							       errorcnt++;
							   }
						       });

				 records.push([cond, sum /count, errorcnt]);
			     });
	return records;
    },

    plotResults: function () {

	function value2Str(v) {
	    if (v===+v && v!==(v|0)) {
            return "" + v.toFixed(1);
	    }
	    return "" + v;
	}

	var records = this.calculateRegression();
	var tableEl = $('results-table');
	var allTableEl = $('all-results-table');
	var trEl = document.createElement('tr');
	['A', 'W', 'R', 'ID', 'ERR', 'MT'].each(function (val) {
					var tdEl = document.createElement('td');
					tdEl.innerHTML = val;
					trEl.appendChild(tdEl);
				    });
	tableEl.appendChild(trEl);
	records.each(function (record) {
                 var cond = record[0];
                 var mt = record[1];
                 var errorcnt = record[2];
				 var id = Math.log(cond.amplitude / cond.radius + 1) / Math.log(2);
				 //record.push(Math.log(record[0]/record[1] + 1) / Math.log(2));
				 var trEl = document.createElement('tr');
				 [cond.amplitude, cond.radius, cond.angle, id, errorcnt, mt].each(function (val) {
						 var tdEl = document.createElement('td');
						 tdEl.innerHTML = value2Str(val);
						 trEl.appendChild(tdEl);
					     });
				 tableEl.appendChild(trEl);
			     });

	trEl = document.createElement('tr');
	['A', 'W', 'R', 'ID', 'MT'].each(function (val) {
					var tdEl = document.createElement('td');
					tdEl.innerHTML = val;
					trEl.appendChild(tdEl);
				    });
	allTableEl.appendChild(trEl);
	this.rawRecords.each(function (record) {
                 var cond = record[0];
                 var mt = record[1];
				 var id = Math.log(cond.amplitude / cond.radius + 1) / Math.log(2);
				 //record.push(Math.log(record[0]/record[1] + 1) / Math.log(2));
				 var trEl = document.createElement('tr');
				 [cond.amplitude, cond.radius, cond.angle, id, mt].each(function (val) {
						 var tdEl = document.createElement('td');
						 tdEl.innerHTML = value2Str(val);
						 trEl.appendChild(tdEl);
					     });
				 allTableEl.appendChild(trEl);
			     });
	$('start-time').innerHTML = startTime;
	var d = new Date();
	$('end-time').innerHTML = 'End Time: ' + d.getHours() + ":" + d.getMinutes() + ":" + d.getSeconds() + ":" + d.getMilliseconds();
	$('results').appear();
	$('results').scrollTo();
    },


    createCircle: function(el, x, y, radius, color) {
	el.style.top = (y - radius) + "px";
	el.style.left = (x - radius) + "px";
	el.width = radius * 2;
	el.height = radius * 2;

	var ctx = el.getContext("2d");
	ctx.fillStyle = color;
	ctx.beginPath();
	ctx.arc(radius, radius, radius, 0, Math.PI * 2, true);
	ctx.fill();

	return el;
    },

    distance: function (x1, y1, x2, y2) {
	return Math.sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    }

};

