var payment = document.getElementsByClassName('paymentMain')[0];
var account = document.getElementsByClassName('form')[0];

var called = false;




$('.form').find('input').on('keyup blur focus', function (e) {
  
  var $this = $(this),
      label = $this.prev('label');
	  if (e.type === 'keyup') {
			if ($this.val() === '') {
          label.removeClass('active highlight');
        } else {
          label.addClass('active highlight');
            }
    } else if (e.type === 'blur') {
    	if( $this.val() === '' ) {
    		label.removeClass('active highlight');
			} else {
		    label.removeClass('highlight');
			}
    } else if (e.type === 'focus') {
      
      if( $this.val() === '' ) {
    		label.removeClass('highlight');
			}
      else if( $this.val() !== '' ) {
		    label.addClass('highlight');
      }
    }
});

$('.tab a').on('click', function (e) {
  
  e.preventDefault();
  
  $(this).parent().addClass('active');
  $(this).parent().siblings().removeClass('active');
  
  target = $(this).attr('href');

  $('.tab-content > div').not(target).hide();
  
  $(target).fadeIn(600);
  
});

function switchPanels() {
    var pass = document.getElementsByClassName('passwordInput')[0].value;
    var email = document.getElementsByClassName('emailInput')[0].value;
    var fn = document.getElementsByClassName('fnInput')[0].value;
    var ln = document.getElementsByClassName('lnInput')[0].value;

    if(!isEmpty(pass) && !isEmpty(email) && !isEmpty(fn) && !isEmpty(ln)) {
        called = true;
    }
    if(called == true) {
        account.style.display = 'none';
        payment.style.display = 'block';
    }

}

function isEmpty(str){
    return !str.replace(/\s+/, '').length;
}