package Lesson3.HomeWork;

import java.io.*;
import java.nio.charset.StandardCharsets;
import java.util.Arrays;

public class HomeWork {
    public static void main(String[] args) {
        File directory = new File("folder");
        File file = new File(directory, "names.txt");

        try (Reader reader = new InputStreamReader(new FileInputStream(file), StandardCharsets.UTF_8)) {
            char[] array = new char[128];
            int count = reader.read(array);
            StringBuilder result = new StringBuilder();
            while (count > 0) {
                result.append(array, 0, count);
                count = reader.read();
            }
            String[] names = result.toString().split(" ");
            Arrays.stream(names)
                    .filter(name -> name.startsWith("A"))
                    .forEach(System.out::println);

        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}
