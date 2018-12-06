<?php
session_start();

$html = "<div class=\"paypal\">
                <div class=\"paypal__header\">
                    <div class=\"paypal__logo-wrapper\">
                        <img src=\"images/tickets.png\" alt=\"tickets\" class=\"paypal__logo\">
                    </div>
                    <div class=\"paypal__header-info\">
                        <span class=\"paypal__date\"><p id=\"date\"></p></span>
                    </div>
                </div>
                <div class=\"paypal__subheader-wrapper\">
                    <div class=\"paypal__subheader\">
                        <h1 class=\"paypal__username\">Hello</h1>
                        <span class=\"paypal__help-text\">You've purchased three (3) tickets for Cultural Festival 2019</span>
                    </div>
                </div>

                <div class=\"paypal__cart\">
                    <h2 class=\"paypal__cart-title\">Your tickets</h2>
                        <ul class=\"paypal__cart-list\">";


if (!empty($_SESSION['cart'])) {

    $i = 0;

    foreach ($_SESSION['cart'] as $cartItem) {

        switch ($cartItem['tickettype']) {
            case 1:
                $ticketName = "One Day Ticket";
                $ticketPrice = "59";
                break;
            case 2:
                $ticketName = "Two Day Ticket";
                $ticketPrice = "109";
                break;
            case 3:
                $ticketName = "Full Package Ticket";
                $ticketPrice = "109";
                break;
        }

        $html .= "<li class=\"paypal__cart-item\">
                            <span class=\"paypal__index\">" . $i . "</span>
                            <span class=\"paypal__item-name\">" . $ticketName . "</span>
                            <span class=\"paypal__item-price\">" . $ticketPrice . "</span>
                        </li>";

        $i++;
    }

}

$html .= "</ul>
                </div>

                <div class=\"paypal__footer\">
                    <img src=\"images/barcode.png\" alt=\"Barcode\" class=\"paypal__barcode\">
                </div>
            </div>";

print $html;