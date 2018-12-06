$( document ).ready(function() {

    $("#nextOne").click(function() {
        console.log("test123");

        $.ajax({
            type:"GET",
            url:'backend/components/checkout/render_paypal.php',
            success: function(response) {
                $(".paypal").replaceWith(response);
            }
        });


    });


    $("#addTicketsToCart").click(function(){

        var dateOne = $("#dateOne").val();
        var dateTwo = $("#dateTwo").val();
        var quantity = $(".ticket-quantity").val();

        var json = {
            dateOne: dateOne,
            dateTwo: dateTwo,
            quantity: quantity
        };

        $.ajax({
            type:"POST",
            dataType:"JSON",
            data:json,
            url:'backend/components/ajax/set_session_variable.php',
            complete: function() {

                $(".reserveForm").replaceWith(
                    "<div class='reserveForm'>" +
                        "<p class='headingText'>Tickets successfully added to cart</p>" +
                    "</div>"
                );
            }
        });

        $.ajax({
            type:"GET",
            url:'backend/components/checkout/save_session_to_cart.php',
            complete: function() {
                console.log("this session is success");
            }
        })
    });


});
