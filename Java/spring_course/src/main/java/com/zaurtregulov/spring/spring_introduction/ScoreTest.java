package com.zaurtregulov.spring.spring_introduction;

import org.springframework.context.support.ClassPathXmlApplicationContext;

public class ScoreTest {
    public static void main(String[] args) {
        ClassPathXmlApplicationContext context = new ClassPathXmlApplicationContext("applicationContext3.xml");

        Dog myDog = context.getBean("dog", Dog.class);
        Dog youDog = context.getBean("dog", Dog.class);

        System.out.println("Переменные ссылаюстя на один и тот ж объект: " + (myDog==youDog));
        System.out.println(myDog);
        System.out.println(youDog);

        context.close();

    }
}
