<?php

session_start();

$_SESSION['previous-page'] = 'confirmation';

header('Location: ../index.php');