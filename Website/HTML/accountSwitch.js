var messageBox = document.getElementsByClassName('messageBox')[0];
var account = document.getElementsByClassName('form')[0];

function switchPanel() {
    console.log(555)
    account.style.display = 'none';
    messageBox.style.display = 'flex';
}