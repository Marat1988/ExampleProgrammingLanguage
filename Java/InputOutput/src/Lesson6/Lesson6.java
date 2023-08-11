package Lesson6;

import java.io.File;
import java.io.FileOutputStream;
import java.io.ObjectOutputStream;

public class Lesson6 {
    public static void main(String[] args) {
        User user = new User("John", "Smith", 25, new Address("Main", 15));
        File file = new File("users.txt");
        try (ObjectOutputStream objectOutputStream = new ObjectOutputStream(new FileOutputStream(file))) {
            objectOutputStream.writeObject(user);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
