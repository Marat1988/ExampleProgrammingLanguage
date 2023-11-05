
<?php
	$mysqli = new mysqli('localhost','root','12345','kinomoster');
	if (mysqli_connect_errno()){
		prinf("Соединение не установлено", mysqli_connect_error());
		exit();
	}
	$mysqli->set_charset('utf8');
	/*$query = $mysqli->query('SELECT * FROM movie');

	while($row=mysqli_fetch_assoc($query)) {
		echo $row['name'].$row['year']."<br>";
	}
	$mysqli->close();*/

	/*$query = "INSERT INTO movie VALUES (null, 'безумный макс', 'Описание фильма безумный макс', 2015, Now())";
	$mysqli->query($query);*/


	/*$query = "UPDATE movie SET year = 1990 WHERE id = 7";
	$mysqli->query($query);*/

	$query = "DELETE FROM movie WHERE id = 7";
	$mysqli->query($query);


?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>DB</title>
</head>
<body>

</body>
</html>