<?php
session_start();
?>

<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="css/styles.css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat|Open+Sans" rel="stylesheet">
    <script type='text/javascript' src="js/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="js/checkout.js"></script>
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600" rel="stylesheet">

    <div id="TopBar">
        <div id="line1">
            <img src="images/line.jpg" alt="line" width="630" height="70">
        </div>

        <div id="logo">
            <a href="About.php">
                <img src="images/logo.jpg" alt="logo" width="200">
            </a>
        </div>

        <div id="line2">
            <img src="images/line2.jpg" alt="line" width="630" height="70">
        </div>
    </div>

    <div id="NavBar">
        <li><a href="About.php">ABOUT</a></li>
        <li><a href="Tickets.php">TICKETS</a></li>
        <li><a href="Account.php">ACCOUNT</a></li>
    </div>
    <title>Tickets</title>
</head>

<body>
<section>
    <form id="MainForm">
        <ul id="progress">
            <li class="active">Select Ticket</li>
            <li>Do you want a camping spot?</li>
            <li>Select Camping Spot</li>
            <li>Your Tickets</li>
            <li>Personal Details</li>
            <li>Payment</li>
        </ul>

        <!-- Panel 1 -->
        <figure>
            <input type="button" name="next" class="nextMain" id="nextOne" value="Next"/>
            <div class="ticketsRes">
                <div class="headingText"><h1>BE PART OF OUR EVENT</h1>
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
                            <input class="form-control pick-date-one" type="date" id="dateOne" required>
                            <span class="form-label">Date</span>
                        </div>
                        <div class="form-group pick-date-two">
                            <input class="form-control" type="date" id="dateTwo" required>
                            <span class="form-label">Second Date</span>
                        </div>
                        <div class="form-group">
                            <select class="form-control ticket-quantity" required>
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

            </div>
        </figure>

        <!-- Panel 2 -->
        <figure id="messageBox">
            <h1>Would you like a camping spot?</h1>
            <button type="button" id="BtnQuest" class="nextMain" onclick="Agree()">YES</button>
            <button onclick="Disagree()" id="BtnQuest" type="button" class="nextMain">NO</button>
        </figure>

        <!-- Panel 3 -->
        <figure>
            <input type="button" name="previous" class="previousMain" value="Previous"/>
            <input type="button" name="next" class="nextMain" id="nextThree" value="Next"/>
            <div class="campingSite">
                <div id="TicketRe">
                    <div class="formRe">
                        <div class="map">
                            <div class="left">
                                <button>1</button>
                                <button>5</button>
                                <button>9</button>
                                <button>2</button>
                                <button>6</button>
                                <button>10</button>
                                <button>3</button>
                                <button>7</button>
                                <button>11</button>
                            </div>
                            <div class="right">
                                <button>12</button>
                                <button>8</button>
                                <button>4</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </figure>

        <!-- Panel 4 -->
        <figure>



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
                    <div class="paypal__subheader">
                        <h1 class="paypal__username">Hello</h1>
                        <span class="paypal__help-text">You've purchased three (3) tickets for Cultural Festival 2019</span>
                    </div>
                </div>

                <div class="paypal__cart">
                    <h2 class="paypal__cart-title">Your tickets</h2>

                    <ul class="paypal__cart-list">
                        <li class="paypal__cart-item">
                            <span class="paypal__index">1</span>
                            <span class="paypal__item-name">One Day Ticket</span>
                            <span class="paypal__item-price">€59.00</span>
                        </li>

                        <li class="paypal__cart-item">
                            <span class="paypal__index">2</span>
                            <span class="paypal__item-name">One Day Ticket</span>
                            <span class="paypal__item-price">€59.00</span>
                        </li>

                        <li class="paypal__cart-item">
                            <span class="paypal__index">3</span>
                            <span class="paypal__item-name">One Day Ticket</span>
                            <span class="paypal__item-price">€59.00</span>
                        </li>

                        <li class="paypal__cart-item">
                            <span class="paypal__cart-total">Total</span>
                            <span class="paypal__item-price">€177.00</span>
                        </li>
                    </ul>
                </div>

                <div class="paypal__footer">
                    <img src="images/barcode.png" alt="Barcode" class="paypal__barcode">
                </div>
            </div>

            <input type="button" name="previous" class="previousMain" value="Previous"/>
            <input type="button" name="next" class="nextMain" id="nextFour" value="Next"/>
        </figure>

        <!-- Panel 5 -->
        <figure>
            <input type="button" name="previous" class="previousMain" value="Previous"/>
            <input type="button" name="next" class="nextMain" id="nextFive" value="Next"/>
    
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
	<fieldset id="FormAcc">
		<h2 class="accTitle">Create an account</h2>
		<div class="top-row">
            <div class="field-wrap">
              <label id="Accountlabel">
                First Name<span class="req">*</span>
              </label>
              <input class="Accountinput" type="text" required autocomplete="off" />
            </div>
        
            <div class="field-wrap">
              <label id="Accountlabel">
                Last Name<span class="req">*</span>
              </label>
              <input class="Accountinput" type="text"required autocomplete="off"/>
            </div>
          </div>

          <div class="field-wrap">
            <label id="Accountlabel">
              Email Address<span class="req">*</span>
            </label>
            <input class="Accountinput" type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label id="Accountlabel">
              Set a password<span class="req">*</span>
            </label>
            <input  class="Accountinput" type="password" required autocomplete="off"/>
          </div>
		<input type="button" id="nextBt" name="next" class="next action-button" value="Register next person" />
	</fieldset>
	<fieldset id="FormAcc">
		<h2 class="accTitle">Person 2</h2>
		<div class="top-row">
            <div class="field-wrap">
              <label id="Accountlabel">
                First Name<span class="req">*</span>
              </label>
              <input class="Accountinput" type="text" required autocomplete="off" />
            </div>
        
            <div class="field-wrap">
              <label id="Accountlabel">
                Last Name<span class="req">*</span>
              </label>
              <input class="Accountinput" type="text"required autocomplete="off"/>
            </div>
          </div>

          <div class="field-wrap">
            <label id="Accountlabel">
              Email Address<span class="req">*</span>
            </label>
            <input class="Accountinput" type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label id="Accountlabel">
              Set a password<span class="req">*</span>
            </label>
            <input  class="Accountinput" type="password" required autocomplete="off"/>
          </div>
		<input type="button" id="nextBt" name="next" class="next action-button" value="Register next person" />
		<input type="button" id="previousBt" name="previous" class="previous action-button" value="Previous" />
	</fieldset>
	<fieldset id="FormAcc">
		<h2 class="accTitle">Person 3</h2>
		<div class="top-row">
            <div class="field-wrap">
              <label id="Accountlabel">
                First Name<span class="req">*</span>
              </label>
              <input class="Accountinput" type="text" required autocomplete="off" />
            </div>
        
            <div class="field-wrap">
              <label id="Accountlabel">
                Last Name<span class="req">*</span>
              </label>
              <input class="Accountinput" type="text"required autocomplete="off"/>
            </div>
          </div>

          <div class="field-wrap">
            <label id="Accountlabel">
              Email Address<span class="req">*</span>
            </label>
            <input class="Accountinput" type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label id="Accountlabel">
              Set a password<span class="req">*</span>
            </label>
            <input  class="Accountinput" type="password" required autocomplete="off"/>
          </div>
		<input type="button" id="nextBt" name="next" class="next action-button" value="Register next person" />
		<input type="button" id="previousBt" name="previous" class="previous action-button" value="Previous" />
	</fieldset>
	<fieldset id="FormAcc">
		<h2 class="accTitle">Person 4</h2>
		<div class="top-row">
            <div class="field-wrap">
              <label id="Accountlabel">
                First Name<span class="req">*</span>
              </label>
              <input class="Accountinput" type="text" required autocomplete="off" />
            </div>
        
            <div class="field-wrap">
              <label id="Accountlabel">
                Last Name<span class="req">*</span>
              </label>
              <input class="Accountinput" type="text"required autocomplete="off"/>
            </div>
          </div>

          <div class="field-wrap">
            <label id="Accountlabel">
              Email Address<span class="req">*</span>
            </label>
            <input class="Accountinput" type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label id="Accountlabel">
              Set a password<span class="req">*</span>
            </label>
            <input  class="Accountinput" type="password" required autocomplete="off"/>
          </div>
		<input type="button" id="nextBt" name="next" class="next action-button" value="Register next person" />
		<input type="button" id="previousBt" name="previous" class="previous action-button" value="Previous" />
