<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="css/styles.css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat|Open+Sans" rel="stylesheet">
    <script type='text/javascript' src="js/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="js/checkout.js"></script>

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

    
    
    
  <figure>
    <div class="ticketsRes">
        <div id="text"><h1>BE PART OF OUR EVENT</h1>
        </div>
     
 <br><br>
<div id="TicketOne"><img src="images/Ticket1.jpg" alt="onedayticket" id="TicketImage" />
  <button id="GetTicket" onclick="ShowIt()">get a ticket</button>
</div>


 <div id="TicketOne"><img src="images/Ticket2.jpg" alt="twodaysticket" id="TicketImage" />
  <button id="GetTicket" onclick="ShowIt()">get a ticket</button>     
</div>
        

 <div id="TicketOne"><img src="images/Ticket3.jpg" alt="fullpackage" id="TicketImage" />
   <button id="GetTicket"  onclick="ShowIt()">get a ticket</button>    
</div>
                   <div class="reserveTickets">
          					<div class="reserveForm">
											
                                 <div class="form-group">
										<input class="form-control" type="date" id="dateSelection" required>
										<span class="form-label">Date</span>
									</div>
                              
								
                                    <div class="form-group">
										<input class="form-control" type="date" id="dateSelection" required>
										<span class="form-label">Second Date</span>
									</div>
							
						
									<div class="form-group">
										<select class="form-control" required>
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
                                   </div>   
             		
                          </div> 
       
           </div>
    <input type="button" name="next" class="nextMain" value="Next" />
  </figure>
    
    <figure id="messageBox">
       
        <h1>Would you like a camping spot?</h1>
        <button type="button" id="BtnQuest" class="nextMain" onclick="Agree()">YES</button>
        <button onclick="Disagree()" id="BtnQuest" type="button" class="nextMain">NO</button>

    </figure>
    
    
  <figure>
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
    <input type="button" name="previous" class="previousMain" value="Previous" />
    <input type="button" name="next" class="nextMain" value="Next" />
  </figure>
    
    
    
    
  <figure>
    <div id="TicketRe">
        <div class="formRe">
            
            <H1>CART</H1>
            
            
            
            
            
            
            </div>
        </div> 
     <input type="button" name="previous" class="previousMain" value="Previous" />
    <input type="button" name="next" class="nextMain" value="Next" />
  </figure>
    
    
    
      <figure>
    <div id="TicketRe">
        <div class="formRe">
       <div id="Account">    
<form id="AccountForm">

	<ul id="progressAcc">
		<li class="active"></li>
		<li></li>
		<li></li>
<li></li>
<li></li>
<li></li>
	</ul>
	<fieldset id="FormAcc">
		<h2 class="fs-title">Create an account</h2>
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
    <fieldset id="FromPanel">
	<fieldset id="FormAcc">
		<h2 class="fs-title">Person 2</h2>
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
		<h2 class="fs-title">Person 3</h2>
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
		<h2 class="fs-title">Person 4</h2>
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
		<h2 class="fs-title">Person 5</h2>
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
		<h2 class="fs-title">Person 6</h2>
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
        </fieldset>
	</form>
            </div>
            </div>
        </div>
               <input type="button" name="previous" class="previousMain" value="Previous" />
              <input type="button" name="next" class="nextMain" value="Next" />
        
 </figure>

 <figure>
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
                    <button>Place Order</button>
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
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js" type="text/javascript"></script>
    <script src="js/PanelsSwitch.js"></script>
    <script src="js/RegisterPeople.js"></script>
    <script src="js/ReserveTickets.js"></script>    
</html>