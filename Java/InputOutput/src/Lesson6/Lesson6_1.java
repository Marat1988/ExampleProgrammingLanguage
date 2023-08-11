package Lesson6;

import java.io.*;

public class Lesson6_1 {
    public static void main(String[] args) {
        File file = new File("users.txt");
        try (ObjectInputStream objectInputStream = new ObjectInputStream(new FileInputStream(file))) {
            User user = (User) objectInputStream.readObject();
            System.out.println(user);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
