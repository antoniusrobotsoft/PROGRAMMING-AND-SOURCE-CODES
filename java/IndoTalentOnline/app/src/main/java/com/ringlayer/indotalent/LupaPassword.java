package com.ringlayer.indotalent;

/*
* created by Antonius Ringlayer
* www.ringlayer.net - www.ringlayer.com
* https://github.com/ringlayer
* */

import android.content.Intent;

import android.os.CountDownTimer;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;

import android.widget.Toast;



public class LupaPassword extends AppCompatActivity {
    public int sukses = 0;
    FileSystemOp fso = new FileSystemOp();
    SendPostRequest spr = new SendPostRequest();
    private Toast mToastToShow;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lupa_password);
        try {
            listen_userclick();
        }
        catch (Exception e) {
            fso._do_log_debug(e, "onCreate lupa password");
        }
    }
    public void akhiri() {
        try{
            Intent i = new Intent(LupaPassword.this, MainActivity.class);
            startActivity(i);
            finish();
        }
        catch (Exception e) {
            fso._do_log_debug(e, "akhiri");
        }
    }

    public void showToast(String msg_to_display, int second_to_disp) {
        int toastDurationInMilliSeconds = second_to_disp * 1000;
        mToastToShow = Toast.makeText(this, msg_to_display, Toast.LENGTH_LONG);

        CountDownTimer toastCountDown;
        toastCountDown = new CountDownTimer(toastDurationInMilliSeconds, 1000 /*Tick duration*/) {
            public void onTick(long millisUntilFinished) {
                mToastToShow.show();
            }
            public void onFinish() {
                mToastToShow.cancel();
            }
        };

        mToastToShow.show();
        toastCountDown.start();
    }
    /*
    modified from https://www.viralandroid.com/2016/01/how-to-closeexit-android-application.html
    */
    public void closeApplication(View view) {
        try{
            Log.e("[+] logging only", "no err ! finish clicked");
            finish();
            moveTaskToBack(true);
        }
        catch (Exception e) {
            fso._do_log_debug(e, "closeApplication");
        }
    }

    protected void listen_userclick() {
        try {
            LupaPassword.MyTouchListener touchListener = new LupaPassword.MyTouchListener();
            Button btn_kirim = (Button) findViewById(R.id.tombol_kirim);
            ImageView img_back = (ImageView) findViewById(R.id.back);
            btn_kirim.setOnTouchListener(touchListener);
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

    public class MyTouchListener implements View.OnTouchListener {
        LupaPassword lp = new LupaPassword();
        protected void proc_kirim_pass() {
            try {
                 /* get edittext val*/
                EditText e_email;
                String  email;
                e_email = (EditText) findViewById(R.id.email);
                email = e_email.getText().toString();
                /* eof get edittext val */

                if (email.trim().length() < 2) {
                    Toast.makeText(getApplicationContext(),"Email harus diisi !", Toast.LENGTH_LONG);
                }
                else {


                    String[] key_str = {"email"};
                    String[] val_str = {email};
                    String[] butuh_validasi = {"email"};

                    String res = spr._execute(getResources().getString(R.string.fp_url),key_str, val_str, butuh_validasi);


                    if (res.indexOf("sukses") != -1) {
                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(LupaPassword.this, LupaPasswordSent.class));
                            }
                        }, 500);
                    }
                    else {
                        Toast.makeText(getApplicationContext(),"gagal ! email tidak terdaftar atau koneksi internet bermasalah !", Toast.LENGTH_LONG);
                    }
                }
            }
            catch(Exception e) {
                fso._do_log_debug(e, "proc_kirim_pass");
            }
        }

        @Override
        public boolean onTouch(View v, MotionEvent event) {
            try {
                if(v.getId() == R.id.tombol_kirim) {
                    try {
                        new Handler().postDelayed(new Runnable() {
                                @Override
                                public void run() {
                                    proc_kirim_pass();
                                }
                            },100);
                        }
                        catch (Exception e) {
                            fso._do_log_debug(e, "klik tombol_kirim");
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
