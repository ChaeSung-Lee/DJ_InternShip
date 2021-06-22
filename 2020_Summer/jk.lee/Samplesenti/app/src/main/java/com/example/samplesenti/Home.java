package com.example.samplesenti;

import androidx.appcompat.app.AppCompatActivity;


import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;


public class Home extends AppCompatActivity {

    Button btn_login, btn_list, btn_origin, btn_msofball, btn_community;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.home);

        btn_login = (Button) findViewById(R.id.btn_login);
        btn_list = (Button) findViewById(R.id.btn_list);
        btn_origin = (Button) findViewById(R.id.btn_origin);
        btn_msofball = (Button) findViewById(R.id.btn_msofball);
        btn_community = (Button) findViewById(R.id.btn_community);

        btn_login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Home.this, Initscreen.class);
                startActivity(intent);

            }


        });
        btn_list.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Home.this, Worldcuplist.class);
                startActivity(intent);

            }
        });
        btn_origin.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Home.this, Origin.class);
                startActivity(intent);

            }
        });
        btn_msofball.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Home.this, Msball.class);
                startActivity(intent);

            }
        });
        btn_community.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Home.this, Community.class);
                startActivity(intent);

            }
        });
    }
}
