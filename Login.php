<?php
	require 'test.php';
function test_input($data)
{
	$data=trim($data);
	$data=stripslashes($data);
	$data=htmlspecialchars($data);
	return $data;
}
?>
<!DOCKTYPE HTML>
<html>
<head>
<title>LognIn</title>
<meta name="viewport" content="width=device-width, initial-scale=1" >
<meta charset="utf-8">
<link rel="stylesheet" href="http://localhost:8088/test_project/Projects/login.css" >
</head>
<body>
<?php
$name=$name_err="";
$act=htmlspecialchars($_SERVER["PHP_SELF"]);
if($_SERVER["REQUEST_METHOD"]=="POST")
{
	
	if(empty($_POST["name"])){
		$name_err="Name is required";
		echo "<script>alert('Please Fill Name');</script>";
	}
	else
	{
		$name=test_input($_REQUEST["name"]);
		$act="http://localhost:8088/test_project/Projects/project.php";
	}
}
$query="select * from users";
$re=$sql->query($query);
echo $_SERVER["REQUEST_METHOD"];
?>
<div class="content">
<div class="circle" ></div>
<form method="post" action="
<?php 
if(!empty($_POST["name"]))
	while($row=mysqli_fetch_assoc($re))
		{
			if($row["Name"]==$name)
			{
				echo $act;
				break;
			}
		}
			echo $_SERVER['PHP_SELF'];
?>" >
<fieldset>
<legend>LognIn</legend>
<div><legend for="name" >NAME</legend><input onclick="a()" id="name-in" type="text" value="<?php echo $name;?>" name="name" ><br></div>
<?php if(!empty($name_err)) echo "<span id=\"err\" >$name_err</span><br>"; ?>
<div><legend for="LastName" >LAST NAME:</legend><input type="text" name="LastName" ><br></div>
<div><legend>EMAIL:</legend><input  type="text" name="email" ><br></div>
<div><input type="checkbox" >Send me all news <br>
<div><input required type="checkbox" >I Accept all <a href="#">laws</a> <br></div>
<div><input type="submit" name="sub" id="SUBMIT" value="Logn In >" ></div>
</fieldset>
</form>
<div class="circle2" ></div>
<script>
function a()
{
	document.getElementById("err").style.display="none";
	document.getElementById("name-in").style.border="solid 2px rgba(200,10,10,0.7)";
}
</script>
<?php
function test($errno,$errstr)
{

	echo "Error:[$errno] $errstr";
}

set_error_handler("test");
echo $t;
?>
</body>
</html>