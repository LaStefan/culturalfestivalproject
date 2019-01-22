<?php

session_start();

// create cart session if none exist
if (empty($_SESSION['cart'])){
    $_SESSION['cart'] = [
        'totalTickets' => 0
    ];
}

echo 'test1';

// save tickets to cart
if (!empty($_SESSION['tickettype']) && !empty($_SESSION['quantity'])){


    echo 'test2';

    foreach ($_SESSION['cart'] as $key => &$cartItem) {
        // check if already there is a tickettype in the cart to add the quantity to it
        if ($cartItem['tickettype'] == $_SESSION['tickettype']){

            if ($_SESSION['totalTickets'] + $_SESSION['quantity'] >= 6) {

                unset($_SESSION['tickettype']);
                unset($_SESSION['dateOne']);
                unset($_SESSION['quantity']);
                unset($_SESSION['dateTwo']);

                return json_encode([
                    'success' => false,
                    'message' => "Can not order more then 6 tickets per customer"
                ]);
            }

            $cartItem['quantity'] += (int) $_SESSION['quantity'];
            $_SESSION['cart']['totalTickets'] += (int) $_SESSION['quantity'];

            $ticketsAdded = true;
            $lastKey = $key;
        }
    }
    unset($cartItem);

    // if the ticket quantity could not be added to an existing cart item, create a new one
    if (empty($ticketsAdded)){
        $_SESSION['cart'][] = [
            'tickettype' => $_SESSION['tickettype'],
            'dateOne' => $_SESSION['dateOne'],
            'quantity' => (int) $_SESSION['quantity'],
        ];
        $_SESSION['cart']['totalTickets'] += (int) $_SESSION['quantity'];
    }

    // if a date 2 is set save it to the correct cart item,
    // the array key is dependant on if it is the last array item or the key from the updated cart item
    if (!empty($_SESSION['dateTwo'])){
        array_merge($_SESSION['cart'][
            (empty($ticketsAdded) ? count($_SESSION['cart'] ) - 1 : $lastKey)
        ], [
            'dateTwo' => $_SESSION['dateTwo'],
        ]);
    }

    unset($_SESSION['tickettype']);
    unset($_SESSION['dateOne']);
    unset($_SESSION['quantity']);
    unset($_SESSION['dateTwo']);
}

echo 'test3';

// save camping reservations to cart
if (!empty($_SESSION['buttonId'] && !empty($_SESSION['cpPrice']))) {
    $_SESSION['cart']['cp']['cpId'] = (int) $_SESSION['buttonId'];
    $_SESSION['cart']['cp']['cpPrice'] = (int) $_SESSION['cpPrice'];

    unset($_SESSION['buttonId']);
    unset($_SESSION['cpPrice']);
}

echo 'test4';

