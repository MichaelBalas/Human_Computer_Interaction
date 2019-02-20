var HomingExperiment = Class.create();
HomingExperiment.kStateStopped = 0;
HomingExperiment.kStatePointing = 1;
HomingExperiment.kStateM2K = 2;
HomingExperiment.kStateTyping = 3;
HomingExperiment.kStateK2M = 4;
i = 0;
var dTemp;
var startTime;

WORD_LISTS = {'round1': ['agrarianly','saehrimnir','philologer','affinitive','cachinnate','antarctica','beautified','enfleurage','tiahuanaco','cornaceous','nonspinose','cloudburst','keyserling','isoglossal','unjewelled','preremoved','unbroached','groaningly','unhelmeted','locomotion','racecourse','mumblingly','decompound','xerophytic'],
			  'round2': ['ammonitish','blanketing','unwithered','lacunosity','rutherford','emergently','scatoscopy','misknowing','phonotypic','dishonorer','partialise','scandalize','compotator','nebulising','metaphytic','trafficker','mottlement','cataplasia','invaginate','unlaunched','unslighted','pyrochlore','telepathic','colchester'],
			  'round3': ['snatchiest','vitascopic','bitterwort','livability','flustrated','unstylized','separatist','responsive','revelation','workingman','surprising','nonscoring','advisorily','pedologist','epexegesis','bedighting','untraveled','sultanship','zoophagous','distringas','exultingly','palpebrate','escarpment','braininess'],
			  'round4': ['electively','parentless','sweetbrier','undertying','expiscated','amputation','preutilize','otological','cruciately','untwitched','machinable','journeying','waterworks','guidwillie','unobscured','mugwumpism','robustness','homogenous','catechizer','redrugging','deputising','marshalsea','concertina','questingly'],
			  'round5':	['cutinising','blackpatch','concinnate','retaliator','gramophone','waterbrain','underruler','individual','siderocyte','benthamite','stigmatypy','cuculiform','decolonize','unhealable','parnassian','crystalise','proatheism','halmaheira','myriameter','technology','advertised','imputation','rebellious','solitaries']
			 };

