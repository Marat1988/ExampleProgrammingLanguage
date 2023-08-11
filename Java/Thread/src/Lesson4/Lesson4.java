package Lesson4;

public class Lesson4 {
    public static void main(String[] args) {
        Counter_2 counter = new Counter_2();
        long before = System.currentTimeMillis();
        int barrier = 100_000_000;
        Thread thread1 = new Thread(new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < barrier; i++) {
                    counter.inc();
                }
            }
        });

        Thread thread2 = new Thread(new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < barrier; i++) {
                    counter.dec();
                }
            }
        });

        Thread thread3 = new Thread(new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < barrier; i++) {
                    counter.inc2();
                }
            }
        });

        Thread thread4 = new Thread(new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < barrier; i++) {
                    counter.dec2();
                }
            }
        });

        thread1.start();
        thread2.start();
        thread3.start();
        thread4.start();
        try {
            thread1.join();
            thread2.join();
            thread3.join();
            thread4.join();
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        System.out.println(counter.getValue());
        System.out.println(counter.getValue2());
        long after = System.currentTimeMillis();
        System.out.println(after - before);
    }
}
