package com.example.stringadvanced;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.util.Patterns;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
//        String nameString = "Андрей, Алексей, Роман, Павел, Михаил";
//        String[] names = nameString.split(", ");
//        for (String name: names) {
//            Log.i("MyName", name);
//        }

//        String geometry = "Геометрия";
//        String meter = geometry.substring(3, 7);
//        Log.i("MyName", meter);

        String river = "MississippiMississippi";
        Pattern pattern = Pattern.compile("Mi(.*?)pi");
        Matcher matcher = pattern.matcher(river);
        while (matcher.find()){
            Log.i("MyName", matcher.group(1));
        }
    }
}