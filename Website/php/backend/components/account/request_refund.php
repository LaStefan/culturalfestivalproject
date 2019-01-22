<?php

require_once("../db/db.php");

if (session_status() == PHP_SESSION_NONE) {
    session_start();
}

$customerId = $_SESSION['customerId'];

$stmt = DB()->prepare("DELETE FROM `loanitem` WHERE `CustomerId` = :CustomerId");

$stmt->execute([
    ":CustomerId" => $customerId
]);

$stmt = DB()->prepare("DELETE FROM `customer` WHERE `CustomerId` = :CustomerId");

$stmt->execute([
    ":CustomerId" => $customerId
]);

unset($_SESSION['customerId'], $_SESSION['loggedIn']);

print true;
