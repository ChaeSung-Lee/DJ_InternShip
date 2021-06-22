package com.example.samplesenti;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class Origin extends AppCompatActivity {

    Button btn_worigin, btn_sorigin;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.origin);

        btn_worigin = (Button) findViewById(R.id.btn_worigin);
        btn_sorigin = (Button) findViewById(R.id.btn_sorigin);


        btn_worigin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Origin.this, Origin1_1.class);
                startActivity(intent);

            }


        });
        btn_sorigin.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Origin.this, Origin1_2.class);
                startActivity(intent);

            }
        });

    }
}
