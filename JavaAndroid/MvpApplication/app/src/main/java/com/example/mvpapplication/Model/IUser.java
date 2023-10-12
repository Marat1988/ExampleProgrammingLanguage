package com.example.mvpapplication.Model;

public interface IUser {
    String getName();
    String getPasswd();
    int checkUserValidity(String name, String passwd);
}
