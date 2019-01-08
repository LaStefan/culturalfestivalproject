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
      <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
        <span class="sr-only"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      <a class="navbar-brand" href="#"><a class="navbar-brand"> <img src="images/logo.jpg" alt="logo" width="120"/></a></a>
    </div>
    <div id="navbar" href="#0" class="collapse navbar-collapse">
      <ul class="nav navbar-nav navbar-right">
        <li><a id="n1"href="Home.html">About</a></li>
        <li><a id="n2" href="Home.html#2">Countries</a></li>  
        <li><a id="n3"href="Home.html#3">Location</a></li>
        <li><a id="n4" href="Home.html#4">Program</a></li> 
        <li><a href="#tickets">Tickets</a></li>
        <li class="dropdown">
          <a href="#logIn" class="dropdown-toggle" data-toggle="dropdown" style="color:#6e9987;">Log Out<span class="caret"></span></a>
			<ul id="loginM" class="dropdown-menu">
				<li>
					 <div class="row">
							<div class="col-md-12">
							 <form class="form">
										 <button class="buttonLI">Log Out</button>
									
                                </form>
                         </div>
                    </div>
				</li>
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

<div id="popup1" class="overlay">
	<div class="popup">
		<h3>Fill the amount of money that you want to deposit</h3>
		<a class="close" href="#">&times;</a>
		<div class="content">
<input name="money"/>	
            <p><br></p>
<p><button id="makeDeposit">Make your deposit</button></p>
            <p><br></p>
        </div>
	</div>

        </div>
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