HomingExperiment.prototype = {
    initialize: function (trialsinput, startbtn, options) {
	this.trialsinput = $(trialsinput);
	this.startbtn = $(startbtn);
	this.options = Object.extend(
	    {
		// 	widthOptions: [16, 32, 64, 128, 192],
		// 	amplitudeOptions: [64, 128, 256, 512],
		pointingWidth: 64,
		pointingAmplitude: 1024,
		typingHeight: 64,
		minTrials: 4
	    }, options || {});
	this.state = HomingExperiment.kStateStopped;
	this.expwidth = window.innerWidth;
	this.expheight = window.innerHeight - 100;
	this.createTargets();
	this.observeEvents();
	//     this.rawRecords = [[128, 192, 100], [128, 192, 100], [256, 192, 1], [512, 192, 100]];
	//     this.plotResults();
    },

    createTargets: function() {
	var pwidth = this.options.pointingWidth;
	var pamplitude = this.options.pointingAmplitude;
	var theight = this.options.typingHeight;
	this.leftTarget = this.createRectangle(this.expwidth / 2 - pamplitude / 2 - pwidth / 2,
					       25,
					       pwidth,
					       this.expheight);
	this.rightTarget = this.createRectangle(this.expwidth / 2 + pamplitude / 2- pwidth / 2,
						25,
						pwidth,
						this.expheight);
	this.leftTarget.addClassName('target inactive');
	this.rightTarget.addClassName('target inactive');

	this.typebox = this.createRectangle(this.expwidth / 2 - pamplitude / 2 + pwidth / 2,
					    this.expheight / 2 - theight / 2 + 25,
					    pamplitude - pwidth,
					    theight);
	this.typebox.addClassName('typebox inactive');
	this.leftTarget.hide();
	this.rightTarget.hide();
	this.typebox.hide();
    },

    observeEvents: function () {
	this.startbtn.observe('click', this.startbtnHandler.bindAsEventListener(this));
	this.leftTarget.observe('click', this.clickHandler.bindAsEventListener(this));
	this.rightTarget.observe('click', this.clickHandler.bindAsEventListener(this));
	document.body.observe('click', this.clickHandler.bindAsEventListener(this));
	document.body.observe('mousemove', this.mousemoveHandler.bindAsEventListener(this));
	document.observe('keypress', this.keypressHandler.bindAsEventListener(this));
    },

    unobserveEvents: function () {
	this.startbtn.stopObserving();
	document.body.stopObserving();
    },


    resetStats: function () {
	this.errorCnt = 0;
	this.curTrial = 0;
	this.rawRecords = new Array();
	this.currentTarget = this.rightTarget;
    },

    start: function () {
	if (this.state != HomingExperiment.kStateStopped) return;
	var words_option = getCheckedValue($('toolbar').words_option);
	if (words_option == "") {
	    alert('Please choose a words option');
	    return;
	}
	this.words = WORD_LISTS[words_option];
	this.trials = parseInt(this.trialsinput.value);
	if (isNaN(this.trials) || this.trials < this.options.minTrials) {
	    alert("Enter a number for trial that is greater than " + this.options.minTrials);
	    return;
	}
	$('toolbar').fade();
	this.leftTarget.appear();
	this.rightTarget.appear();
	this.typebox.appear();
	dTemp = new Date();
	startTime = 'Start Time: ' + dTemp.getHours() + ":" + dTemp.getMinutes() + ":" + dTemp.getSeconds() + ":" + dTemp.getMilliseconds();
	this.resetStats();
	this.startTrial();
    },

    addRecord: function () {
	if (this.curTrial < 1) return;
	this.rawRecords.push({'pointing' : this.pointingTime,
			      'm2k': this.m2kTime,
			      'typing': this.typingTime,
			      'k2m': this.k2mTime});
    },

    switchTarget: function() {
	if (this.leftTarget == this.currentTarget) {
	    this.leftTarget.removeClassName('active').addClassName('inactive');
	    this.rightTarget.removeClassName('inactive').addClassName('active');
	    this.currentTarget = this.rightTarget;
	} else {
	    this.leftTarget.removeClassName('inactive').addClassName('active');
	    this.rightTarget.removeClassName('active').addClassName('inactive');
	    this.currentTarget = this.leftTarget;
	}
	this.typebox.removeClassName('active').addClassName('inactive');
    },

    startTrial: function () {
	this.matchedText = '';
	//temp = Math.floor(Math.random() * this.words.length);
	this.typingText = this.words[i];
	//this.words.slice(temp, 1);
	this.switchTarget();
	this.state = HomingExperiment.kStateK2M;
	this.k2mBeginTime = new Date().getTime();
	this.updateText();
    },

    updateText: function() {
	var rightPart, wrongPart;
	rightPart = this.matchedText;
	wrongPart = this.typingText.substring(rightPart.length);
	this.typebox.innerHTML = '<span class="correct">' + rightPart + '</span>' + '<span class="incorrect">' + wrongPart + '</span>';
    },

    clearText: function() {
	this.typebox.innerHTML = '';
    },

    finishTrial: function (successful) {
	this.addRecord();
	this.curTrial++;
	if (this.curTrial >= this.trials) {
	    this.finish();
	} else {
		i++;
	    this.startTrial();
	}
    },

    finish: function () {
	this.state = HomingExperiment.kStateStopped;
	this.leftTarget.fade();
	this.rightTarget.fade();
	this.typebox.fade();
	$('placeholder').hide();
	this.plotResults();
	this.startbtn.value = 'Done';
	this.unobserveEvents();
	//alert("DONE!");
    },

    finishPointing: function() {
	this.state = HomingExperiment.kStateM2K;
	//this.startbtn.innerHTML = 'm2k';
	this.pointingTime = new Date().getTime() - this.pointingBeginTime;
	this.m2kBeginTime = new Date().getTime();
	this.currentTarget.removeClassName('active').addClassName('inactive');
	this.typebox.removeClassName('inactive').addClassName('active');
    },

    finishM2K: function() {
	this.state = HomingExperiment.kStateTyping;
	//this.startbtn.innerHTML = 'typing';
	this.m2kTime = new Date().getTime() - this.m2kBeginTime;
	this.typingBeginTime = new Date().getTime();
    },

    finishTyping: function() {
	this.typingTime = new Date().getTime() - this.typingBeginTime;
	this.clearText();
	this.finishTrial();
    },

    finishK2M: function() {
	this.state = HomingExperiment.kStatePointing;
	//this.startbtn.innerHTML = 'pointing';
	this.k2mTime = new Date().getTime() - this.k2mBeginTime;
	this.pointingBeginTime = new Date().getTime();
    },

    clickHandler: function (e) {
	if (!Event.isLeftClick(e)) return;
	if (this.state == HomingExperiment.kStatePointing) {
	    if (e.target.hasClassName('active')) {
		this.finishPointing();
		Event.stop(e);
	    } else {
		this.errorCnt++;
	    }
	}
    },

    mousemoveHandler: function(e) {
	if (this.state == HomingExperiment.kStateK2M) {
	    this.finishK2M();
	}
    },

    keypressHandler: function(e) {
	switch(this.state) {
	case HomingExperiment.kStateM2K:
	    this.finishM2K();
	    Event.stop(e);
	case HomingExperiment.kStateTyping:
// 	    if (e.keyCode == 13 && this.matchedText == this.typingText) {
// 		this.finishTyping();
// 	    } else {
	    var c = String.fromCharCode(e.charCode);
	    if (c == this.typingText.charAt(this.matchedText.length)) {
		this.matchedText += c;
		this.updateText();
	    }
	    if (this.matchedText == this.typingText) {
		this.finishTyping();
	    }
	    Event.stop(e);
	    break;
	default:
	    break;
	}
    },

    startbtnHandler: function(e) {
	this.start();
	Event.stop(e);
    },

    calculateStats: function () {
	var pointing = this.rawRecords.map(function(r) { return r.pointing; });
	var m2k = this.rawRecords.map(function(r) { return r.m2k; });
	var typing = this.rawRecords.map(function(r) { return r.typing; });
	var k2m = this.rawRecords.map(function(r) { return r.k2m; });

	var othis = this;
	return {
	    'pointing': {
		'mean': othis.mean(pointing), 'std': othis.std(pointing)
	    },
	    'm2k': {
		'mean': othis.mean(m2k), 'std': othis.std(m2k)
	    },
	    'typing': {
		'mean': othis.mean(typing), 'std': othis.std(typing)
	    },
	    'k2m': {
		'mean': othis.mean(k2m), 'std': othis.std(k2m)
	    }
	};
    },

    mean: function(a) {
	return a.inject(0, function (acc, d) { return acc + d; }) / a.length;
    },

    std: function(a) {
	var mean = this.mean(a);
	return Math.sqrt(a.inject(0, function (acc, d) { return acc + (d - mean) * (d - mean); }) / (a.length - 1));
    },

    plotResults: function () {
	function value2Str(v) {
	    if (v===+v && v!==(v|0)) {
		return "" + v.toFixed(3);
	    }
	    return "" + v;
	}

	var results = this.calculateStats();
	var tableEl = $('results-table');
	var trEl = document.createElement('tr');
	var types = ['pointing', 'm2k', 'typing', 'k2m'];
	types.each(function (val) {
		       var tdEl = document.createElement('td');
		       tdEl.innerHTML = val;
		       trEl.appendChild(tdEl);
		   });
	tableEl.appendChild(trEl);
	var stats = {};
	types.each(function(k) {
		       stats[k] = '(' + Math.round(results[k].mean) + ', ' + Math.round(results[k].std) + ')';
		   });
	//FIXME
	this.rawRecords.push(stats);
	this.rawRecords.each(function (record) {
				 var trEl = document.createElement('tr');
				 var values = [record.pointing, record.m2k, record.typing, record.k2m];
				 values.each(function (val) {
						 var tdEl = document.createElement('td');
						 tdEl.innerHTML = value2Str(val);
						 trEl.appendChild(tdEl);
					     });
				 tableEl.appendChild(trEl);
			     });
	$('start-time').innerHTML = startTime;
	var d = new Date();
	$('end-time').innerHTML = 'End Time: ' + d.getHours() + ":" + d.getMinutes() + ":" + d.getSeconds() + ":" + d.getMilliseconds();
	$('errors').innerHTML = 'Errors: ' + this.errorCnt;
	$('results').appear();
	$('results').scrollTo();
    },


    createRectangle: function(left, top,  width, height) {
	var rectel = document.createElement('div');
	rectel.style.top = top + "px";
	rectel.style.left = left + "px";
	rectel.style.width = width + "px";
	rectel.style.height = height + "px";
	document.body.appendChild(rectel);
	return rectel;
    },

    createCircle: function(x, y, radius, color) {
	var circleel = document.createElement('canvas');
	circleel.style.top = (y - radius) + "px";
	circleel.style.left = (x - radius) + "px";
	circleel.width = radius * 2;
	circleel.height = radius * 2;

	document.body.appendChild(circleel);

	var ctx = circleel.getContext("2d");
	ctx.fillStyle = color;
	ctx.beginPath();
	ctx.arc(100, 100, 100, 0, Math.PI * 2, true);
	ctx.fill();

	return circleel;
    },

    distance: function (x1, y1, x2, y2) {
	return Math.sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    }

};

