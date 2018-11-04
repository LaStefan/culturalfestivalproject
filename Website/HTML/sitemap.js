var divName = document.getElementsByClassName('popup')[0];
var hidden = true;

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