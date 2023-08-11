package Lesson4;

/*В качестве монитора используется this*/
public class Counter_2 {
    private int value;
    private int value2;

    public synchronized void inc() {
        value++;

    }
    public synchronized void dec() {
        value--;
    }

    public synchronized void inc2() {
        value2++;

    }
    public synchronized void dec2() {
        value2--;
    }

    public int getValue() {
        return value;
    }

    public int getValue2() {
        return value2;
    }
}
