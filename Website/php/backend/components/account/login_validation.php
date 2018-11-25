<?php

session_start();

require __DIR__ . '/../db/db.php';
require __DIR__ . '/account_helper.php';

if (login($_POST['email'], $_POST['password'])){
//    $_SESSION['loggedIn'] = true;
//    $_SESSION['userId'] = ;
}

function login($email, $password)
{
    $stmt = DB()->prepare("SELECT `CustomerId`, `Password` FROM `customer` WHERE `Email` = :email");

    $stmt->execute(['email' => $email]);

    $result = $stmt->fetchAll();

    if (!empty($result)){
        
    }

    var_dump($result);


    return false;
}

