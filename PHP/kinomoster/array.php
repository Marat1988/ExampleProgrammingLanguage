<?php  

    // $arr["product"] = "продукты";
    // $arr["water"] = "бутылка с водой";
    
    
    // for($i = 0; $i < count($arr); $i++) {
    //     echo $arr[$i]."<br>";
    // }
    
    
    /* напишите код цикла после  $i = 0; */
    // $i = 0;
    
    // while($i < count($arr))
    // {
    //     echo $arr[$i]."<br>";
    //     $i++;
    // }

    // foreach ($arr as $key => $value) {
    //  echo "ключ к массиву ".$key." - значение массива ".$value."<br>";
    // }

    //$arr = array("product"=>"продукты", "water"=>"бутылка с водой");

    $arr = ["продкуты","бутылка с водой"];

    unset($arr[0]);

    array_push($arr, "яблоко");
    array_unshift($arr, "апельсин");
    array_push($arr, "апельсин");


    $arr = array_unique($arr);
    $arr = array_reverse($arr);

    sort($arr);

    shuffle($arr);

    $arr2 = array("кокос", "арбуз");

    $newarr = array_merge($arr, $arr2);


    foreach($newarr as $key => $value) {
        echo "ключ к массиву ".$key." - значение массива ".$value."<br>";
    }

    // $str = implode(", ", $newarr);
    // echo "<br>".$str;

    $str = "продукты, бутылка кокомс, пиво";
    $strtoarr = explode(", ", $str);
    echo "<pre>";
    print_r($strtoarr);
    echo "</pre>";

    // $camera["market1"]["row1"][0] = "продукты";
    // $camera["market1"]["row1"][1] = "сумка";
    // $camera["market2"]["row2"][0] = "апельсин";
    // $camera["market2"]["row2"][1] = "фотоаппарат";
    // $camera["market2"]["row2"][2] = "телефон";

    $camera = array(
        "market1"=>array(
            "row1"=>array(
                "продукты","сумка"
            ),
            "row2"=>array(
                "апельсин","фотоаппарат","телефон"

            )
        ),
        "market2"=>array(
            "row1"=>array(
                "продукты","сумка"
            ),
            "row2"=>array(
                "апельсин","фотоаппарат","телефон"

            )
        ),

    );


    echo "<pre>";
    print_r($camera);
    echo "</pre>";

    foreach ($camera as $key => $value) {
        foreach ($value as $key2 => $value2) {
            foreach ($value2 as $key3 => $value3) {
                echo $value3;
            }
        }
    }




?>


<!doctype html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>тест</title>
</head>
<body>
    
</body>
</html>