package com.example.messenger;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class CreateMessageActivity extends AppCompatActivity {

    private EditText editTextMsg;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_create_message);
        editTextMsg = findViewById(R.id.editTextMessage);
    }

    public void onClickSendMessage(View view) {
        String msg = editTextMsg.getText().toString();
        Intent intent = new Intent(this, ReceivedMessageActivity.class);
        intent.putExtra("msg", msg);
        startActivity(intent);
    }
}