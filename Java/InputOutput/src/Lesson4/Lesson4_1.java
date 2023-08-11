package Lesson4;

import java.io.*;

public class Lesson4_1 {
    public static void main(String[] args) {
        File directory = new File("folder");
        File file = new File(directory, "names.txt");
        try (InputStream inputStream = new BufferedInputStream(new FileInputStream(file))) {
            StringBuilder result = new StringBuilder();
            long before = System.currentTimeMillis();
            int a = inputStream.read();
            while (a != -1) {
                result.append((char) a);
                a = inputStream.read();
            }
            long after = System.currentTimeMillis();
            System.out.println(after - before);

        } catch (Exception e) {
            System.out.println(e.getMessage());
        }


    }
}
