<?php

session_start();

                        $html = "

                            <fieldset id=\"FormAcc\">
                                <h2 class=\"accTitle\">Create an account</h2>
                                <div class=\"top-row\">
                                    <div class=\"field-wrap\">
                                        <label id=\"Accountlabel\">
                                            First Name<span class=\"req\">*</span>
                                        </label>
                                        <input name=\"firstName1\" class=\"Accountinput\" type=\"text\" required autocomplete=\"off\"/>
                                    </div>

                                    <div class=\"field-wrap\">
                                        <label id=\"Accountlabel\">
                                            Last Name<span class=\"req\">*</span>
                                        </label>
                                        <input name=\"lastName1\" class=\"Accountinput\" type=\"text\" required autocomplete=\"off\"/>
                                    </div>
                                </div>

                                <div class=\"field-wrap\">
                                    <label id=\"Accountlabel\">
                                        Email Address<span class=\"req\">*</span>
                                    </label>
                                    <input name=\"email1\" class=\"Accountinput\" type=\"email\" required autocomplete=\"off\"/>
                                </div>

                                <div class=\"field-wrap\">
                                    <label id=\"Accountlabel\">
                                        Set a password<span class=\"req\">*</span>
                                    </label>
                                    <input name=\"password1\" class=\"Accountinput\" type=\"password\" required autocomplete=\"off\"/>
                                </div>";

                            if ($_SESSION['cart']['totalTickets'] == 1){

                                // submit button on last loop
                                $html .= "<input type=\"submit\" id=\"nextBt\" name=\"submit\" class=\"next submitRegistration action-button\"
                                           value=\"Confirm\"/>
                                             <input type=\"button\" id=\"previousBt\" name=\"previous\" class=\"previous action-button\"
                                           value=\"Previous\"/>
                                           </fieldset>";

                            } else {
                                $html .= "<input type=\"button\" id=\"nextBt\" name=\"next\" class=\"next action-button\"
                                       value=\"Register next person\"/>
                                        </fieldset>";
                            }




for ($i = 0; $i <= (int) $_SESSION['cart']['totalTickets'] - 2; $i++){

    $personNumber = $i + 2;

    $html .= "<fieldset id=\"FormAcc\">
            <h2 class=\"accTitle\">Person " . $personNumber . "</h2>
            <div class=\"top-row\">
                <div class=\"field-wrap\">
                    <label id=\"Accountlabel\">
                        First Name<span class=\"req\">*</span>
                    </label>
                    <input name=\"firstName".$personNumber."\" class=\"Accountinput\" type=\"text\" required autocomplete=\"off\"/>
                </div>

                <div class=\"field-wrap\">
                    <label id=\"Accountlabel\">
                        Last Name<span class=\"req\">*</span>
                    </label>
                    <input name=\"lastName".$personNumber."\" class=\"Accountinput\" type=\"text\" required autocomplete=\"off\"/>
                </div>
            </div>

            <div class=\"field-wrap\">
                <label id=\"Accountlabel\">
                    Email Address<span class=\"req\">*</span>
                </label>
                <input name=\"email".$personNumber."\" class=\"Accountinput\" type=\"email\" required autocomplete=\"off\"/>
            </div>

            <div class=\"field-wrap\">
                <label id=\"Accountlabel\">
                    Set a password<span class=\"req\">*</span>
                </label>
                <input name=\"password".$personNumber."\" class=\"Accountinput\" type=\"password\" required autocomplete=\"off\"/>
            </div>";

    if ($i == (int) $_SESSION['cart']['totalTickets'] - 2){

        // submit button on last loop
        $html .= "<input type=\"submit\" id=\"nextBt\" name=\"submit\" class=\"next submitRegistration action-button\"
                   value=\"Confirm\"/>
                     <input type=\"button\" id=\"previousBt\" name=\"previous\" class=\"previous action-button\"
                   value=\"Previous\"/>
                     </fieldset>";

    } else {

        // render normal next button to next registration panel
        $html .= " 
            <input type=\"button\" id=\"nextBt\" name=\"next\" class=\"next action-button\"
                   value=\"Register next person\"/>
            <input type=\"button\" id=\"previousBt\" name=\"previous\" class=\"previous action-button\"
                   value=\"Previous\"/>
        </fieldset>";

    }
}

print $html;

?>



