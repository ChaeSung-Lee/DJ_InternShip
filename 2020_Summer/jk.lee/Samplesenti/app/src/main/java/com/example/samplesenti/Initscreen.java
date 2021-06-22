package com.example.samplesenti;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.content.Intent;
import android.widget.TextView;

public class Initscreen extends AppCompatActivity
{
    Button btn_home, btn_res;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.init_screen);

        btn_home = (Button) findViewById(R.id.btn_home);
        btn_res = (Button) findViewById(R.id.btn_res);

        btn_res.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Initscreen.this, Signup.class);
                startActivity(intent);

            }
        });
        btn_home.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Initscreen.this, Home.class);
                startActivity(intent);
            }
        });
    }

}

