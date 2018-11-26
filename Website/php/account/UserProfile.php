<?php

    require(__DIR__ . '/../backend/components/orders/order_helper.php');

    $orders = getOrdersForCustomer($_SESSION['customerId']);

?>


<div class="form">

    <ul class="tab-group">
        <li class="tab active"><a href="#profile">Profile</a></li>
        <li class="tab"><a href="#orders">Orders</a></li>
        <li class="tab"><a href="#logout">Logout</a></li>
    </ul>

    <div class="tab-content">



        <div id="profile">

            <h2>Profile:</h2>

            <p>This is the user profile page, here we want to show personal information about the user.</p>

        </div>

        <div id="orders">

            <h2>Orders</h2>

            <p>This page will show all orders the customer made</p>

        </div>



        <div id="logout">

            <form action="backend/components/account/logout.php" method="post">

                <input type="submit" name="submit" value="Logout" />

            </form>

        </div>
    </div>
</div>