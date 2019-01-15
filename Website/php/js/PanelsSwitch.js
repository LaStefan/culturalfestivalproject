var current_fs, next_fs, previous_fs; 
var left, opacity, scale; 
var animating;
var check = true;

function Agree() {
    this.check = true;
}

function Disagree() {
    this.check = false;
}

$(".nextMain").click(function(){

    if(animating) return false;
    animating = true;
    current_fs = $(this).parent();
    next_fs = $(this).parent().next();



    $("#progress li").eq($("figure").index(next_fs)).addClass("active");

    if(check == true){
        next_fs.show();
    }
    else {
        current_fs = $(this).parent();
        next_fs = $(this).parent().next().next();
        next_fs.show();
        $("#progress li").eq($("figure").index(next_fs)).addClass("active");
    }

    check = true;
    current_fs.animate({opacity: 0}, {
        step: function(now, mx) {
            scale = 1 - (1 - now) * 0.2;
            left = (now * 50)+"%";
            opacity = 1 - now;
            current_fs.css({
                'transform': 'scale('+scale+')',
                'position': 'absolute'
            });
            next_fs.css({'left': left, 'opacity': opacity});
        },
        duration: 2,
        complete: function(){
            current_fs.hide();
            animating = false;
        },
        easing: 'easeInOutBack'
    });

});


$("#nextOne").click(function(){

    $.ajax({
        type:"GET",
        url: 'backend/components/checkout/get_total_tickets.php',
        success: function(response) {

			if(response === "false") {
			    alert("Please select a ticket.");
                window.location.replace("./Tickets.php");
			} else {

                $.ajax({
                    type:"GET",
                    url: 'backend/components/checkout/camping_spot_necessary.php',
                    success: function(response) {

                        if (response == "false"){

                            if(animating) return false;
                            animating = true;

                            current_fs = $("#nextOne").parent();
                            next_fs = $("#nextOne").parent().next().next().next();

                            $("#messageBox").hide();

                            next_fs.show();
                            $("#progress li").eq($("figure").index(next_fs)).addClass("active");


                            check = true;
                            current_fs.animate({opacity: 0}, {
                                step: function(now, mx) {
                                    scale = 1 - (1 - now) * 0.2;
                                    left = (now * 50)+"%";
                                    opacity = 1 - now;
                                    current_fs.css({
                                        'transform': 'scale('+scale+')',
                                        'position': 'absolute'
                                    });
                                    next_fs.css({'left': left, 'opacity': opacity});
                                },
                                duration: 2,
                                complete: function(){
                                    current_fs.hide();
                                    animating = false;
                                },
                                easing: 'easeInOutBack'
                            });

                        }
                    }
                });
            }
        }
    });
});

$(".previousMain").click(function(){
	if(animating) return false;
	animating = true;
	
	current_fs = $(this).parent();
	previous_fs = $(this).parent().prev();
	
	$("#progress li").eq($("figure").index(current_fs)).removeClass("active");
	
	previous_fs.show(); 
	current_fs.animate({opacity: 0}, {
		step: function(now, mx) {
			scale = 0.8 + (1 - now) * 0.2;
			left = ((1-now) * 50)+"%";
			opacity = 1 - now;
			current_fs.css({'left': left});
			previous_fs.css({'transform': 'scale('+scale+')', 'opacity': opacity});
		}, 
		duration: 2, 
		complete: function(){
			current_fs.hide();
			animating = false;
		}, 
		easing: 'easeInOutBack'
	});
});

$(".submit").click(function(){
	return false;
});