function gup(name) {
  name = name.replace(/[\[]/,"\\\[").replace(/[\]]/,"\\\]");
  var regex = new RegExp("[\\?&]"+name+"=([^&#]*)");
  var results = regex.exec(window.location.href);
  return results == null ? null : results[1];
}

function drawCircle(x, y, radius, color) {
  var canvas = document.getElementById("canvas");
  var ctx = canvas.getContext("2d");
  ctx.fillStyle = color;
  ctx.beginPath();
  ctx.arc(x, y, radius, 0, Math.PI * 2, true);
  ctx.fill();
}


function getCheckedValue(radioObj) {
    if(!radioObj)
	return "";
    var radioLength = radioObj.length;
    if(radioLength == undefined)
	if(radioObj.checked)
	    return radioObj.value;
	else
	    return "";
    for(var i = 0; i < radioLength; i++) {
	if(radioObj[i].checked) {
	    return radioObj[i].value;
	}
    }
    return "";
}
