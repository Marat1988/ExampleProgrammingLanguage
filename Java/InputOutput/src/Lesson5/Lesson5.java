package Lesson5;

import java.io.File;
import java.io.RandomAccessFile;

public class Lesson5 {
    public static void main(String[] args) {
        File directory = new File("folder");
        File file = new File(directory, "names.txt");
        try(RandomAccessFile accessFile = new RandomAccessFile(file,"rw")) {
            accessFile.seek(10);
            accessFile.writeBytes("****************");
            accessFile.seek(100);
            accessFile.writeBytes("****************");
            accessFile.seek(1000);
            accessFile.writeBytes("****************");
        } catch (Exception e){
            System.out.println(e.getMessage());
        }
    }
}
