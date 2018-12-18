<?php

session_start();

// Set ticket type in session
if (!empty($_POST)){
    foreach ($_POST as $key => $value) {
        unset($_SESSION[$value]);
    }
}


