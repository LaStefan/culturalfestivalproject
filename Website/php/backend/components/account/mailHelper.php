<?php

require_once(__DIR__ . "/../../../vendor/autoload.php");
require_once(__DIR__ . "/../db/db.php");

use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;

?>

<?php

function sendConfirmationMail($email, $name, $message){

    $mail = new PHPMailer();

    try {
        //Server settings
        $mail->SMTPDebug = 2;                                   // Enable verbose debug output
        $mail->isSMTP();                                        // Set mailer to use SMTP
        $mail->Host = 'smtp.gmail.com';                         // Specify main and backup SMTP servers
        $mail->SMTPAuth = true;                                 // Enable SMTP authentication
        $mail->Username = 'propgroup10@gmail.com';              // SMTP username
        $mail->Password = 'Prop_Group1104';                     // SMTP password
        $mail->SMTPSecure = 'tls';                              // Enable TLS encryption, `ssl` also accepted
        $mail->Port = 587;                                      // TCP port to connect to

        //Recipients
        $mail->setFrom('PropGroup10@gmail.com', 'European Cultural Festival');
        $mail->addAddress($email, $name);                       // Add a recipient

        //Content
        $mail->isHTML(true);                                    // Set email format to HTML
        $mail->Subject = 'Here is the subject';
        $mail->Body    = $message;
        $mail->AltBody = 'This is the body in plain text for non-HTML mail clients';

        $mail->send();
        echo 'Message has been sent';
    } catch (Exception $e) {
        echo 'Message could not be sent. Mailer Error: ', $mail->ErrorInfo;
    }



}


function getConfirmationMessage($customer){

    $message = "<p>Hi ". $customer[0]['FirstName'] ."</p>";

    $message .= "<p>Thank you for the purchase.</p> " ;
    $message .= "<p> Details:</p>";
    $message .= "<p> Ticket Identification:  " .$customer[0]['CustomerId']. "</p>";
    $message .= "<p> Ticket Type:  " .$customer[0]['TicketType']. "</p>";

    if (!empty($customer[0]['CampingSiteId'])) {
        $message .= "<p> Camping Spot Id:  " .$customer[0]['CampingSiteId']. "</p>";
    };

    $message .= "<p>Best regards, <br /> The Management</p>";

    return $message;

}

