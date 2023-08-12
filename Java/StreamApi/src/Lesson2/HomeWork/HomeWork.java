package Lesson2.HomeWork;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class HomeWork {
    public static void main(String[] args) {
        List<Integer> numbers = new ArrayList<>();
        for (int i = 0; i < 100; i++) {
            numbers.add((int) (Math.random() * 100 + 100));
        }
        List<String> result = numbers.stream()
                .filter((number) -> number % 2 == 0 && number % 5 == 0)
                .map((integer) -> Math.sqrt(integer))
                .map((sqrt) -> "Sqrt: " + sqrt)
                .collect(Collectors.toList());
        for (String item : result) {
            System.out.println(item);
        }
    }
}
