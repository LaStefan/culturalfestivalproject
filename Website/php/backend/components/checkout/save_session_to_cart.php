<?php

session_start();


if (!empty($_SESSION['tickettype']) &&
    !empty($_SESSION['dateOne']) &&
    !empty($_SESSION['quantity'])){

    if (empty($_SESSION['cart'])){
        $_SESSION['cart'] = [];
    }

    $cartItemId = count($_SESSION['cart']);

    $_SESSION['cart'][$cartItemId] = [
        'tickettype' => $_SESSION['tickettype'],
        'dateOne' => $_SESSION['dateOne'],
        'quantity' => $_SESSION['quantity'],
    ];

    if (!empty($_SESSION['dateTwo'])){
        array_merge($_SESSION['cart'][$cartItemId], [
            'dateTwo' => $_SESSION['dateTwo'],
        ]);
    }

    unset($_SESSION['tickettype']);
    unset($_SESSION['dateOne']);
    unset($_SESSION['quantity']);
    unset($_SESSION['dateTwo']);
}

