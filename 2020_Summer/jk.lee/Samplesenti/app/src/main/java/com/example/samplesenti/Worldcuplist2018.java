package com.example.samplesenti;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Worldcuplist2018 extends AppCompatActivity {

    Button btn_2018vs;
    Button btn_2018vs2;
    Button btn_2018victory;
    Button btn_2018winners;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.worldcup_list_2018);

        btn_2018vs = (Button) findViewById(R.id.btn_2018vs);
        btn_2018vs2 = (Button) findViewById(R.id.btn_2018vs2);
        btn_2018victory = (Button) findViewById(R.id.btn_2018victory);
        btn_2018winners = (Button) findViewById(R.id.btn_2018winners);

        btn_2018vs.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Worldcuplist2018.this, Worldcuplist2018_1.class);
                startActivity(intent);

                btn_2018vs2.setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view) {
                        Intent intent = new Intent(Worldcuplist2018.this, Worldcuplist2018_2.class);
                        startActivity(intent);
                    }
                });
                btn_2018victory.setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view) {
                        Intent intent = new Intent(Worldcuplist2018.this, Worldcuplist2018_3.class);
                        startActivity(intent);
                    }
                });
                btn_2018winners.setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view) {
                        Intent intent = new Intent(Worldcuplist2018.this, Worldcuplist2018_4.class);
                        startActivity(intent);
                    }
                });
            }
        });
    }
}