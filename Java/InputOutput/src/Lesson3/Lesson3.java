package Lesson3;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;

public class Lesson3 {
    public static void main(String[] args) {
        File directory = new File("folder");
        directory.mkdir();
        File file = new File(directory, "names.txt");
        try {
            file.createNewFile();
        } catch (IOException e) {
            throw new RuntimeException(e);
        }
        try (InputStream inputStream = new FileInputStream(file)) {
            long before = System.currentTimeMillis();
            byte[] array = new byte[8192];
            int count = inputStream.read(array);
            StringBuilder result = new StringBuilder();
            while (count > 0) {
                result.append(new String(array, 0, count));
                count = inputStream.read(array);
            }
            System.out.println(result);
            long after = System.currentTimeMillis();
            System.out.println(after - before);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}
