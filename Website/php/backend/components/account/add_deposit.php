<?php
session_start();

require_once __DIR__ . '/../db/db.php';

$customerId = (int) $_SESSION['customerId'];

$money = $_POST['money'];

$newBalance = getBalance($customerId) + $money;

addBalance($newBalance, $customerId);

print json_encode($newBalance);

function getbalance($customerId){

    $stmt = DB()->prepare("SELECT `Balance` FROM `customer` WHERE `CustomerId` = :customerId");

    $stmt->execute([
        ':customerId' => $customerId
    ]);

    return (int) $stmt->fetchColumn();
}

function addBalance($newBalance, $customerId){

    DB()->query("
       UPDATE `customer`
       SET `Balance` = $newBalance
       WHERE `CustomerId` = $customerId
    ");

}


