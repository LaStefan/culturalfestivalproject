<?php
/**
 * Created by PhpStorm.
 * User: Gebruiker
 * Date: 26/03/2018
 * Time: 15:47
 */
// database Connection variables
//define('HOST', 'studmysql01.fhict.local'); // Database host name ex. localhost
//define('USER', 'dbi401148'); // Database user. ex. root ( if your on local server)
//define('PASSWORD', '123456789'); // user password  (if password is not set for user then keep it empty )
//define('DATABASE', 'dbi401148'); // Database Database name

define('HOST', 'localhost'); // Database host name ex. localhost
define('USER', 'root'); // Database user. ex. root ( if your on local server)
define('PASSWORD', ''); // user password  (if password is not set for user then keep it empty )
define('DATABASE', 'dbi401148'); // Database Database name

function DB()
{
    try {
        $db = new PDO('mysql:host='.HOST.';dbname='.DATABASE.'', USER, PASSWORD);
        ////    // set the PDO error mode to exception
        $db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        return $db;
    } catch (PDOException $e) {
        die("PDO Error!: " . $e->getMessage());
    }
}

