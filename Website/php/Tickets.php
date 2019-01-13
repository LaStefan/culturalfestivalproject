<?php
    session_start();
?>
<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="css/stylesTickets.scss">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat|Open+Sans" rel="stylesheet">
    <link href="//netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Montserrat|Open+Sans" rel="stylesheet">
    <script type='text/javascript' src="js/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="js/checkout.js"></script>
    <script type="text/javascript" src="js/RegisterPeople.js"></script>
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600" rel="stylesheet">
    <title>TICKETS</title>
</head>
<header>
    <nav class="navbar navbar-default">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar"
                        aria-expanded="false" aria-controls="navbar">
                    <span class="sr-only"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#"><a class="navbar-brand"> <img src="images/logo.jpg" alt="logo"
                                                                               width="120"/></a></a>
            </div>
            <div id="navbar" href="#0" class="collapse navbar-collapse">
                <ul class="nav navbar-nav navbar-right">
                    <li><a id="n1" href="index.php">About</a></li>
                    <li><a id="n2" href="index.php#2">Countries</a></li>
                    <li><a id="n3" href="index.php#3">Location</a></li>
                    <li><a id="n4" href="index.php#4">Program</a></li>
                    <li><a href="Tickets.php">Tickets</a></li>
                    <li class="dropdown">
                        <a href="#logIn" class="dropdown-toggle" data-toggle="dropdown" style="color:#6e9987;">Account<span class="caret"></span></a>
                        <ul id="loginM" class="dropdown-menu">

                            <?php if (!isset($_SESSION['loggedIn']) || $_SESSION['loggedIn'] !== true): ?>

                                    <li>
                                        <div class="row">
                                            <div class="col-md-12">
                                                <form name="loginCustomer" action="backend/components/account/login_validation.php" method="post">
                                                    <div class="formLI">
                                                        <label id="labelIN">
                                                            Email <span id="spanReq" class="req">*</span>
                                                        </label>
                                                        <input id="inputLI" type="email" name="email" placeholder="Email"
                                                               required/>
                                                    </div>
                                                    <div class="formLI">
                                                        <label id="labelIN">
                                                            Password<span id="spanReq" class="req">*</span>
                                                        </label>
                                                        <input id="inputLI" type="password" name="password"
                                                               placeholder="Password"
                                                               required/>
                                                        <p class="forget">Forget Password?</p>
                                                    </div>
                                                    <div class="formLI">
                                                        <button class="buttonLI">Log In</button>
                                                    </div>
                                                </form>
                                            </div>
                                        </div>
                                    </li>

                            <?php else: ?>

                                <li>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <form name="logoutCustomer" action="backend/components/account/logout.php" method="post">
                                                <div class="formLI">
                                                    <button class="buttonLI">Log out</button>
                                                </div>
                                            </form>
                                        </div>
                                    </div>
                                </li>

                            <?php endif ?>

                        </ul>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
