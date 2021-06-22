package com.example.samplesenti;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Worldcuplist2014 extends AppCompatActivity {

    Button btn_2014vs, btn_2014vs2, btn_2014victory, btn_2014winners;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.worldcup_list_2014);

        btn_2014vs = (Button) findViewById(R.id.btn_2014vs);
        btn_2014vs2 = (Button) findViewById(R.id.btn_2014vs2);
        btn_2014victory = (Button) findViewById(R.id.btn_2014victory);
        btn_2014winners = (Button) findViewById(R.id.btn_2014winners);

        btn_2014vs.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Worldcuplist2014.this, Worldcuplist2014_1.class);
                startActivity(intent);

                btn_2014vs2.setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view) {
                        Intent intent = new Intent(Worldcuplist2014.this, Worldcuplist2014_2.class);
                        startActivity(intent);
                    }
                });
                btn_2014victory.setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view) {
                        Intent intent = new Intent(Worldcuplist2014.this, Worldcuplist2014_3.class);
                        startActivity(intent);
                    }
                });
                btn_2014winners.setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view) {
                        Intent intent = new Intent(Worldcuplist2014.this, Worldcuplist2014_4.class);
                        startActivity(intent);
                    }
                });
            }
        });
    }
}