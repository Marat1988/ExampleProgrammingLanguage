package com.example.testemployees.pojo;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

import java.util.List;

public class Employee {
    @SerializedName("f_name")
    @Expose
    private String name;
    @SerializedName("l_name")
    @Expose
    private String lName;
    @SerializedName("birthday")
    @Expose
    private String birthday;
    @SerializedName("avatr_url")
    @Expose
    private String avatrUrl;
    @SerializedName("specialty")
    @Expose
    private List<Speciality> specialty;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getlName() {
        return lName;
    }

    public void setlName(String lName) {
        this.lName = lName;
    }

    public String getBirthday() {
        return birthday;
    }

    public void setBirthday(String birthday) {
        this.birthday = birthday;
    }

    public String getAvatrUrl() {
        return avatrUrl;
    }

    public void setAvatrUrl(String avatrUrl) {
        this.avatrUrl = avatrUrl;
    }

    public List<Speciality> getSpecialty() {
        return specialty;
    }

    public void setSpecialty(List<Speciality> specialty) {
        this.specialty = specialty;
    }
}
