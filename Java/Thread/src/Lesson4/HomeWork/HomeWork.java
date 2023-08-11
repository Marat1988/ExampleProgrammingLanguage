package Lesson4.HomeWork;

public class HomeWork {
    public static void main(String[] args) {
        ATM atm = new ATM(1000);
        Thread thread1 = new Thread(new Runnable() {
            @Override
            public void run() {
                atm.withDraw("Max", 300);
            }
        });
        Thread thread2 = new Thread(new Runnable() {
            @Override
            public void run() {
                atm.withDraw("John", 500);
            }
        });
        Thread thread3 = new Thread(new Runnable() {
            @Override
            public void run() {
                atm.withDraw("Nick", 400);
            }
        });

        thread1.start();
        thread2.start();
        thread3.start();

    }
}
