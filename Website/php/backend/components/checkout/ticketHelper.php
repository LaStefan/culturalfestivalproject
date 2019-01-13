<?php

function getTicketTypes(){

    $ticketTypes = [];

    foreach($_SESSION['cart'] as $key => $cartItem) {

        if ($key !== 'cp' && $key !== 'totalTickets' && $key !== "persons"){

            for ($i = 0; $i < $cartItem['quantity']; $i++){

                switch ($cartItem['tickettype']) {
                    case 1:
                        $ticketString = "One Day Ticket";
                        break;
                    case 2:
                        $ticketString = "Two Day Ticket";
                        break;
                    case 3:
                        $ticketString = "Full Package";
                        break;
                }

                $ticketTypes[] = $ticketString;
            }

        }

    }

    return $ticketTypes;

}