</fieldset>
	<fieldset id="FormAcc">
		<h2 class="accTitle">Person 5</h2>
		<div class="top-row">
            <div class="field-wrap">
              <label id="Accountlabel">
                First Name<span class="req">*</span>
              </label>
              <input class="Accountinput" type="text" required autocomplete="off" />
            </div>
        
            <div class="field-wrap">
              <label id="Accountlabel">
                Last Name<span class="req">*</span>
              </label>
              <input class="Accountinput" type="text"required autocomplete="off"/>
            </div>
          </div>

          <div class="field-wrap">
            <label id="Accountlabel">
              Email Address<span class="req">*</span>
            </label>
            <input class="Accountinput" type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label id="Accountlabel">
              Set a password<span class="req">*</span>
            </label>
            <input  class="Accountinput" type="password" required autocomplete="off"/>
          </div>
		<input type="button" id="nextBt" name="next" class="next action-button" value="Register next person" />
		<input type="button" id="previousBt" name="previous" class="previous action-button" value="Previous" />
	</fieldset>
	<fieldset id="FormAcc">
		<h2 class="accTitle">Person 6</h2>
		<div class="top-row">
            <div class="field-wrap">
              <label id="Accountlabel">
                First Name<span class="req">*</span>
              </label>
              <input class="Accountinput" type="text" required autocomplete="off" />
            </div>
        
            <div class="field-wrap">
              <label id="Accountlabel">
                Last Name<span class="req">*</span>
              </label>
              <input class="Accountinput" type="text"required autocomplete="off"/>
            </div>
          </div>

          <div class="field-wrap">
            <label id="Accountlabel">
              Email Address<span class="req">*</span>
            </label>
            <input class="Accountinput" type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label id="Accountlabel">
              Set a password<span class="req">*</span>
            </label>
            <input  class="Accountinput" type="password" required autocomplete="off"/>
          </div>
		<input type="button" id="nextBt" name="next" value="Register next person" />
		<input type="button" id="previousBt" name="previous" class="previous action-button" value="Previous" />
	</fieldset>
	</div>   
        </div>
     </div>
        </figure>

        <!-- Panel 6 -->
        <figure>
            <input type="button" name="previous" class="previousMain" value="Previous"/>
            <input type="button" name="next" class="nextMain" id="nextSix" value="Pay and register"/>
            <div id="TicketRe">
                <div class="formRe">
                    <div class="paymentMain">
                        <div class="payment">
                            <div class="header">
                                <h1>
                                    PAYMENT METHOD
                                </h1>
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


    </form>
</section>
<footer id="footer">

    <p>© CULTURAL FESTIVAL 2018. All rights reserved. Made by DevelopPro.</p>

</footer>

</body>
<script src="js/sitemap.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/1.9.1/jquery.min.js" type="text/javascript"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"
        type="text/javascript"></script>
<script src="js/PanelsSwitch.js"></script>
<script src="js/RegisterPeople.js"></script>
<script src="js/ReserveTickets.js"></script>
<script src="js/CurrentDate.js"></script>
</html>