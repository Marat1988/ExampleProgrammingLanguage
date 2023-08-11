package Lesson4;

public class Counter {
    private int value;
    private final Object monitor = new Object();

    public void inc() {
        synchronized (monitor) {
            value++;
        }
    }

    public void dec() {
        synchronized (monitor) {
            value--;
        }
    }

    public int getValue() {
        return value;
    }
}
