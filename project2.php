<!doctype html>

<html>
<head>
<meta charset="utf-8" >
<link rel="stylesheet" type="text/css" href="proj2.css" >
<title>Wonder</title>
</head>
<body>
<center><p><span>Beynod </span><span class="text" >E</span><span>xpectition<span></p></center>
<div id="content" class="footer">
<div class="layer">
<form method="post" action="
<?php
$name_err="";
if($_SERVER["REQUEST_METHOD"]=="POST")
{
if(!preg_match("/^[a-zA-Z ]*$/",$_REQUEST["NName"]))
{
	$name_err="error name";
	echo $_SERVER["PHP_SELF"];
}
else
{	
echo "http://localhost:8088/test_project/Projects/form.php";
}
}
?>
" > 
<fieldset>
<legend>LogIn</legend>
<table>
<tr>
<td>NAME:<input type="text" name="NName" required="required" ></td>
</tr>
<td>LAST NAME:<input type="text" name="LastName" required="required" ></td>
<tr>
<td>Email:<input type="text" name="eemail" required="required" ></td>
</tr>
<tr>
<td><textarea name="Comment" rows="5" cols="40" placeholder="write your opinions">
</textarea></td>
</tr>
<tr>
<td><input Id="target" value="Submit" type="submit" name="submit"></td>
</tr>
</table>
<br>
</fieldset>
</form>
</div>
<h1>
<?php
echo $_SERVER["REQUEST_METHOD"]."<br>";
echo $name_err;
?>
</h1>
</div>
<div class="test2" id="test">
</div>
</body>
</html>