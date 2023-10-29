private var name: String? = "Ivan";

fun main() {
    val length = name?.length ?: 0
    println(length)
    homeWork1();
}

fun homeWork1() {
    val a: String? = null
    val b: String = "fggf"
    val c: String = ""
    val result = (a?.length ?: 0) + (b?.length ?: 0) + (c?.length ?: 0);
    println(result)
}