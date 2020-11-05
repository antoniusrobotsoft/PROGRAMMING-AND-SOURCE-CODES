package com.ringlayer.indotalent;

/*
* created by Antonius Ringlayer
* www.ringlayer.net - www.ringlayer.com
* https://github.com/ringlayer
* */

import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.view.View.OnTouchListener;
import android.view.MotionEvent;
import android.widget.Button;
import android.widget.ImageView;

public class ProfileChooser extends AppCompatActivity {
    final FileSystemOp fso = new FileSystemOp();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_profile_chooser);
        try {
            listen_userclick();
        }
        catch (Exception e) {
            fso._do_log_debug(e, "on create profile chooser");
        }

    }

    public void akhiri() {
        try{
            Intent i = new Intent(ProfileChooser.this, MainActivity.class);
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

    protected void listen_userclick() {
        try {
            MyTouchListener touchListener = new MyTouchListener();
            Button btn_register_recruiter = (Button) findViewById(R.id.tombol_register_recruiter);
            Button btn_register_player = (Button) findViewById(R.id.tombol_register_player);

            ImageView img_back = (ImageView) findViewById(R.id.back);

            btn_register_recruiter.setOnTouchListener(touchListener);
            btn_register_player.setOnTouchListener(touchListener);

            img_back.setOnTouchListener(touchListener);
        }
        catch (Exception e) {
            fso._do_log_debug(e, "listen_userclick");
        }
    }

    /*
    start subclass
    http://stackoverflow.com/questions/17864143/single-method-to-implement-ontouchlistener-for-multiple-buttons
    */

    public class MyTouchListener implements OnTouchListener {
        @Override
        public boolean onTouch(View v, MotionEvent event) {
            try {
                switch(v.getId()) {
                    case R.id.tombol_register_recruiter:
                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(ProfileChooser.this,RegisterRecruiter.class));
                            }
                        },100);
                        break;
                    case R.id.tombol_register_player:
                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(ProfileChooser.this,RegisterPlayer.class));
                            }
                        },100);
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
