fun main() {
    var count = 400
    val food = if (count > 500) {
        count -= 500
        "Пицца"
    } else if (count > 300) {
        count -= 300
        "500"
    } else {
        count -= 30
        "Дощирак"
    }
    println("Вы можете позволить себе купить себе следующий продукт: $food, у вас осталось: $count рублей")
}

