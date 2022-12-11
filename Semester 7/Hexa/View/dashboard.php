<?php
session_start();
if (isset($_SERVER['HTTP_ORIGIN'])) {
    // Decide if the origin in $_SERVER['HTTP_ORIGIN'] is one
    // you want to allow, and if so:
    header("Access-Control-Allow-Origin: {$_SERVER['HTTP_ORIGIN']}");
    header('Access-Control-Allow-Credentials: true');
    header('Access-Control-Max-Age: 86400');    // cache for 1 day
}
    
    if(!isset($_SESSION['username']))
        header('Location: login.php');

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons+Round">
    <link rel="stylesheet" href="CSS/style.css">
    
    <title>Dashboard</title>
</head>
<body>
    <script type="text/javascript" src="../Control/JS/jquery-3.6.0.min.js"></script>
    <div class="dashboard-sidebar">
        <div class="logo"></div>
        <ul class="dashboard-sidebar-item-list">
            <li id="store-management">
                <a href="dashboard.php?page=trendinggamemanagement.html" class="dashboard-sidebar-items">
                    <i class="material-icons-round">store</i>
                    <span class="hide">Store Management</span>
                </a>
                <i class="material-icons-round" onclick="toggleDropdown('store-home-management-dropdown')">arrow_drop_down</i>
                
            </li>
            <ul class="dashboard-sidebar-items-submenu" id='store-home-management-dropdown'>
                <a href='dashboard.php?page=showcasemanagement.html'>Showcase</a>
                <a href='dashboard.php?page=trendinggamemanagement.html'>Trending Games</a>
                <a href='dashboard.php?page=trendingnewsmanagement.html'>Trending News</a>
            </ul>
            <li>
                <a href="dashboard.php?page=customerManagement.html" class="dashboard-sidebar-items">
                    <i class="material-icons-round">switch_account</i>
                    <span class="hide">User Management</span>
                </a>
                <i class="material-icons-round" onclick="toggleDropdown('user-management-dropdown')">arrow_drop_down</i>
            </li>
            <ul class="dashboard-sidebar-items-submenu" id="user-management-dropdown">
                <a href='dashboard.php?page=customerManagement.html'>Customer</a>
                <a href='dashboard.php?page=developerManagement.html'>Developer</a>
                <a href='dashboard.php?page=employeeManagement.html'>Employee</a>
            </ul>
            <li>
                <a href="dashboard.php?page=newsManagement.html" class="dashboard-sidebar-items">
                    <i class="material-icons-round">newspaper</i>
                    <span class="hide">News Management</span>
                </a>
                <ul class="dashboard-sidebar-items-submenu">
        
                </ul>
            </li>
            <li>
                <a href="dashboard.php?page=gameManagement.html" class="dashboard-sidebar-items">
                    <i class="material-icons-round">sports_esports</i>
                    <span class="hide">Game Management</span>
                </a>
                <ul class="dashboard-sidebar-items-submenu">
        
                </ul>
            </li>
            <li>
                <a href="dashboard.php?page=saleManagement.html" class="dashboard-sidebar-items">
                    <i class="material-icons-round">price_change</i>
                    <span class="hide" id='sale-management-dashboard-button'>Sale Management</span>
                </a>
                <ul class="dashboard-sidebar-items-submenu">
        
                </ul>
            </li>
            <li>
                <a href="dashboard.php?page=profile.php" class="dashboard-sidebar-items">
                    <i class="material-icons-round">badge</i>
                    <span class="hide">Profile</span>
                </a>
                <ul class="dashboard-sidebar-items-submenu">
        
                </ul>
            </li>
            <li>
                <a href="../Control/PHP/control.php?do=logout" class="dashboard-sidebar-items">
                    <i class="material-icons-round">logout</i>
                    <span class="hide">Log Out</span>
                </a>
                <ul class="dashboard-sidebar-items-submenu">
        
                </ul>
            </li>
        </ul>
    </div>
    <div id="dashboard-body">
        <?php 
            if(isset($_GET['page']))
                include $_GET['page'];
            else include 'showcasemanagement.html';
        ?>
    </div>
    <script type="text/javascript" src="../Control/JS/jquery-3.6.0.min.js"></script>
    <script src="../Control/JS/script.js"></script>
</body>
</html>