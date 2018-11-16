<!DOCTYPE html>
<html>
<head>
    <link href='https://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat|Open+Sans" rel="stylesheet">
    <link rel="stylesheet" href="styles.css">
    
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
    
    <title>Account</title>
    
</head>     

<body>
        <div id="Account">
        <div class="form">
            
            <ul class="tab-group">
        <li class="tab active"><a href="#signup">Sign Up</a></li>
        <li class="tab"><a href="#login">Log In</a></li>
      </ul>
            
            <div class="tab-content">
            <div id="signup">
               
                <form>
                
                <div class="top-row">
            <div class="field-wrap">
              <label>
                First Name<span class="req">*</span>
              </label>
              <input class="fnInput" type="text" required autocomplete="off" />
            </div>
        
            <div class="field-wrap">
              <label>
                Last Name<span class="req">*</span>
              </label>
              <input class="lnInput" type="text"required autocomplete="off"/>
            </div>
          </div>

          <div class="field-wrap">
            <label>
              Email Address<span class="req">*</span>
            </label>
            <input class="emailInput" type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label>
              Set a password<span class="req">*</span>
            </label>
            <input  class="passwordInput" type="password" required autocomplete="off"/>
          </div>
                   
                    <button class="button button-block" onclick="switchPanels()" type="button">Continue to payment method</button>
                             
                
                </form>
                
                </div>
            
                <div id="login">
                
                <form>
                
                <div class="field-wrap">
                   <label>
                  Email <span class="req">*</span>
                  </label> 
                  <input type="email" required autocomplete="off"/>     
                  </div>
                    
                     <div class="field-wrap">
                   <label>
                  Password<span class="req">*</span>
                  </label> 
                  <input type="password" required autocomplete="off"/>     
                  </div>
                    
                    <p class="forget"><a href="#">Forget Password?</a></p>
                    
                    <button class="button button-block">Log In</button>
            
                    </form>
                            
                </div>
            </div>
   
          </div>
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
                        <input type="text" placeholder="Credit Card Number">
                        <input type="text" placeholder="MM/YYYY">
                        <input type="text" placeholder="Card Validation Number">
                    </div>
                </div>
                <div class="proccess">
                    <button>Place Order</button>
                </div>
            
            </div>
            </div>
</div>
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
<script  src="Account_js.js"></script>
    <script src="accountSwitch.js"></script>
    
    <footer id="footer">
        <p>© CULTURAL FESTIVAL 2018. All rights reserved. Made by DevelopPro.</p>  
    </footer>
    
</body>
</html>