<?php

function hashPassword($password)
{
    return md5($password);
}

function checkPassword($password, $dbHash)
{
    if ($this->hashPassword($password) == $dbHash) {
        return true;
    }
    return false;
}


