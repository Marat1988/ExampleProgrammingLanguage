package Lesson4;

import Lesson3.User;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

public class Lesson4_1 {
    public static void main(String[] args) {
        List<Float> numbers = new ArrayList<>();
        for (int i = 0; i < 30_000_000; i++) {
            numbers.add((float) i);
        }
        long before = System.currentTimeMillis();
        numbers.parallelStream()
                .map((number) -> Math.sin((0.2f + number / 5) * Math.cos(0.2f + number / 5) * Math.cos(0.4f + number / 2)))
                .collect(Collectors.toList());
        long after = System.currentTimeMillis();
        System.out.println(after - before);


    }
}
