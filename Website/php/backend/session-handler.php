<?php
/**
 * Created by PhpStorm.
 * User: Gebruiker
 * Date: 29/03/2018
 * Time: 05:47
 */

// checks if php session is already started before starting the session
function StartSession(){
    if (version_compare(phpversion(), '5.4.0', '<')) {
        if(session_id() == '') {
            session_start();
        }
    }
    else
    {
        if (session_status() == PHP_SESSION_NONE) {
            session_start();
        }
    }
}