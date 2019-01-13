<?php

session_start();

require("./ticketHelper.php");

$ticketTypes = getTicketTypes();

                        $html = "

                            <fieldset id=\"FormAcc\">
                                <h2 class=\"accTitle\">Create an account</h2>
                                <h3 class='accTitle'>Tickettype ". $ticketTypes[0] ."</h3>
                                <div class=\"top-row\">
                                    <div class=\"field-wrap\">
                                        <label class='regLabel'>
                                            First Name<span class=\"req\">*</span>
                                        </label>
                                        <input name=\"firstName1\" class=\"Accountinput\" type=\"text\" required autocomplete=\"off\"/>
                                    </div>

                                    <div class=\"field-wrap\">
                                        <label class='regLabel'>
                                            Last Name<span class=\"req\">*</span>
                                        </label>
                                        <input name=\"lastName1\" class=\"Accountinput\" type=\"text\" required autocomplete=\"off\"/>
                                    </div>
                                </div>

                                <div class=\"field-wrap\">
                                    <label class='regLabel'>
                                        Email Address<span class=\"req\">*</span>
                                    </label>
                                    <input name=\"email1\" class=\"Accountinput\" type=\"email\" required autocomplete=\"off\"/>
                                </div>

                                <div class=\"field-wrap\">
                                    <label class='regLabel'>
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
            <h3 class='accTitle'>Tickettype ". $ticketTypes[$i + 1] ."</h3>
            <div class=\"top-row\">
                <div class=\"field-wrap\">
                    <label  class='regLabel'>
                        First Name<span class=\"req\">*</span>
                    </label>
                    <input name=\"firstName".$personNumber."\" class=\"Accountinput\" type=\"text\" required autocomplete=\"off\"/>
                </div>

                <div class=\"field-wrap\">
                    <label  class='regLabel'>
                        Last Name<span class=\"req\">*</span>
                    </label>
                    <input name=\"lastName".$personNumber."\" class=\"Accountinput\" type=\"text\" required autocomplete=\"off\"/>
                </div>
            </div>

            <div class=\"field-wrap\">
                <label  class='regLabel'>
                    Email Address<span class=\"req\">*</span>
                </label>
                <input name=\"email".$personNumber."\" class=\"Accountinput\" type=\"email\" required autocomplete=\"off\"/>
            </div>

            <div class=\"field-wrap\">
                <label class='regLabel'>
                    Set a password<span class=\"req\">*</span>
                </label>
                <input name=\"password".$personNumber."\" class=\"Accountinput\" type=\"password\" required autocomplete=\"off\"/>
            </div>";

    if ($i == (int) $_SESSION['cart']['totalTickets'] - 2){

        // submit button on last loop
        $html .= "<input type=\"submit\" id=\"nextBt\" name=\"submit\" class=\"next nextMain submitRegistration action-button\"
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



