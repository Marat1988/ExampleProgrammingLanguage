package Lesson5;

import java.io.File;
import java.io.RandomAccessFile;

public class Lesson5_1 {
    public static void main(String[] args) {
        File directory = new File("folder");
        File file = new File(directory, "names.txt");
        try (RandomAccessFile accessFile = new RandomAccessFile(file, "rw")) {
            accessFile.seek(5000);
            byte[] array = new byte[1024];
            accessFile.read(array);
            System.out.println(new String(array));
            accessFile.seek(0);
            accessFile.read(array);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}
