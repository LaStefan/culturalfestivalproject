<?php

// Count the amount of tickets, and return true if the amount of tickets posted would be more then 6
// if the tickets would be added

session_start();

$_POST['quantity'];

if (!empty($_SESSION['cart']['totalTickets'])){

    if ((int) $_POST['quantity'] + (int) $_SESSION['cart']['totalTickets'] > 6) {

        print json_encode(false);

    } else {

        print json_encode(true);

    }

} else {

    print json_encode(true);

}

