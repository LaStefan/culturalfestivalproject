<?php

session_start();

require("../db/db.php");

$conn = DB();

$persons = $_SESSION['persons'];

function validatePayment(){
    return true;
}

if (validatePayment()){

    $groupSize = count($persons);

    echo $groupSize; die();

    $i = 1;

    // save all persons to DB as new customers
    foreach ($persons as $personNumber => $person){

        $campingSiteId = (!empty($_SESSION['cart']['cp']['cpId']) ? $_SESSION['cart']['cp']['cpId'] : NULL);

        $ticketType = "";

        foreach($_SESSION['cart'] as $key => &$ticket) {
            if ($key !== 'cp' && $key !== 'totalTickets'){
                $ticketType = $ticket['tickettype'];

                $_SESSION['cart'][$key]['quantity'] -= 1;

                if ($_SESSION['cart'][$key]['quantity'] < 1){
                    unset($_SESSION['cart'][$key]);
                }

                $_SESSION['cart']['totalTickets'] -= 1;
            }

            if ($_SESSION['cart'][$key]['quantity'] <= 1) {
                unset($_SESSION['cart'][$key]);
            }

            break;
        }

        if($i == $groupSize){
            unset($_SESSION['cart']['cp']);
        };

        // TODO: choose ticket type per customer
        $sql = "INSERT INTO customer (FirstName, LastName, Email, Password, CampingSiteId, TicketType, Balance) VALUES (?,?,?,?,?,?,?)";
        $stmt = $conn->prepare($sql);
        $stmt->execute([
            $person['firstName'],
            $person['lastName'],
            $person['email'],
            $person['password'],
            $campingSiteId,
            $ticketType,
            0
        ]);

        unset($campingSiteId, $ticketType);
        $i++;
    }

    unset($i);
    unset($_SESSION['persons']);

    print(json_encode(true));


}

