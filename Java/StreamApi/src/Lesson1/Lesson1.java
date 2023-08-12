package Lesson1;

public class Lesson1 {
    public static void main(String[] args) {
        new Thread(() -> System.out.println(1)).start();
    }
}
