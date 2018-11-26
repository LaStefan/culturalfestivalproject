<?php

session_start();



function addToCart(){

    if (empty($_SESSION['cart'])) {
        $_SESSION['cart'] = [];
    }





}