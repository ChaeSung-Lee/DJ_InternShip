package com.example.samplesenti;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Worldcuplist2010 extends AppCompatActivity {

    Button btn_2010vs, btn_2010vs2, btn_2010victory, btn_2010winners;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.worldcup_list_2010);

        btn_2010vs = (Button) findViewById(R.id.btn_2010vs);
        btn_2010vs2 = (Button) findViewById(R.id.btn_2010vs2);
        btn_2010victory = (Button) findViewById(R.id.btn_2010victory);
        btn_2010winners = (Button) findViewById(R.id.btn_2010winners);

        btn_2010vs.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Worldcuplist2010.this, Worldcuplist2010_1.class);
                startActivity(intent);

                btn_2010vs2.setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view) {
                        Intent intent = new Intent(Worldcuplist2010.this, Worldcuplist2010_2.class);
                        startActivity(intent);
                    }
                });
                btn_2010victory.setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view) {
                        Intent intent = new Intent(Worldcuplist2010.this, Worldcuplist2010_3.class);
                        startActivity(intent);
                    }
                });
                btn_2010winners.setOnClickListener(new View.OnClickListener(){
                    @Override
                    public void onClick(View view) {
                        Intent intent = new Intent(Worldcuplist2010.this, Worldcuplist2010_4.class);
                        startActivity(intent);
                    }
                });
            }
        });
    }
}