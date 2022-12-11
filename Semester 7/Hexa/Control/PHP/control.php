<?php
    error_reporting(E_ERROR);
    session_start();
    include '../Model/model.php';
    include '../../Model/model.php';
    if(isset($_FILES["showcaseimage"]))
    {
        if(file_exists('../../Files/img/showcase.jpg'))
        unlink('../../Files/img/showcase.jpg');
        move_uploaded_file($_FILES["showcaseimage"]["tmp_name"], '../../Files/img/showcase.jpg');
        header("Location: ../../view/dashboard.php?page=showcasemanagement.html");
    }
    if(isset($_POST['submit']))
    {
        $db = new DBClass('localhost' , 'root', '','hexa');
        $username = $_POST['uname'];
        $password = $_POST['password'];
        $sql = 'SELECT * FROM user WHERE username="'.$username.'" AND password="'.$password.'"';
        $result=$db->executeQuery($sql);
        if($result->num_rows > 0){
            $result=$result->fetch_assoc();
            echo 'login successful';
            $_SESSION['username']=$result['username'];
            $_SESSION['usertype']=$result['usertype'];
            if(isset($_POST['remember']))
                setcookie('username', $result['username'], time()+1000, "/");
            header('Location:../../Hexa/View/dashboard.php');
        }
    }
    
    if(isset($_GET['do']) && $_GET['do']=='logout')
    {
        setcookie('username', $_SESSION['username'], time()-1000, "/");
        session_destroy();        
        header('Location:../../View/login.php');
    }

    if(isset($_POST['submitProfile']))
    {
        $fname = $_POST['fname'];
        $lname = $_POST['lname'];
        $uname = $_POST['uname'];
        $password = $_POST['password'];
        $email = $_POST['email'];
        $dob = $_POST['dateofbirth'];
        $address = $_POST['address'];
        $USERNAME = $_SESSION['username'];
        $sql = 'UPDATE user SET firstname="'.$fname.'",lastname="'.$lname.'",username="'.$uname.'",password="'.$password.'",email="'.$email.'",dateofbirth="'.$dob.'",address="'.$address.'"WHERE username="'.$USERNAME.'"';
        //$database = new DBClass('localhost' , 'root', '','hexa');
        if(validateName($fname) && validateName($lname) && validateEmail($email) && validatePassword($password) && !empty($dob) && !empty($address))
            $database->executeNonQuery($sql);
        header('Location: ../../view/dashboard.php?page=profile.php');
    }

    function getProfile()
    {
        $username = $_SESSION['username'];
        $database = new DBClass('localhost' , 'root', '','hexa');
        $sql = "SELECT * FROM user WHERE username='$username'";
        $result=$database->executeQuery($sql);
        if($result->num_rows > 0){
            $result=$result->fetch_assoc();
            return $result;
        }
    }

    function validateName($str){
        if(empty($str)) return false;
        else if(!preg_match("/^([a-zA-Z' ]+)$/",$str)) return false;
        return true;
    }

    function validateEmail($str){
        if(empty($str)) return false;
        else if(!preg_match("^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$^",$str)) return false;
        return true;
    }

    function validatePassword($str){
        if(empty($str)) return false;
        else if(strlen($str)<8)  return false;
        else if(!preg_match('@[A-Z]@',$str) && !preg_match('@[a-z]@',$str) && !preg_match('@[0-9]@',$str)) return false;
        return true;
    }

    function validateNumber($str){
        if(empty($str)) return false;
        else if(!preg_match("/^[0-9]*$/",$str)) return false;
        return true;
    }

    function validateRegion($str){
        if(empty($str)) return false;
        else if(!preg_match("/^([a-zA-Z ]+)$/",$str)) return false;
        return true;
    }
    
?>