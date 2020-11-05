package com.ringlayer.indotalent;

/*
* created by Antonius Ringlayer
* www.ringlayer.net - www.ringlayer.com
* https://github.com/ringlayer
* */

import android.content.Context;
import android.content.Intent;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;

import android.os.CountDownTimer;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;


public class MainActivity extends AppCompatActivity {
    SendPostRequest spr = new SendPostRequest();
    FileSystemOp fso = new FileSystemOp();
    private Toast mToastToShow;
    int sukses = 0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        try {
            super.onCreate(savedInstanceState);
            setContentView(R.layout.activity_main);

            Context context = this.getApplicationContext();

            /*
            ConnectivityManager taken from https://developer.android.com/training/monitoring-device-state/connectivity-monitoring#java
            */
            ConnectivityManager cm =
                    (ConnectivityManager)getSystemService(Context.CONNECTIVITY_SERVICE);

            NetworkInfo activeNetwork = cm.getActiveNetworkInfo();
            if (activeNetwork != null) {
                listen_userclick();
            }
            else {
                showToast("Sorry not connected to internet ! can not continue !", 1000);
            }
        }
        catch (Exception e) {
            fso._do_log_debug(e, "onCreate main activity");
        }
    }


    /*
    taken from https://www.viralandroid.com/2016/01/how-to-closeexit-android-application.html
    * */
    public void closeApplication(View view) {
        finish();
        moveTaskToBack(true);
    }

    protected void listen_userclick() {
        try {
            MainActivity.MyTouchListener touchListener = new MainActivity.MyTouchListener();
            Button btn_register = (Button) findViewById(R.id.tombol_register);
            Button btn_login = (Button) findViewById(R.id.tombol_login);
            TextView txt_forgot = (TextView) findViewById(R.id.link_forget);

            btn_register.setOnTouchListener(touchListener);
            btn_login.setOnTouchListener(touchListener);
            txt_forgot.setOnTouchListener(touchListener);
        }
        catch (Exception e) {
            fso._do_log_debug(e, "listen_userclick");
        }
    }

    /* modified from
    * https://blog.cindypotvin.com/toast-specific-duration-android/
    * */
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
    start subclass
    http://stackoverflow.com/questions/17864143/single-method-to-implement-ontouchlistener-for-multiple-buttons
    */

    public class MyTouchListener implements View.OnTouchListener {
        protected void proc_login() {
            try {

                /* get edittext val*/
                EditText e_username;
                EditText e_password;
                String  username, password;
                e_username = (EditText) findViewById(R.id.username);
                e_password = (EditText) findViewById(R.id.password);
                username = e_username.getText().toString();
                password = e_password.getText().toString();
                /* eof get edittext val */

                if ( (username.trim().length() < 2) || (password.trim().length() < 2) ) {
                    Toast.makeText(getApplicationContext(),"Username atau password harus diisi !", Toast.LENGTH_LONG);
                }
                else {

                    String[] key_str = {"usernamex", "passwordx"};
                    String[] val_str = {username, password};
                    String[] butuh_validasi = {"usernamex", "passwordx"};

                    String login_res = spr._execute(getResources().getString(R.string.login_url),key_str, val_str, butuh_validasi);
                    if (login_res.indexOf("sukses") != -1) {
                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(MainActivity.this, MemberPage.class));
                            }
                        },500);
                    }
                    else {
                        showToast("Username atau password salah !", 3);
                        //Toast.makeText(getApplicationContext(),"Username atau password salah !", Toast.LENGTH_LONG);
                    }

                }
            }
            catch(Exception e) {
                fso._do_log_debug(e, "proc_login");
            }
        }

        protected void proc_lupa() {
            try {
                startActivity(new Intent(MainActivity.this,LupaPassword.class));
            }
            catch (Exception e) {

            }
        }

        @Override
        public boolean onTouch(View v, MotionEvent event) {
            try {
                switch(v.getId()) {
                    case R.id.tombol_login:
                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                proc_login();
                            }
                        },100);
                        break;
                    case R.id.link_forget:
                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                proc_lupa();
                            }
                        },100);
                        break;
                    case R.id.tombol_register:
                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(MainActivity.this,ProfileChooser.class));
                            }
                        },100);
                        break;
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
