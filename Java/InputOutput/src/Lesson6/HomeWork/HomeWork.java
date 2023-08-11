package Lesson6.HomeWork;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class HomeWork {
    public static void main(String[] args) {
        File file = new File("cats.txt");
        try {
            file.createNewFile();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
        List<Cat> cats = new ArrayList<>();
        for (int i = 0; i < 10; i++) {
            cats.add(new Cat("Name" + i, "Breed" + i, 1f));
        }
        try (ObjectOutputStream objectOutputStream = new ObjectOutputStream(new FileOutputStream(file))) {
            objectOutputStream.writeObject(cats);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }

        try(ObjectInputStream objectInputStream = new ObjectInputStream(new FileInputStream(file))) {
            List<Cat> catsRead = (List<Cat>) objectInputStream.readObject();
            for (Cat cat: catsRead) {
                System.out.println(cat.getName());
            }
        } catch (Exception e){
            e.printStackTrace();
        }
    }
}
