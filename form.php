<html>
<?php
require 'test.php';
$name=$_POST['NName'];
$LastName=$_POST['LastName'];
$Email=$_POST['eemail'];
$query="insert into users(Name,Last_name,email) values('$name','$LastName','$Email')";
$query2="delete from users where email is NULL";
$sql->query($query2);   
echo $sql->error;    //mysql_query($query,$sql);
?>
<head>
<title>Create account</title>
<meta charset="utf-8" >
<style>
div.message{
	width:50%;
	height:15%;
	background-color:lightblue;
	display:flex;
	justify-content:center;
	position:relative;
	left:20%;
	box-shadow:5px 5px 10px silver;
	border:outset 3px gray;
	border-top-left-radius:20px;
	border-bottom-right-radius:20px;
}
p{
	color:gray;
	font-size:17pt;
}
</style>
</head>
<body>
<div class="message" >

<p>Welcome <?php  echo "<b>".$_POST['NName']."</b>"; ?><br>Your Account have been Created.</p>

</div>
</body>
