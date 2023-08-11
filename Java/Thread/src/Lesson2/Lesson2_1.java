package Lesson2;

public class Lesson2_1 {
    public static void main(String[] args) {
        System.out.println("Start");
        Thread thread = new Thread(new Runnable() {
            @Override
            public void run() {
                try {
                    for (int i = 0; i < 1000; i++) {
                        if (Thread.currentThread().isInterrupted()){
                            break;
                        }
                        System.out.print(i);
                        Thread.sleep(1000);
                    }
                } catch (InterruptedException e) {
                    throw new RuntimeException(e);
                }
            }
        });

        thread.start();
        try {
            Thread.sleep(1000);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        for (int i = 0; i < 1000; i++) {
            if (i==100){
                thread.interrupt();
            }
            System.out.print("M");
        }
        System.out.println("\nFinish");
    }
}
