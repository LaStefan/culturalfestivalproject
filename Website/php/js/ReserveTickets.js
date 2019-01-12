function ShowIt(el) {

    var ticketDiv = $(el).parent();

    var tickettype;
    var ticketPrice;

    if (ticketDiv.attr('id') === "TicketOne"){

        tickettype = 1;
        ticketPrice = 59;

        $('#successMessage').hide();
        $('.reserveTickets').show();
        $('.pick-date-two').hide();

    } else if (ticketDiv.attr('id') === "TicketTwo") {

        tickettype = 2;
        ticketPrice = 109;

        $('#successMessage').hide();
        $('.reserveTickets').show();
        $('.pick-date-two').show();

    } else if (ticketDiv.attr('id') === "TicketThree") {

        tickettype = 3;
        ticketPrice = 159;

        $('#successMessage').hide();
        $('.reserveTickets').show();
        $('.pick-date-two').show();

    }

    $.ajax({
        url: 'backend/components/session/set_session_variable.php',
        method: 'POST',
        dataType: 'json',
        data: {
            tickettype: tickettype,
            ticketPrice: ticketPrice
        },
        complete: function (){
        }
    });

};
