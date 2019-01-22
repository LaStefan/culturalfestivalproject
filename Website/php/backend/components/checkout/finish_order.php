<?php

session_start();

require_once("../db/db.php");
require_once("../account/mailHelper.php");

$conn = DB();

$persons = $_SESSION['persons'];

function validatePayment(){
    return true;
}

if (validatePayment()){

    $groupSize = count($persons);

    $i = 1;

    // save all persons to DB as new customers
    foreach ($persons as $personNumber => $person){

        $campingSiteId = (!empty($_SESSION['cart']['cp']['cpId']) ? $_SESSION['cart']['cp']['cpId'] : NULL);

        $ticketType = "";

        foreach($_SESSION['cart'] as $key => &$ticket) {

            if ($key !== 'cp' && $key !== 'totalTickets' && $key !== "persons"){

                $ticketType = (int) $ticket['tickettype'];

                $_SESSION['cart'][$key]['quantity']--;

                if (isset($_SESSION['cart']['totalTickets'])) {
                    $_SESSION['cart']['totalTickets'] -= 1;
                }

            }

            if ($_SESSION['cart'][$key]['quantity'] < 1) {
                unset($_SESSION['cart'][$key]);
            }

            if(empty($ticketType)){
                continue;
            }

            break;
        }
        unset($ticket);

        switch ($ticketType) {
            case 1:
                $ticketString = "One Day Ticket";
                break;
            case 2:
                $ticketString = "Two Day Ticket";
                break;
            case 3:
                $ticketString = "Full Package";
                break;
        }

        // TODO: choose ticket type per customer
        $sql = "INSERT INTO customer (FirstName, LastName, Email, Password, CampingSiteId, TicketType, Balance, Status) VALUES (?,?,?,?,?,?,?,?)";

        $stmt = $conn->prepare($sql);

        $stmt->execute([
            $person['firstName'],
            $person['lastName'],
            $person['email'],
            $person['password'],
            $campingSiteId,
            $ticketString,
            0,
            'Not CheckedIn'
        ]);

        // gather all last id's
        $stmt = $conn->prepare("SELECT MAX(`CustomerId`) FROM `customer`");
        $stmt->execute();
        $lastId = $stmt->fetchColumn();

        //change status from campsite when people registered
        $stmt = $conn->prepare("UPDATE `campingsite` SET `Status` = 1 WHERE `CampingSiteId` = :campingSiteId");
        $stmt->execute([
            ':campingSiteId' => $campingSiteId
        ]);
        $stmt = $conn->prepare("UPDATE `customer` SET `CampingSiteStatus` = 1 WHERE `CampingSiteId` = :campingSiteId");
        $stmt->execute([
            ':campingSiteId' => $campingSiteId
        ]);


        $lastIds = [];
        for ($i = 0; $i < $groupSize; $i++){
            $lastIds[] = $lastId;
            $lastId--;
        }
        unset($campingSiteId, $ticketType);

        $i++;
    }

    unset($i);
    unset($_SESSION['persons']);
    unset($_SESSION['cart']['cp']);

    // send email to the last 4 ids
    $customers = [];

    $stmt = DB()->prepare("
            SELECT *
            FROM `customer`
            WHERE `CustomerId` = :customerId
        ");

    foreach ($lastIds as $id){

        $stmt->execute([
            ':customerId' => $id
        ]);

        $customers[] = $stmt->fetchAll(PDO::FETCH_ASSOC);

    }

    foreach($customers as $customer) {
        $message = getConfirmationMessage($customer);
        sendConfirmationMail($customer[0]['Email'], $customer[0]['FirstName'] . ' ' . $customer[0]['LastName'], $message);
    }

    print(json_encode(true));
}

