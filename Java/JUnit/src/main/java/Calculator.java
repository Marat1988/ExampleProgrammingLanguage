public class Calculator {
    public double add(int a, int b) {
        return a + b;
    }

    public double add(String a, String b) {
        int numA = Integer.parseInt(a);
        int numB = Integer.parseInt(b);
        return numA + numB;
    }

    public double divide(double a, double b) {
        return a / b;
    }

    public double divide(String a, String b) {
        double numA = Double.parseDouble(a);
        double numB = Double.parseDouble(b);
        return numA / numB;
    }

    public double multiple(double a, double b) {
        return a * b;
    }

    public double square(double a) {
        return a * a;
    }
}
