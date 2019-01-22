<?php

require_once("../db/db.php");

$stmt = DB()->prepare("
    SELECT * FROM
    `campingsite` 
    WHERE 1
");

$stmt->execute();

print (json_encode($stmt->fetchAll()));

