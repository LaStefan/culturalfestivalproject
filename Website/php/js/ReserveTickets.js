function ShowIt(el) {

    var ticketDiv = $(el).parent();

    var tickettype;

    if (ticketDiv.attr('id') === "TicketOne"){

        tickettype = 1;
        $('.pick-date-two').hide();

    } else if (ticketDiv.attr('id') === "TicketTwo") {

        tickettype = 2;

        $('.pick-date-two').show();

    } else if (ticketDiv.attr('id') === "TicketThree") {

        tickettype = 3;

        $('.pick-date-two').show();

    }

    $.ajax({
        url: 'backend/components/ajax/set_session_variable.php',
        method: 'POST',
        dataType: 'json',
        data: {tickettype: tickettype},
        complete: function (){
            console.log("complete function");
        }
    });

    var obj = document.getElementsByClassName('reserveTickets')[0];
    if (obj.style.display == "none") {
        obj.style.display = "block";
        obj.scrollIntoView(false);
    }
    else
        obj.style.display = "none";
};
