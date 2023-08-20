public class Main {
    public static void main(String[] args) {
        double a = 1;
        double b = 0;
        for (int i = 0; i < 100; i++) {
            b += 0.01;
        }
        System.out.println(a == b);
        System.out.println(a);
        System.out.println(b);
    }
}