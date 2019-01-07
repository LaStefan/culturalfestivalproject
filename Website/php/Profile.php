<?php
    session_start();
?>
<!DOCTYPE html>
<html>
<head>
    
<link rel="stylesheet" href="css/stylesTickets.css">    
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link href="https://fonts.googleapis.com/css?family=Montserrat|Open+Sans" rel="stylesheet">
<link href="//netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css" rel="stylesheet"> 

  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <title>TICKETS</title> 
    
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
        <li><a href="tickets.php">Tickets</a></li>
        <li class="dropdown">
          <a href="#logIn" class="dropdown-toggle" data-toggle="dropdown" style="color:#6e9987;">Log In<span class="caret"></span></a>
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
    <br><br>
<div class="container">
  <div class="panel-group">
    <div class="panel panel-default">
      <div class="panel-heading">MY ACCOUNT</div>
      <div class="panel-body"> <img src="images/personIcon.png">
        
        
    </div>
      </div>
  <br>
  <div class="row">
    <div class="col-sm-4" style="background-color:bisque;">MY TICKETS</div>
    <div class="col-sm-4" style="background-color:skyblue;">MY CAMPING SITE</div>
    <div class="col-sm-4" style="background-color:pink;">MY BALANCE</div>
  </div>
</div>
</div>

    </body>

<script src="https://code.jquery.com/jquery-3.3.1.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<script src="js/home.js"></script>
</html>