<?php

session_start();

require_once("../db/db.php");

$conn = DB();

$persons = [];

// fetch all persons from posted values and sort them by person number
foreach ($_POST as $key => $value) {

    // get the person number from the key
    $personNumber = (int) preg_replace('/[^0-9]/', '', $key);

    if (strpos($key, 'firstName') !== false) {

        $persons[$personNumber]['firstName'] = $value;

    } else if(strpos($key, 'lastName') !== false) {

        $persons[$personNumber]['lastName'] = $value;

    } else if(strpos($key, 'email') !== false) {

        $persons[$personNumber]['email'] = $value;

    } else if(strpos($key, 'password') !== false) {

        $persons[$personNumber]['password'] = $value;

    }
}

$_SESSION['persons'] = $persons;

$html = "<h2 class=\"whitetext\">Personal details:</h2><div><table class='whitetext registration-details'><br />";

foreach ($persons as $person){
    $html .= "

    <tr>
        <td>Firstname: </td>
        <td>" . $person['firstName'] . "</td>
    </tr>
    <tr>
        <td>Lastname: </td>
        <td>" . $person['lastName'] . "</td>
    </tr>
    <tr>
        <td>Email: </td>
        <td>" . $person['email'] . "</td>
    </tr>
    <tr>
        <td>Password: </td>
        <td>" . $person['password'] . "</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>";
}

$html .= "</table></div>";

?>


<?php

print (
    $html
);
