var payment = document.getElementsByClassName('paymentMain')[0];
var account = document.getElementsByClassName('form')[0];

function switchPanel() {
    account.style.display = 'none';
    payment.style.display = 'block';
}