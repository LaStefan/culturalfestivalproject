<?php
    session_start();
?>



<?php

// Set ticket type in session
if (!empty($_POST)){
    foreach ($_POST as $key => $value) {
        $_SESSION[$key] = $value;
    }
}

