<?php
session_start();
if (empty($_SESSION['loggedIn'])) {
    header("Location: ./Home.php");
}
?>


<!DOCTYPE html>
<html>
<head>

    <link rel="stylesheet" href="css/stylesProfile.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat|Open+Sans" rel="stylesheet">

    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>


    <title>PROFILE</title>

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
                    <li><a id="n1" href="Home.php">About</a></li>
                    <li><a id="n2" href="Home.php#2">Countries</a></li>
                    <li><a id="n3" href="Home.php#3">Location</a></li>
                    <li><a id="n4" href="Home.php#4">Program</a></li>
                    <li><a href="Tickets.php">Tickets</a></li>
                    <li class="dropdown">
                        <a href="#logIn" class="dropdown-toggle" data-toggle="dropdown"
                           style="color:#6e9987;">Account<span class="caret"></span></a>
                        <ul id="loginM" class="dropdown-menu">

                            <?php if (!isset($_SESSION['loggedIn']) || $_SESSION['loggedIn'] !== true): ?>

                                <li>
                                    <div class="row">
                                        <div class="col-md-12">
                                            <form name="loginCustomer"
                                                  action="backend/components/account/login_validation.php"
                                                  method="post">
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
                                            <form name="logoutCustomer" action="backend/components/account/logout.php"
                                                  method="post">
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
<br><br>
<div class="profile">
    <div class="containerProfile">
        <div class="left-content">
            <img src="images/profile.png" style="display: flex;">
        </div>
        <div class="right-content">
            <span class="greeting">Hello</span>
            <h3 class="my-name">
                <span>Display the name of the person</span>
            </h3>
            <br>
            <div class="detail-infor">
                <div class="labels">
                    <p>NAME:</p>
                    <br>
                    <p>MY TICKETS:</p>
                    <br>
                    <p>CAMPINGSITE:</p>
                    <br>
                    <p>BALANCE:</p>
                </div>
                <div class="infor">
                    <p>Nadya Cheperkova</p>
                    <br>
                    <p>Ticket Type One</p>
                    <br>
                    <p>Spot 8</p>
                    <br>
                    <p>€1234</p>
                </div>
            </div>
        </div>
        <br>
        <div class="bottom-content">

            <a class="button" href="#popup1">Deposit money</a>
        </div>

        <form id="makeDepositForm" name="makeDeposit" action="">
            <div id="popup1" class="overlay">
                <div class="popup">
                    <h3>Fill the amount of money that you want to deposit</h3>
                    <a class="close" href="#">&times;</a>
                    <div class="content">
                        &euro;&nbsp;<input name="money"/>
                        <p><br></p>
                        <p>
                            <input type="submit" name="submit" id="makeDeposit" value="Make your deposit" />
                        </p>
                        <p><br></p>
                    </div>
                </div>
        </form>


    </div>
</div>


<footer id="footerButtom">
    <div>&copy;CULTURAL FESTIVAL 2018. All rights reserved. Made by DevelopPro.</div>
</footer>
</body>

<script src="https://code.jquery.com/jquery-3.3.1.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<script src="js/home.js"></script>
<script src="js/depositMoney.js"></script>
</html>