var divName = document.getElementsByClassName('displayMsg')[0];
var hidden = true;
var cursorX;
var cursorY;

function showMsg() {
    if(hidden == true) {
        divName.style.display = 'block';
        hidden = false;
        divName.scrollIntoView(false);
    }
    else { 
        console.log("444")
    }
}



