package Lesson6.HomeWork;

import java.io.Serializable;

public class Cat implements Serializable {
    private String name;
    private String breed;
    private float weight;


    public Cat(String name, String breed, float weight) {
        this.name = name;
        this.breed = breed;
        this.weight = weight;
    }

    public String getName() {
        return name;
    }
}
