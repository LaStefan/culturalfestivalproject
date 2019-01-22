$( document ).ready(function() {

    // after the next button is clicked, render the paypalpanel
    $(".nextMain").click(function() {
        $.ajax({
            type:"GET",
            url:'backend/components/checkout/render_paypal.php',
            success: function(response) {
                $(".paypal").replaceWith(response);
            }
        });
    });

    // add tickets to cart after the add button is clicked on the first page
    $("#addTicketsToCart").click(function(){

        var dateOne = $("#dateOne").val();
        var dateTwo = $("#dateTwo").val();
        var quantity = Number($(".ticket-quantity").val());

        if (quantity > 0){

            var json = {
                dateOne: dateOne,
                dateTwo: dateTwo,
                quantity: quantity
            };

            $.ajax({
                type: "POST",
                data: {
                    quantity: quantity
                },
                dataType: "JSON",
                url: "backend/components/checkout/can_add_ticket.php",
                success: function(response) {

                    if (response === true) {

                        $.ajax({
                            type:"POST",
                            dataType:"JSON",
                            data:json,
                            url:'backend/components/session/set_session_variable.php',
                            complete: function() {
                            }
                        });

                        $.ajax({
                            type:"GET",
                            url:'backend/components/checkout/save_session_to_cart.php',
                            complete: function() {
                                $('.reserveTickets').hide();
                                $('#successMessage').show();
                            }
                        });

                    } else {
                        alert("You're only allowed to order up to 6 tickets, sorry!");
                    }

                }
            });
        } else {

            alert("Select at least one ticket");

        }
    });

    // when a camping button is pressed, save it to the cart
    $('.campingButton').click(function() {

        if ($(this).hasClass("spot-unavailable")) {
            alert("This campingsite is already reserved");
            return;
        }

        var buttonId = $(this).attr('id').replace('cb', '');
        var cpPrice;
        var ticketType = "cp" + buttonId;

        if (buttonId > 0 && buttonId > 5) {
            cpPrice = 10;
        } else if (buttonId > 4 && buttonId < 9) {
            cpPrice = 15;
        } else {
            cpPrice = 20;
        }

        if (!confirm("Are you sure you want to reserve campingspot " + buttonId + " for " + cpPrice + " euro")){
            return
        }

        var json = {
            buttonId: buttonId,
            cpPrice: cpPrice
        };

        $.ajax({
            type:"POST",
            dataType:"JSON",
            data:json,
            url: 'backend/components/session/set_session_variable.php',
            complete: function() {
            }
        });

        $.ajax({
            type:"GET",
            url:'backend/components/checkout/save_session_to_cart.php',
            complete: function() {
                if($("[id^=cb]").hasClass('my-campingspot')){
                    $("[id^=cb]").removeClass('my-campingspot');
                }
                $("#cb" + buttonId).addClass('my-campingspot');
            }
        });


    });


    //render registration forms depending on the amount of ordered tickets
    $('#nextFour').click(function() {

        $.ajax({
            url:"backend/components/checkout/render_registration_form.php",
            type:"GET",
            success: function(response){

                $('#extraPersonRegistrations').replaceWith(response);

            }
        })

    });


    $("#nextSix").click(function() {

        var json = {
            data:"stringData"
        };

        if($("#creditCardNumber").val() !== "" && $("#expirationDate").val() !== "" && $("#cardValidationNumber").val() !== "") {

            $.ajax({
                url:"backend/components/checkout/finish_order.php",
                data: json,
                type:"POST",
                success: function(response){
                }
            });

            animating = true;

            current_fs = $(this).parent();
            next_fs = $(this).parent().next();

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
                    animating = false;
                },
                easing: 'easeInOutBack'
            });

        } else {

            alert("Please provide your valid credit card credentials ");

        }

    });
});

// remove items from cart
function removeCartItem(id) {

    json = {
        id: id
    };

    $.ajax({
        type:"POST",
        dataType:"JSON",
        data:json,
        url:'backend/components/checkout/remove_cart_item.php',
        success: function(response) {

            var paypalItemDivId = "paypal_item_nr" + response;

            $("#" + paypalItemDivId).remove();

            //recalculate total price
            $.ajax({
                type:"GET",
                url: "backend/components/checkout/get_total_price.php",
                success: function(response) {
                    $("#totalPriceField").text(response);
                }
            })

        }
    });
}




