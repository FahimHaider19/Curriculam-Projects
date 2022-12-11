<?php 
include '../Control/PHP/control.php'; 
//error_reporting(E_ERROR);
session_start();
if(isset($_COOKIE['username']))
{
    $_SESSION['username']=$_COOKIE['username'];
    header('Location: dashboard.php');
}
else if(isset($_SESSION['username']) && $_SESSION['usertype']=='Admin')
{
    header('Location: dashboard.php');
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="CSS/style.css">
    <title>Login</title>
</head>
<body id="loginbody">
    <form id="login-box" method="post" action="">
        <label for="login" id="loginlabel">Sign In</label>
        <label>Username:</label>
        <input type="text" name="uname" class="textinput" placeholder="username...">
        <span class="formerror" id="usernameerror"></span>
        
        <label>Password:</label>
        <input type="password" name="password" class="textinput" placeholder="password...">
        <span class="formerror" id="passworderror"></span>
        <input type="checkbox" name="remember"><label>Remember me</label>
        <button class="button" id="login-button" name='submit'>Sign In</button>
    </form>
</body>
</html>