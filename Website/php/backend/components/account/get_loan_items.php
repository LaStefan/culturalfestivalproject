<?php

if (session_status() == PHP_SESSION_NONE) {
    session_start();
}

require_once(__DIR__ . "/../db/db.php");

$stmt = DB()->prepare("
    SELECT * FROM loanitem
    WHERE `customerId` = :customerId
      AND `ReturnDate` is null
");

$stmt->execute([
    ':customerId' => $_SESSION['customerId']
]);

$loanItems = $stmt->fetchAll();

foreach ($loanItems as &$loanItem) {

    $stmt = DB()->prepare("
      SELECT `ProductName` FROM loan
      WHERE `LoanId` = :loanId
    ");

    $stmt->execute([
        ':loanId' => $loanItem['LoanId']
    ]);

    $productName = $stmt->fetchColumn();

    $loanItem['productName'] = $productName;
}

return $loanItems;

