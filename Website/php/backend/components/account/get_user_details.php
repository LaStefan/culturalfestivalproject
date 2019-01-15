<?php

require_once(__DIR__ . "/../db/db.php");

$customerId = $_SESSION['customerId'];

$stmt = DB()->prepare("
    SELECT `CustomerId`, `FirstName`, `LastName`, `Email`, `Balance`, `CampingSiteId`, `TicketType`
    FROM `customer`
    WHERE `CustomerId` = :customerId    
");

$stmt->execute([
    ':customerId' => $customerId
]);

return $stmt->fetchAll();

