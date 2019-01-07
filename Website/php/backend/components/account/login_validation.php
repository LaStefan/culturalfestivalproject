<?php

session_start();

require __DIR__ . '/../db/db.php';

login($_POST['email'], $_POST['password']);

header('Location: ../../../Tickets.php');


function login($email, $password)
{
    $stmt = DB()->prepare("SELECT `CustomerId`, `Password` FROM `customer` WHERE `Email` = :email");

    $stmt->execute(['email' => $email]);

    $result = $stmt->fetchAll();

    if (!empty($result)){
        if ($password == $result[0]['Password']) {

            $_SESSION['customerId'] = $result[0]['CustomerId'];
            $_SESSION['loggedIn'] = true;

            return true;

        }
    }

    return false;
}
