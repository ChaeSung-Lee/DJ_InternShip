package com.example.samplesenti;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Community extends AppCompatActivity {

    Button btn_board, btn_chat;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.community);

        btn_board = (Button) findViewById(R.id.btn_board);
        btn_chat = (Button) findViewById(R.id.btn_chat);

        btn_board.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Community.this, Community1.class);
                startActivity(intent);

            }


        });
        btn_chat.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Community.this, Community2.class);
                startActivity(intent);

            }
        });
    }
}