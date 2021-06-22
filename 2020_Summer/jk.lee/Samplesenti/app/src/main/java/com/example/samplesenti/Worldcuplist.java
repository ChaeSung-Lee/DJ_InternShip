package com.example.samplesenti;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;


public class Worldcuplist extends AppCompatActivity {

    Button btn_list2002, btn_list2018, btn_list2014, btn_list2010;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.worldcup_list);

        btn_list2018 = (Button) findViewById(R.id.btn_list2018);
        btn_list2014 = (Button) findViewById(R.id.btn_list2014);
        btn_list2010 = (Button) findViewById(R.id.btn_list2010);

        btn_list2018.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Worldcuplist.this, Worldcuplist2018.class);
                startActivity(intent);
            }
        });
        btn_list2014.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Worldcuplist.this, Worldcuplist2014.class);
                startActivity(intent);
            }
        });
        btn_list2010.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Worldcuplist.this, Worldcuplist2010.class);
                startActivity(intent);
            }
        });

    }
}