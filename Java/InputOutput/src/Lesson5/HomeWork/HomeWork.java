package Lesson5.HomeWork;

import java.io.File;
import java.io.RandomAccessFile;
import java.util.Scanner;

public class HomeWork {
    public static void main(String[] args) {
        File directory = new File("folder");
        File file = new File(directory, "names.txt");
        try (RandomAccessFile randomAccessFile = new RandomAccessFile(file, "r")) {
            Scanner scanner = new Scanner(System.in);
            System.out.println("Enter to page or stop to exit");
            byte[] pageText = new byte[3000];
            String input = scanner.nextLine();
            while (!input.equals("stop")) {
                int page = Integer.parseInt(input);
                randomAccessFile.seek((page + 1) * pageText.length);
                int count = randomAccessFile.read(pageText);
                System.out.println(new String(pageText,0,count));
                System.out.println("Enter to page or stop to exit");
                input = scanner.nextLine();
            }
        } catch (Exception e) {
            e.printStackTrace();
        }

    }
}
