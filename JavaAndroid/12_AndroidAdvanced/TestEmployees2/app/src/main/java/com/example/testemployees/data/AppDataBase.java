package com.example.testemployees.data;

import android.content.Context;

import androidx.room.Database;
import androidx.room.Room;
import androidx.room.RoomDatabase;

import com.example.testemployees.pojo.Employee;

@Database(entities = {Employee.class}, version = 2, exportSchema = false)
public abstract class AppDataBase extends RoomDatabase {
    private static AppDataBase dataBase;
    private static final String DB_NAME = "employess.db";

    private static final Object LOCK = new Object();

    public static AppDataBase getInstance(Context context) {
        synchronized (LOCK) {
            if (dataBase == null) {
                dataBase = Room.databaseBuilder(context, AppDataBase.class, DB_NAME)
                        .fallbackToDestructiveMigration()
                        .build();
            }
            return dataBase;
        }
    }

    public abstract EmployeeDAO employeeDAO();
}
