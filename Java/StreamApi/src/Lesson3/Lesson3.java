package Lesson3;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;

public class Lesson3 {
    public static void main(String[] args) {
        List<User> users = new ArrayList<>();
        users.add(new User("Alex", 35));
        users.add(new User("Max", 22));
        users.add(new User("John", 17));
        users.add(new User("Andrew", 33));
        users.add(new User("Jack", 44));
        users.add(new User("Nick", 80));
        users.add(new User("Alice", 46));
        users.add(new User("Helen", 11));

        long count = users.stream()
                .filter((user) -> user.getAge() > 30)
                .count();
        System.out.println(count);
        /*allMatch - возвращает false, если в коллекции есть элементы, не совпадающие с условием (например, проверка на 18 лет)*/
        boolean resultAllMath = users.stream()
                .allMatch(user -> user.getAge() > 18);
        System.out.println(resultAllMath);
        /*anyMatch - возвращает true, если в коллекции есть хотя бы один елемент, совпадающий с условием*/
        boolean resultAnyMath = users.stream()
                .anyMatch(user -> user.getAge() > 18);
        System.out.println(resultAnyMath);
        /*noneMatch - возвращает true, если условие для всех элементов вернуло false*/
        boolean resultNoneMath = users.stream()
                .noneMatch(user -> user.getAge() < 18);
        System.out.println(resultNoneMath);
        /*Выводим трех самых старших*/
        users.stream()
                .sorted((o1, o2) -> Integer.compare(o2.getAge(), o1.getAge()))
                .limit(3)
                .forEach(System.out::println);


    }
}
