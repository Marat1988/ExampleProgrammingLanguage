import java.util.LinkedList

fun main() {
    //val array = arrayOfNulls<Int?>(101)
//    for (i in 0..<array.size){
//        array[i] = i
//    }
//    for (i in array){
//        println(i)
//    }
//    for (i in 100 downTo 0 step 2){
//        println(i)
//    }
    val array = arrayOfNulls<Int?>(100)
    for (i in 0..<100) {
        array[i] = i
    }
    for ((index, i) in array.withIndex()) {
        array[index] = i?.times(2)
    }
    for (i in array) {
        println(i)
    }
    homeWork2()
}

fun homeWork2() {
    val array = arrayOfNulls<Int?>(301)
    for ((index, i) in (300..600).withIndex()) {
        array[index] = i
    }
    for (i in array.size - 1 downTo 0 step 5) {
        println(array[i])
    }
}



