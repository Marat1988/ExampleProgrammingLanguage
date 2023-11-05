<?php 
	// print_r($_GET);
	// echo $_GET['name'];
	//print_r($_POST);
	if (isset($_POST['name'])){
		$nameFilter = htmlspecialchars($_POST['name'], ENT_QUOTES, 'UTF-8');
		echo "Мое имя, ".$nameFilter;
	}

	// $user = "     ВаСЯ   ";
	// echo mb_strtolower(trim($user));
?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Functions</title>
</head>
<body>
	<form action="" method="post" >
		<input type="text" name="name" placeholder="Ваше имя">
		<textarea name="comment"></textarea>
		<input type="hidden" name="id_user" value="1313">
		<input type="submit" value="Отправить">
	</form>

	<?php  
		function sum($a, $b){
			$result = false;
			if(!is_numeric($a)){
				$result = "Ошибка. Значение 'a' не является числом";
			} else if (!is_numeric($b)) {
				$result = "Ошибка. Значение 'b' не является числом";
			} else {
				$result = $a + $b;
			}
			return $result;
		}

		function maxSum($sum){
			$result = false;
			if ($sum > 30){
				$result = "Сумма больше 30";
			} else {
				$result = "Сумма меньше 30";
			}
			return $result;
		}

		echo sum(2,5);

		echo maxSum(sum(6,3));
	?>
</body>
</html>