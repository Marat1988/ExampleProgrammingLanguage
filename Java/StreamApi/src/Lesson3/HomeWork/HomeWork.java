package Lesson3.HomeWork;

import Lesson3.User;

import java.util.ArrayList;
import java.util.List;

public class HomeWork {
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

        users.stream()
                .sorted((o1,o2)->o1.getName().compareTo(o2.getName()))
                .filter(user -> user.getAge()<40)
                .limit(3)
                .map(user -> user.getName())
                .forEach(System.out::println);
    }
}
