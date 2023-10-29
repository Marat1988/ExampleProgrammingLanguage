fun main() {
    /*val indexOfMonth = 3
    val season = when (indexOfMonth) {
        12, 1, 2 -> {
            "Зима"
        }

        in 3..5 -> {
            "Весна"
        }

        in 6..8 -> {
            "Лето"
        }

        in 9..11 -> {
            "Осень"
        }

        else -> {
            "Не найдено"
        }
    }
    println(indexOfMonth)*/
    val temp = 80
    val state = when {
        temp < 0 -> "Твердое"
        temp < 100 -> "Жидкая"
        else -> "Газообразная"
    }
    println(state)
    homeWork2()

}

fun homeWork2() {
    val time = 23;
    val weatherIsGood = true;
    val result = when {
        time in 6..22 && weatherIsGood -> {
            "Гулять"
        }

        time in 6..22 && !weatherIsGood -> {
            "Читать книгу"
        }

        else -> {
            "Спать"
        }
    }
    println(result)
}

