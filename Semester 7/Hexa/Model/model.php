<?php
    include 'DB.php';
    include 'functions.php';

    $database = new DBClass('localhost' , 'root', '','hexa');
    if(isset($_GET['query']))
    {
        $result = $database->executeQuery($_GET['query']);
        $array = array();
        while($row = $result->fetch_assoc()){
            array_push($array,$row);
        }
        echo json_encode($array);
    }
    if(isset($_GET['nonquery']))
    {
        $database->executeNonQuery($_GET['nonquery']);
    }
    
    
        
?>
