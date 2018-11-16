<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="styles.css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat|Open+Sans" rel="stylesheet">
    
    <div id="TopBar">
       <div id="line1">
     <img src="images/line.jpg" alt="line" width="630" height="70">
       </div>
        
       <div id="logo">
        <a href="About.html">           
     <img src="images/logo.jpg" alt="logo" width="200">
        </a>    
       </div>
        
        <div id="line2">
     <img src="images/line2.jpg" alt="line" width="630" height="70">
        </div>
    </div>

    <div id="NavBar">
            <li><a href="About.html">ABOUT</a></li>
            <li><a href="Tickets.html">TICKETS</a></li>
            <li><a href="Account.html">ACCOUNT</a></li>
    </div>
    <title>Tickets</title>
</head>     

<body>
    <section>
    <div id="Ticket">
        
        <div id="text"><h1>BE PART OF OUR EVENT</h1>
        </div>
     <div class="ticketType">
 <figure><img src="images/TwoDaysTicket.jpg" alt="onedayticket" id="TicketImage" />
  <button type="submit" id="GetTicket" onclick="Cancel()">get a ticket</button>   
 </figure>
 </div>
        
 <div class="ticketType">
 <figure><img src="images/OneDayTicket.jpg" alt="twodaysticket" id="TicketImage" />
  <button type="submit" id="GetTicket" onclick="showMessage()">get a ticket</button>     
 </figure>
 </div>
        
 <div class="ticketType">
 <figure><img src="images/FullPackage.jpg" alt="fullpackage" id="TicketImage" />
   <button type="submit" id="GetTicket"  onclick="showMessage()">get a ticket</button>    
</figure>
 </div>
   
   </div>
        
<div class="messageBox">
    <div class="all">
    <h1>Do you want to reserve a camping spot?</h1>
    <div class="choise">
    <button onclick="showUp()">Yes</button>
    <button onclick="Cancel()">No</button>
        </div>
    </div>
</div>
 <div class="popup">
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
        <img src="images/legend.PNG" id="legend"> 
        </div>
     </div>
     <br>
 </div>
</section>

    <footer id="footer">
         
   <p>© CULTURAL FESTIVAL 2018. All rights reserved. Made by DevelopPro.</p>          
          
        </footer>    
    
    </body>
    <script src="sitemap.js"></script>
</html>