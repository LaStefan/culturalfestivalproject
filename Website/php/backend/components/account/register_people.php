<?php

session_start();

require("../db/db.php");

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

print(
    json_encode(true)
);
