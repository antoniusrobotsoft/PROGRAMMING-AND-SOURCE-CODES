package com.ringlayer.indotalent;

/*
* created by Antonius Ringlayer
* www.ringlayer.net - www.ringlayer.com
* https://github.com/ringlayer
* */

import android.content.Intent;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;

import android.widget.Button;
import android.widget.ImageView;


public class RegisterResult extends AppCompatActivity {
    FileSystemOp fso = new FileSystemOp();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register_result);
        RegisterResult.MyTouchListener touchListener = new RegisterResult.MyTouchListener();
        ImageView img_back = (ImageView) findViewById(R.id.back);
        img_back.setOnTouchListener(touchListener);
        Button lp = (Button) findViewById(R.id.tombol_register);
        lp.setOnTouchListener(touchListener);

    }

    public void akhiri() {
        try{
            Intent i = new Intent(RegisterResult.this, MainActivity.class);
            startActivity(i);
            finish();
        }
        catch (Exception e) {
            fso._do_log_debug(e, "akhiri");
        }
    }

    /*
    taken from https://www.viralandroid.com/2016/01/how-to-closeexit-android-application.html
    */
    public void closeApplication(View view) {
        finish();
        moveTaskToBack(true);
    }


    /*
    start subclass
    http://stackoverflow.com/questions/17864143/single-method-to-implement-ontouchlistener-for-multiple-buttons
    */

    public class MyTouchListener implements View.OnTouchListener {
        @Override
        public boolean onTouch(View v, MotionEvent event) {
            try {
                switch(v.getId()) {
                    case R.id.tombol_register:
                        akhiri();
                        break;
                    case R.id.back:
                        akhiri();
                        break;
                }
            }
            catch (Exception e) {
                fso._do_log_debug(e, "MyTouchListener");
            }
            return true;
        }
    }
    /* eof subclasses*/
}
