<?php
class DBClass{ 
    private $connection;

    function __construct($serverName, $username, $password, $databaseName)
    {
        $this->openConnection($serverName, $username, $password, $databaseName);
    }
    function openConnection($serverName, $username, $password, $databaseName)
    {
        $this->connection = new mysqli($serverName, $username, $password, $databaseName);
        if(!$this->connection->connect_error){
            //echo "Connection successful<br>";
        }
        else 
            echo "Connection Error:".$this->connection->connect_error.'<br>';
    }

    function executeQuery($sql)
    {
        $result = $this->connection->query($sql);
        if($result === FALSE)
            echo $this->connection->error.'<br>';
        else
            return $result;
    }

    function executeNonQuery($sql){
        $result = $this->connection->query($sql);
        if($result === FALSE)
            echo $this->connection->error.'<br>';
    }

    function connectionClose()
    {
        $this->connection->close();
    }
}
?>
