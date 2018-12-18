<?php

session_start();

$html = "";

for ($i = 0; $i <= (int) $_SESSION['cart']['totalTickets'] - 1; $i++){

    $personNumber = $i + 1;

    $html .= "<fieldset id=\"FormAcc\">
            <h2 class=\"accTitle\">Person " . $personNumber . "</h2>
            <div class=\"top-row\">
                <div class=\"field-wrap\">
                    <label id=\"Accountlabel\">
                        First Name<span class=\"req\">*</span>
                    </label>
                    <input class=\"Accountinput\" type=\"text\" required autocomplete=\"off\"/>
                </div>

                <div class=\"field-wrap\">
                    <label id=\"Accountlabel\">
                        Last Name<span class=\"req\">*</span>
                    </label>
                    <input class=\"Accountinput\" type=\"text\" required autocomplete=\"off\"/>
                </div>
            </div>

            <div class=\"field-wrap\">
                <label id=\"Accountlabel\">
                    Email Address<span class=\"req\">*</span>
                </label>
                <input class=\"Accountinput\" type=\"email\" required autocomplete=\"off\"/>
            </div>

            <div class=\"field-wrap\">
                <label id=\"Accountlabel\">
                    Set a password<span class=\"req\">*</span>
                </label>
                <input class=\"Accountinput\" type=\"password\" required autocomplete=\"off\"/>
            </div>
            <input type=\"button\" id=\"nextBt\" name=\"next\" class=\"next action-button\"
                   value=\"Register next person\"/>
            <input type=\"button\" id=\"previousBt\" name=\"previous\" class=\"previous action-button\"
                   value=\"Previous\"/>
        </fieldset>";

}

print $html;

?>



