<?php

session_start();

if (!empty($_SESSION['cart'])){

    $totalPrice = 0;

    foreach($_SESSION['cart'] as $key => $cartItem){

        if($key !== 'totalTickets' && $key !== 'cp'){

            switch ($cartItem['tickettype']) {
                case 1:
                    $ticketPrice = "59";
                    break;
                case 2:
                    $ticketPrice = "109";
                    break;
                case 3:
                    $ticketPrice = "159";
                    break;
            }

            $totalPrice += (int) $ticketPrice * $cartItem['quantity'];

        } elseif ($key == 'cp') {

            $totalPrice += (int) $cartItem['cpPrice'];

        }

    }

}

print json_encode($totalPrice);

