<?php

$customerId = $_SESSION['customerId'];

$stmt = DB()->prepare("
    SELECT `FirstName`, `LastName`, `Email`, `Balance`, `CampingSiteId`, `TicketType`
    FROM `customer`
    WHERE `CustomerId` = :customerId    
");

$stmt->execute([
    ':customerId' => $customerId
]);

return $stmt->fetchAll();

