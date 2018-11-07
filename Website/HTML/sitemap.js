var divName = document.getElementsByClassName('popup')[0];
var hidden = true;
var cursorX;
var cursorY;

function showUp() {
    if(hidden == true) {
        divName.style.display = 'block';
        hidden = false;
        divName.scrollIntoView(false);
    }
    else { 
        console.log("444")
    }
}

function printMousePos() {
    document.onmousemove = function(e){
    cursorX = e.pageX;
    cursorY = e.pageY;
}
}

function selectSpot() {
    var spot = document.getElementsByClassName('select');
    printMousePos();
    spot.css('position', 'absolute');
    spot.css('top', cursorY);
    spot.css('left', cursorX);
}