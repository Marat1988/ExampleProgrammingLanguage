package Lesson4.HomeWork;

public class ATM {
    private int amount;
    private final Object monitor = new Object();

    public ATM(int amount) {
        this.amount = amount;
    }

    public void withDraw(String name, int amount) {
        synchronized (monitor){
            System.out.println(name + " went to the ATM");
            try {
                Thread.sleep(2000);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
            if (amount <= this.amount) {
                this.amount -= amount;
                System.out.println(name + " withdrew " + amount);
                System.out.println("Left: " + this.amount);
            } else {
                System.out.println("There is not enough money in the account for " + name);
            }
        }

    }
}
