package com.zaurtregulov.spring.spring_introduction;

import org.springframework.context.support.ClassPathXmlApplicationContext;

import java.util.Arrays;

public class Test3 {
    public static void main(String[] args) {

        ClassPathXmlApplicationContext context = new ClassPathXmlApplicationContext("applicationContext.xml");
        //Pet pet = context.getBean("myPet", Pet.class);
        //Person person = new Person(pet);
        Person person = context.getBean("myPerson", Person.class);
        person.callYouPet();
        System.out.println(person.getSurname());
        System.out.println(person.getAge());
        context.close();
    }
}
