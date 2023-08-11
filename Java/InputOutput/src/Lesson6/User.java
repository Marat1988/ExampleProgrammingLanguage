package Lesson6;

import java.io.Serializable;

public class User extends Person implements Serializable {
    private static final long serialVersionUID = -6849794470754667710L;

    private transient Address address;

    public User(String name, String lastName, int age, Address address) {
        super(name, lastName);
        System.out.println("Конструктор");

        this.address = address;
    }

    public Address getAddress() {
        return address;
    }

    public void setAddress(Address address) {
        this.address = address;
    }
}
