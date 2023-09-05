package com.zaurtregulov.spring.spring_introduction;

import org.springframework.context.support.ClassPathXmlApplicationContext;

public class ConfigWithAnnotations1 {
    public static void main(String[] args) {
        ClassPathXmlApplicationContext context = new ClassPathXmlApplicationContext("applicationContext3.xml");
//        Cat myCat = context.getBean("cat", Cat.class);
//        myCat.say();

        Person person = context.getBean("personBean",Person.class);
        person.callYouPet();
        System.out.println(person.getSurname());
        System.out.println(person.getAge());

        context.close();
    }
}
