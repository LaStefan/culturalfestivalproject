$(document).ready(function() {

    $.ajax({
        type:"GET",
        dataType:"json",
        url:'backend/components/checkout/get_camping_spots.php',
        success: function(response) {

            var campingSiteId;

            for(var k in response) {
                // console.log(k, response[k]);

                var campingSiteId = response[k]['CampingSiteId'];

                var status = response[k]['Status'];

                if (status === "1"){
                    $("#cb" + campingSiteId).css('background-color', 'red');
                    $("#cb" + campingSiteId).addClass("spot-unavailable");
                }
            }
        }
    });

});

