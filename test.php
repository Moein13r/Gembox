<html>
<head>

</head>
<body>
<?php 
$server="localhost";
$Name="root";
$password="";
$sql=new mysqli($server,$Name,$password,"test");
if($sql->connect_error)
	die ("connection failed".$sql->connect_error);
?>
</body>

</html>