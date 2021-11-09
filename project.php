<!doctype html>
<?php
	require 'test.php';
	$query="select * from users";
	$re=$sql->query($query);
?>
<html>
<head>
<meta charset="utf-8">
<title>project</title>
</head>
<body>
<div class="table">
<table>
<colgroup align="center" span="1">
<col  span="1" style="background-color: ">
<col  align="center" width="100px" span="1" style=" background-color:white" >
</colgroup>
<caption>
Description
</caption>
<tr>
<td><img id="profile" src="E:\folder2\edited\test.jpg" /></td>
</tr>
<tr>
<td>Name:</td>
<td>
<?php 
echo $_POST["name"];
?>
</td>
</tr>
<tr>
<td>LastName:</td>
<td>
<?php
echo $_POST['LastName'];
?>
</td>
</tr>
<tr>
<td>
UserEmail:
</td>
<td>
<?php
echo $_POST["email"];
?>
</td>
</tr>
<tr>
<td>Comment:</td>
<td>
<?php

?>
</td>
</tr>
</table>
</div>
<div class="database">
<table class="table2" cellpadding="40" align="center" >
<caption Align="center" >students</caption>
<tr>
<th></th>
<th>Name</th>
<th>Last Name</th>
<th>Email</th>
<th>Grade</th>
</tr>
<?php   
$i=1;
while( $row=mysqli_fetch_array($re))
{
	echo "<tr>";
	print "<td>".$i++."</td>";
	print "<td>".$row['Name']."</td>"; 
	print "<td>".$row['Last_name']."</td>"; 
	print "<td>".$row['email']."</td>"; 
	print "<td>".$row['grade']."</td>"; 
	echo "</tr>";
}
?>
</table>
</div>
</body>
</html>
<style>
th{
	background-color:hsl(10,70%,70%);
}
th,tr,.table2,.table2 td{
	border:solid 2px rgba(40,120,140);
	border-collapse:collapse;
}

div.contain{
	background-color:lightblue;
	height:100%;
	margin-left:auto;
	margin-right:auto;
}
div.table{
	width:400px;
	height:400px;
	border:solid 2px black;
	background-color:rgba(40,180,170,0.5);
}

#profile{
	width:120px;
	height:140px;
	position:relative;
	left:10%;
	top:10px;
	border-top-left-radius:20px;
	border-bottom-right-radius:20px;
	border:solid 3px white;
	
}
td{
	text-align:center;
	line-height:3;
}
div.database
{
	background-color:lightblue;
	height:50%;
}
</style>