package com.ringlayer.indotalent;

import android.content.Intent;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Button;

import android.widget.ImageView;
import android.widget.Toast;

public class LupaPasswordSent extends AppCompatActivity {
    FileSystemOp fso = new FileSystemOp();
    private Toast mToastToShow;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lupa_password_sent);
        LupaPasswordSent.MyTouchListener touchListener = new LupaPasswordSent.MyTouchListener();
        ImageView img_back = (ImageView) findViewById(R.id.back);
        img_back.setOnTouchListener(touchListener);

        Button btn_masuk = (Button) findViewById(R.id.tombol_masuk);
        btn_masuk.setOnTouchListener(touchListener);
    }

    public void akhiri() {
        try {
            Intent i = new Intent(LupaPasswordSent.this, MainActivity.class);
            startActivity(i);
            finish();
        }
        catch (Exception e) {
            fso._do_log_debug(e, "akhiri");
        }
    }
      /*
    start subclass
    http://stackoverflow.com/questions/17864143/single-method-to-implement-ontouchlistener-for-multiple-buttons
    */

    public class MyTouchListener implements View.OnTouchListener {
        @Override
        public boolean onTouch(View v, MotionEvent event) {
            try {
                if(v.getId() == R.id.tombol_masuk) {
                    try {
                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(LupaPasswordSent.this, MainActivity.class));
                            }
                        },100);
                    }
                    catch (Exception e) {
                        fso._do_log_debug(e, "ontouch tombol masuk");
                    }
                }
                else if(v.getId() == R.id.back) {
                    Log.e("[+] logging only", "no err ! back clicked");
                    akhiri();
                }
            }
            catch (Exception e) {
                fso._do_log_debug(e, "onTouch");
            }
            return true;
        }
    }
    /* eof subclasses*/
}
