
<?php
	// $nickname = "John";

	define("DBNAME", "kinomoster");

	$balance = 0;
	// $addBalance1 = 10;
	// $addBalance2 = 35;

	// $balance = $addBalance1 + $addBalance2;

	// $svetofor = "green";

/*	if ($svetofor== "green")
	{
		echo "Светофор зеленый, я перехожу дорогу";
	} else if ($svetofor == "yellow") {
		echo "Сейчас светофор желтый";
	} else {
		echo "Жду, когда загориться зеленый";
	}*/

	// switch ($svetofor) {
	// 	case 'green':
	// 		echo "Светофор зеленый, я перехожу дорогу";
	// 		break;
	// 	case 'yellow':
	// 		echo "Сейчас светофор желтый";
	// 		break;
	// 	case 'red':
	// 		echo "Жду, когда загориться зеленый";
	// 		break;
	// 	default:
	// 		echo "Светофор не работает";
	// 		break;
	// }

	$i = 12;
	// while ($i <= 10) {
	// 	echo $i."<br>";
	// 	$i++;
	// }

	do {
		echo $i."<br>";
		$i++;
	} while ($i <= 10);

	for ($i = 0; $i <= 10 ; $i++) { 
		echo $i."<br>";
	}

?>


<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title><?php echo DBNAME; ?></title>

</head>
	<!-- <div><!--Привет, <?php echo $nickname; ?> --></div>
	<?php
		echo "<div>".$balance."</div>";
		echo DBNAME;
	?> 

</body>
</html>


