<?php
error_reporting(E_ERROR);
session_start();
if(!isset($_SESSION['username'])) header('Location: login.php');
include '../Control/PHP/control.php';
$userdata = getProfile();
$firstname=$userdata['firstname'];
$lastname=$userdata['lastname'];
$username=$userdata['username'];
$email=$userdata['email'];  
$password=$userdata['password'];
$dob=$userdata['dateofbirth'];
$address=$userdata['address'];
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons+Round">
    <link rel="stylesheet" href="CSS/style.css">
    
    <title>Practice CSS</title>
</head>
<body>
    <div class="edit-profile">
        <div class="edit-profile-upper-box">
            <span class="material-icons-round" id="edit-button">edit</span>
            <div class="profile-picture"><img src="https://img.icons8.com/ios/50/000000/name--v1.png"/></div>
            <div class="profile-short-info">
                <span class="profile-short-info-name"><?php echo $firstname." ".$lastname?></span>
                <span class="profile-short-info-username"><?php echo $username?></span>
                <button id="update-profile-picture">
                    <span class="material-icons-round">photo_camera</span>
                    <span class="change-photo-button-text">Change Photo</span>
                </button>
            </div>
        </div>
        <form action="../Control/PHP/control.php" method="POST">
            <div class="edit-profile-name-box">
                <span>
                    <label>First Name:</label>
                    <input type="text" name="fname" class ="textinput" placeholder="first name..." value='<?php echo $firstname?>'>
                    <span class="formerror" id="firstnameerror"></span>

                </span>
                <span>
                    <label>Last Name:</label>
                    <input type="text" name="lname" class ="textinput" placeholder="last name..." value='<?php echo $lastname?>'>
                    <span class="formerror" id="lastnameerror"></span>
                </span>
            </div>

            <label>Username:</label>
            <input type="text" name="uname" class ="textinput" placeholder="username..."  value='<?php echo $username?>'>
            <span class="formerror" id="usernameerror"></span>

            <label>Password:</label>
            <input type="password" name="password" class ="textinput" placeholder="password..." value='<?php echo $password?>'>
            <span class="formerror" id="passworderror"></span>
            
            <label>Email:</label>
            <input type="email" name="email" class="textinput" placeholder="email..."  value='<?php echo $email?>'>
            <span class="formerror" id="emailerror"></span>

            <label>Date of Birth</label>
            <input type="date" name="dateofbirth" class="textinput"  value='<?php echo $dob?>'>
            <span class="formerror" id="dateofbirtherror"></span>
            
            <label>Address:</label>
            <input type="text" name="address" class="textinput" placeholder="address..."  value='<?php echo $address?>'>
            <span class="formerror" id="addresserror"></span>
            
            <input type="button" value="Submit" class="submit-button" id="edit-profile-submit-button">
            <input type="submit" name='submitProfile' id="profile-edit-submit-hidden" class="submit-button">
        </form>
    </div>

    <script src="../Control/JS/jquery-3.6.0.min.js"></script>
    <script src="../Control/JS/script.js"></script>
    <script src="../Control/JS/ajax.js"></script>

</body>
</html>