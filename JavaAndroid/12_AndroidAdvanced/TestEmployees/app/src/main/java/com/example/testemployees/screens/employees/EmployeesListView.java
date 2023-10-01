package com.example.testemployees.screens.employees;

import com.example.testemployees.pojo.Employee;

import java.util.List;

public interface EmployeesListView {
    void showData(List<Employee> employees);
    void showError();
}
