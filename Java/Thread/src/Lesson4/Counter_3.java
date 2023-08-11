package Lesson4;


public class Counter_3 {
    private int value;
    private int value2;

    private final Object monitor1 = new Object();
    private final Object monitor2 = new Object();

    public void inc() {
        synchronized (monitor1){
            value++;
        }
    }
    public  void dec() {
        synchronized (monitor1){
            value--;
        }
    }

    public  void inc2() {
        synchronized (monitor2){
            value2++;
        }

    }
    public  void dec2() {
        synchronized (monitor2){
            value2--;
        }
    }

    public int getValue() {
        return value;
    }

    public int getValue2() {
        return value2;
    }
}
