var divName = document.getElementsByClassName('popup')[0];
var message = document.getElementsByClassName('messageBox')[0];
var hidden = true;
var hiddenMessage = true;

function showUp() {
    if(hidden == true) {
        divName.style.display = 'block';
        divName.scrollIntoView(false);
        message.style.display = 'none';
    }
}

function showMessage() {
    divName.style.display = 'none';
    if(hiddenMessage == true) {
        message.style.display = 'block';
        message.scrollIntoView(false);
    }
}

function Cancel() {
    divName.style.display = 'none';
    message.style.display = 'none';
}