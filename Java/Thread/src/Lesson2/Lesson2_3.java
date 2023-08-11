package Lesson2;

import java.util.ArrayList;
import java.util.List;

public class Lesson2_3 {

    private static List<String> list;
    public static void main(String[] args) {
        Thread thread1 = new Thread(new Runnable() {
            @Override
            public void run() {
                list = new ArrayList<>();
            }
        });
        Thread thread2 = new Thread(new Runnable() {
            @Override
            public void run() {
                try {
                    thread1.join();
                } catch (InterruptedException e) {
                    throw new RuntimeException(e);
                }
                System.out.println(list.size());
            }
        });
        thread1.start();
        thread2.start();
    }
}
