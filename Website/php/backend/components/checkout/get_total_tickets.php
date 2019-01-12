<?php

session_start();

if (!empty($_SESSION['cart']['totalTickets'])) {
    if ($_SESSION['cart']['totalTickets'] > 0) {

        print json_encode(true); die();

    }
}

print json_encode(false); die();
