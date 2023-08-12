package Lesson4;

import Lesson3.User;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Optional;
import java.util.stream.Stream;

public class Lesson4 {
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

        int[] array = {3, 2, 4, 7, 8, 3};
        //Arrays.stream(array)
        //Stream.of(4,5,6,7,4,5)


        Optional<User> oldest = users.stream()
                .max((o1, o2) -> Integer.compare(o1.getAge(), o2.getAge()));

        oldest.ifPresentOrElse((user) -> System.out.println(user), () -> System.out.println("user not fount"));

        users.stream()
                .filter(user1 -> user1.getName().contains("l"))
                .findFirst()
                .ifPresentOrElse((userFind) -> System.out.println(userFind), () -> System.out.println("user not fount"));


    }
}