</header>
<body>
<section>
    <div id="MainForm">
        <ul id="progress">
            <li class="active">Select Ticket</li>
            <li>Do you want a camping spot?</li>
            <li>Select Camping Spot</li>
            <li>Your Tickets</li>
            <li>Personal Details</li>
            <li>Payment</li>
        </ul>

        <!-- Panel 1 -->
        <figure id="Panels">
            <input type="button" name="next" class="nextMain" id="nextOne" value="Next"/>
            <div class="ticketsRes">
                <div id="headingText"><p>BE PART OF OUR EVENT</p>
                </div>

                <br><br>
                <div id="TicketOne" class="ticket"><img src="images/Ticket1.jpg" alt="onedayticket" id="TicketImage"/>
                    <button id="GetTicket" onclick="ShowIt(this)">get a ticket</button>
                </div>

                <div id="TicketTwo" class="ticket"><img src="images/Ticket2.jpg" alt="twodaysticket" id="TicketImage"/>
                    <button id="GetTicket" onclick="ShowIt(this)">get a ticket</button>
                </div>

                <div id="TicketThree" class="ticket"><img src="images/Ticket3.jpg" alt="fullpackage" id="TicketImage"/>
                    <button id="GetTicket" onclick="ShowIt(this)">get a ticket</button>
                </div>

                <div class="reserveTickets">
                    <div class="reserveForm">
                        <div class="form-group">
                            <input class="formControl pick-date-one" type="date" id="dateOne" min="2019-01-18" max="2019-01-20" required>
                            <span class="form-label">Date</span>
                        </div>
                        <div class="form-group pick-date-two">
                            <input type="date" class="formControl" min="2019-01-18" max="2019-01-20" id="dateTwo"  required>
                            <span class="form-label">Second Date</span>
                        </div>
                        <div class="form-group">
                            <select class="formControl ticket-quantity" required>
                                <option value="" selected hidden>number of tickets</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                                <option>5</option>
                                <option>6</option>
                            </select>
                            <span class="form-label">People</span>
                        </div>

                        <button id="addTicketsToCart" type="button">Add</button>
                    </div>

                </div>

                <div class='whitetext' id="successMessage">
                    <p>Tickets successfully added to cart</p>
                </div>

            </div>
        </figure>

        <!-- Panel 2 -->
        <figure id="messageBox">
            <h1>Would you like a camping spot?</h1>
            <p id="additionalCost">*It includes additional costs</p>
            <button type="button" id="BtnQuest" class="nextMain" onclick="Agree()">YES</button>
            <button onclick="Disagree()" id="BtnQuest" type="button" class="nextMain">NO</button>
        </figure>

        <!-- Panel 3 -->
        <figure id="Panels">
            <input type="button" name="next" class="nextMain" id="nextThree" value="Next"/>
            <div class="campingSite">
                <div id="TicketRe">
                    <div class="formRe">
                        <div class="map">
                            <div class="left">
                                <button id="cb1" class="campingButton">1</button>
                                <button id="cb5" class="campingButton">5</button>
                                <button id="cb9" class="campingButton">9</button>
                                <button id="cb2" class="campingButton">2</button>
                                <button id="cb6" class="campingButton">6</button>
                                <button id="cb10" class="campingButton">10</button>
                                <button id="cb3" class="campingButton">3</button>
                                <button id="cb7" class="campingButton">7</button>
                                <button id="cb11" class="campingButton">11</button>
                            </div>
                            <div class="right">
                                <button id="cb12" class="campingButton">12</button>
                                <button id="cb8" class="campingButton">8</button>
                                <button id="cb4" class="campingButton">4</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </figure>

        <!-- Panel 4 -->
        <figure id="Panels">


            <div class="paypal">
                <div class="paypal__header">
                    <div class="paypal__logo-wrapper">
                        <img src="images/tickets.png" alt="tickets" class="paypal__logo">
                    </div>
                    <div class="paypal__header-info">
                        <span class="paypal__date"><p id="date"></p></span>
                    </div>
                </div>
                <div class="paypal__subheader-wrapper">
                </div>

                <div class="paypal__cart">
                    <h2 class="paypal__cart-title">Your tickets</h2>

                    <ul class="paypal__cart-list">
                        <li class="paypal__cart-item">
                            <span class="paypal__index">1</span>
                            <span class="paypal__item-name"></span>
                            <span class="paypal__item-price"></span>
                        </li>

                        <li class="paypal__cart-item">
                            <span class="paypal__index">2</span>
                            <span class="paypal__item-name"></span>
                            <span class="paypal__item-price"></span>
                        </li>

                        <li class="paypal__cart-item">
                            <span class="paypal__index">3</span>
                            <span class="paypal__item-name"></span>
                            <span class="paypal__item-price"></span>
                        </li>

                        <li class="paypal__cart-item">
                            <span class="paypal__cart-total">Total</span>
                            <span class="paypal__item-price"></span>
                        </li>
                    </ul>
                </div>

                <div class="paypal__footer">
                    <img src="images/barcode.png" alt="Barcode" class="paypal__barcode">
                </div>
            </div>

            <input type="button" name="next" class="nextMain" id="nextFour" value="Confirm"/>
        </figure>

        <!-- Panel 5 -->
        <figure id="Panels">
            <input type="button" name="next" class="nextMain" id="nextFive" value="Next"/>

            <form name="registerUsers" method="post" action="backend/components/account/register_people.php" id="registerPeople">

                <div id="TicketRe">
                    <div class="formRe">
                        <div id="AccountForm">

                            <ul id="progressAcc">
                                <li class="active"></li>
                                <li></li>
                                <li></li>
                                <li></li>
                                <li></li>
                                <li></li>
                            </ul>

                            <div id="extraPersonRegistrations">
                            </div>

                        </div>
                    </div>
                </div>
            </form>

            <div id="form_output">
            </div>

        </figure>

        <!-- Panel 6 -->
        <figure id="Panels">
            <input type="button" name="next" class="nextMain" id="nextSix" value="Pay and register"/>
            <div id="TicketRe">
                <div class="formRe">
                    <div class="paymentMain">
                        <div class="payment">
                            <div class="header">
                                <p id="headingText">
                                    PAYMENT METHOD
                                </p>
                                <img src="images/Visa.png" width="+275px" height="85px"><br>
                            </div>
                            <div class="details">
                                <div class="leftDetails">
                                    <p>Credit Card Name</p>
                                    <p>Credit Card Number</p>
                                    <p>Expiration Date</p>
                                    <p>Card Validation Number</p>
                                </div>
                                <div class="rightDetails">
                                    <div class="selection">
                                        <select>
                                            <option value="master">Master Card</option>
                                            <option value="maestro">Maestro</option>
                                            <option value="visa">VISA</option>
                                        </select>
                                    </div>
                                    <input class="Accountinput" type="text" placeholder="Credit Card Number">
                                    <input class="Accountinput" type="text" placeholder="MM/YYYY">
                                    <input class="Accountinput" type="text" placeholder="Card Validation Number">
                                </div>
                            </div>
                            <div class="proccess">

                            </div>

                        </div>
                    </div>

                </div>
            </div>
        </figure>

        <!-- Panel 7 -->
        <figure id="Panels">
            <div class="whitetext">

                <h4>Reservation Details</h4><br>
                <p><?php
                    // echo 'Hello '.$_SESSION['firstnameofguest'].',';
                    ?></p><br>
                <p>Thank you for showing interest in our festival.</p><br>
                <p>We have just sent you an email with details about how to make a reservation. </p><br>
                <p>An event account has been created for you with the login details to manage your information, you will
                    find the details included in your mail.
                <p>Please check your email </p><br><br>

                <p>Looking Forward to welcoming you to the European Cultural Event.</p><br><br>

                <p>Thanks....</p>
            </div>
        </figure>

    </div>
</section>
</body>

<footer>
    <div>&copy;CULTURAL FESTIVAL 2018. All rights reserved. Made by DevelopPro.</div>
</footer>

<script src="https://code.jquery.com/jquery-3.3.1.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<script src="js/home.js"></script>
<script src="js/sitemap.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/1.9.1/jquery.min.js" type="text/javascript"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"
        type="text/javascript"></script>
<script src="js/PanelsSwitch.js"></script>
<script src="js/RegisterPeople.js"></script>
<script src="js/ReserveTickets.js"></script>
<script src="js/CurrentDate.js"></script>
</html>