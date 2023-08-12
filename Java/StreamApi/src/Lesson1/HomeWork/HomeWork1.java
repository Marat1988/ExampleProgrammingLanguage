package Lesson1.HomeWork;

public class HomeWork1 {
    public static void main(String[] args) {
        Director director = new Director();
        String result = director.force(count -> {
            for (int i = 0; i < count; i++) {
                System.out.println("Working....");
            }
            return "Success";
        }, 4);
        System.out.println(result);
    }
}
