package com.example.samplesenti;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Worldcuplist1 extends AppCompatActivity {

    Button btn_vs;
    Button btn_vs2;
    Button btn_victory;
    Button btn_winners;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.worldcup_list_1);

        btn_vs = (Button) findViewById(R.id.btn_vs);
        btn_vs2 = (Button) findViewById(R.id.btn_vs2);
        btn_victory = (Button) findViewById(R.id.btn_victory);
        btn_winners = (Button) findViewById(R.id.btn_winners);

        btn_vs.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Worldcuplist1.this, Worldcuplist1_1.class);
                startActivity(intent);

                btn_vs2.setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view) {
                        Intent intent = new Intent(Worldcuplist1.this, Worldcuplist1_2.class);
                        startActivity(intent);
                    }
                });
                btn_victory.setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view) {
                        Intent intent = new Intent(Worldcuplist1.this, Worldcuplist1_3.class);
                        startActivity(intent);
                    }
                });
                btn_winners.setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view) {
                        Intent intent = new Intent(Worldcuplist1.this, Worldcuplist1_4.class);
                        startActivity(intent);
                    }
                });
            }
        });
    }
}