package com.example.samplesenti;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Msball extends AppCompatActivity {

    Button btn_ms, btn_ball;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.msball);

        btn_ms = (Button) findViewById(R.id.btn_ms);
        btn_ball = (Button) findViewById(R.id.btn_ball);

        btn_ms.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Msball.this, Msball1_1.class);
                startActivity(intent);

            }
        });
        btn_ball.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Msball.this, Msball1_2.class);
                startActivity(intent);

            }
        });
    }
}