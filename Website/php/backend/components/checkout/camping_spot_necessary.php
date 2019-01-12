<?php
session_start();

if (!empty($_SESSION['cart'])){

    foreach ($_SESSION['cart'] as $cartItem){
        if (!empty($cartItem['tickettype']) && $cartItem['tickettype'] != "1") {

            print json_encode("true"); die();

        }
    }
}

print json_encode("false"); die();
