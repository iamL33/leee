<?php 
    
    function connection(){
        $host ="localhost";
        $username ="root";
        $email = "";
        $dbname = "grading-system";

        $con new mysql( $host, $username, $email, $dbname);

        if( $con->connect_error()){
            echo $con->connection_error;
        }else{
            return $con;
        }
    }
?>