<?php

session_start();

unset($_SESSION['customerId']);
unset($_SESSION['loggedIn']);

header('Location: ../../../Home.php');

