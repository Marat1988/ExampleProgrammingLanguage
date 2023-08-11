package Lesson2.HomeWork;

import java.util.ArrayList;

public class HomeWork {
    private static final int SIZE = 50_000_000;
    private static final int HALF = SIZE / 2;

    public static void main(String[] args) {
        withoutConcurrency();
        withConcurrency();
    }

    private static void withoutConcurrency() {
        float[] array = new float[SIZE];
        for (int i = 0; i < SIZE; i++) {
            array[i] = 1f;
        }
        long before = System.currentTimeMillis();
        for (int i = 0; i < SIZE; i++) {
            float f = (float) i;
            array[i] = (float) (array[i] * Math.sin(0.2f + f / 5) * Math.cos(0.2f + f / 5) * Math.cos(0.4f + f / 2));
        }
        long after = System.currentTimeMillis();
        System.out.println("withoutConcurrency" + (after - before));
    }

    private static void withConcurrency(){
        float[] array = new float[SIZE];
        for (int i = 0; i < SIZE; i++) {
            array[i] = 1f;
        }
        long before = System.currentTimeMillis();
        float[] firstHalf = new float[HALF];
        float[] secondHalf = new float[HALF];
        System.arraycopy(array,0, firstHalf, 0, HALF);
        System.arraycopy(array,HALF, secondHalf, 0, HALF);

        Thread thread1 = new Thread(new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < HALF; i++) {
                    float f = (float) i;
                    firstHalf[i] = (float) (firstHalf[i] * Math.sin(0.2f + f / 5) * Math.cos(0.2f + f / 5) * Math.cos(0.4f + f / 2));
                }
            }
        });

        Thread thread2 = new Thread(new Runnable() {
            @Override
            public void run() {
                for (int i = 0; i < HALF; i++) {
                    float f = (float) (i + HALF);
                    secondHalf[i] = (float) (secondHalf[i] * Math.sin(0.2f + f / 5) * Math.cos(0.2f + f / 5) * Math.cos(0.4f + f / 2));
                }
            }
        });
        thread1.start();
        thread2.start();
        try {
            thread1.join();
            thread2.join();
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        System.arraycopy(firstHalf, 0, array, 0, HALF);
        System.arraycopy(secondHalf, 0, array, HALF, HALF);
        System.out.println();
        long after = System.currentTimeMillis();
        System.out.println("withConcurrency" + (after - before));
    }
}
