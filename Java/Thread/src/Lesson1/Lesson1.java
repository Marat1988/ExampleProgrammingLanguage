package Lesson1;

public class Lesson1 {
    public static void main(String[] args) {
        System.out.println("Start");
        MyRunnable myRunnable = new MyRunnable();
        Thread thread = new Thread(myRunnable);
        thread.start();
        for (int i = 0; i < 1000; i++) {
            System.out.print("M");
        }
        System.out.println("\nFinish");


    }
}
