<?php

session_start();

if (!empty($_SESSION['cart'][$_POST['id']])) {

    if (!empty($_SESSION['cart']['totalTickets']) && !empty($_SESSION['cart'][(int) $_POST['id']]['quantity'])){
        $_SESSION['cart']['totalTickets'] -= $_SESSION['cart'][(int) $_POST['id']]['quantity'];
    }

    unset ($_SESSION['cart'][$_POST['id']]);

    print json_encode($_POST['id']);
}

