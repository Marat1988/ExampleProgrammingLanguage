package Lesson4;

import java.io.File;
import java.io.FileOutputStream;
import java.io.OutputStream;

public class Lesson4 {
    public static void main(String[] args) {
        File directory = new File("folder");
        File file = new File(directory, "names.txt");
        try (OutputStream outputStream = new FileOutputStream(file, true)) {
            String names = "\nMax Ivan Marat";
            outputStream.write(names.getBytes());
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }


    }
}
