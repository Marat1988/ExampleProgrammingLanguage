package com.zaurtregulov.spring.spring_introduction;

import org.springframework.context.support.ClassPathXmlApplicationContext;

public class Test4 {
    public static void main(String[] args) {
        ClassPathXmlApplicationContext context = new ClassPathXmlApplicationContext("applicationContext2.xml");
        Dog myDog = context.getBean("myPet", Dog.class);
        //myDog.setName("Belka");
        Dog youDog = context.getBean("myPet", Dog.class);
        //youDog.setName("Strelka");

//        System.out.println(myDog.getName());
//        System.out.println(youDog.getName());

        System.out.println("Переменные ссылаются на один и тотже объект: " + (myDog==youDog));
        System.out.println(myDog);
        System.out.println(youDog);
        context.close();


    }
}
