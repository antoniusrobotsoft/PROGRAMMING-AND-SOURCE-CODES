package com.ringlayer.indotalent;

/*
* created by Antonius Ringlayer
* www.ringlayer.net - www.ringlayer.com
* https://github.com/ringlayer
* */

import android.content.Intent;

import android.os.CountDownTimer;
import android.os.Handler;
import android.os.StrictMode;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Spinner;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.Calendar;

import java.util.List;

public class RegisterRecruiter extends AppCompatActivity {

    private Toast mToastToShow;
    public int sukses = 0;
    SendPostRequest spr = new SendPostRequest();
    FileSystemOp fso = new FileSystemOp();
    RegisterRecruiter.MyTouchListener touchListener = new RegisterRecruiter.MyTouchListener();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);

        setContentView(R.layout.activity_register_recruiter);
        try {
            //listen_userclick();

            set_spinner(R.id.birthplace,R.array.birthplace_arrays);
            set_spinner(R.id.day_recruiter,R.array.day_arrays);
            set_spinner(R.id.month_recruiter,R.array.month_arrays);
            set_spinner(R.id.year_recruiter,R.array.year_arrays);
            set_spinner(R.id.job, R.array.job_arrays);

             /* listen trick by Ringlayer */
            String[] objtype_ar = {"img","but","but","but"};
            int[] idtype_ar = {R.id.back,R.id.upload_foto,R.id.upload_foto_hint,R.id.simpan_recruiter};
            set_listen_to_click(objtype_ar,idtype_ar);


        }
        catch (Exception e) {
            fso._do_log_debug(e, "onCreate");
        }
    }

    //listener trick by Ringlayer
    public void set_listen_to_click(String[] _objtype_ar, int[] _idtype_ar) {
        try {
            int i;
            List<ImageView> img = new ArrayList<ImageView>();
            List<Button> but = new ArrayList<Button>();
            for (i = 0;i < _objtype_ar.length; i++) {
                if (_objtype_ar[i].indexOf("im") != -1) {
                    img.add((ImageView) findViewById(_idtype_ar[i]));
                }
                else if (_objtype_ar[i].indexOf("bu") != -1) {
                    but.add((Button) findViewById(_idtype_ar[i]));
                }
            }
            for (int a = 0; a < img.size(); a++) {
                img.get(a).setOnTouchListener(touchListener);
            }
            for (int b = 0; b < but.size(); b++) {
                but.get(b).setOnTouchListener(touchListener);
            }
        }
        catch (Exception e) {
            fso._do_log_debug(e, "set_listen_to_click");
        }
    }

    /*
   special set_spinner trick by Ringlayer, this method will fill
    ur fvcking spinner  with all required resources
    */
    public void set_spinner(int spinner_uid,  int spinner_array_id) {
        try {
            Spinner spinner = (Spinner) findViewById(spinner_uid);

            String[] opsi = getResources().getStringArray(spinner_array_id);
            ArrayAdapter<String> spinnerArrayAdapter = new ArrayAdapter<String>(
                    this,R.layout.spinner_item,opsi
            );

            spinnerArrayAdapter.setDropDownViewResource(R.layout.spinner_item);
            spinner.setAdapter(spinnerArrayAdapter);
        }
        catch (Exception e) {
            fso._do_log_debug(e, "set_spinner");
        }
    }

    public void akhiri() {
        try{
            Intent i = new Intent(RegisterRecruiter.this, ProfileChooser.class);
            startActivity(i);
            finish();
        }
        catch (Exception e) {
            fso._do_log_debug(e, "akhiri");
        }
    }
    /*
    * modified from http://www.java2s.com/Code/Java/Development-Class/Getcurrentdateyearandmonth.htm
    * */
    public int getcal(int mode) {
        Calendar now = Calendar.getInstance();
        return now.get(mode);
    }
    /*
    taken from https://www.viralandroid.com/2016/01/how-to-closeexit-android-application.html
    */
    public void closeApplication(View view) {
        finish();
        moveTaskToBack(true);
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
    start subclass
    http://stackoverflow.com/questions/17864143/single-method-to-implement-ontouchlistener-for-multiple-buttons
    */

    public class MyTouchListener implements View.OnTouchListener {
        @Override
        public boolean onTouch(View v, MotionEvent event) {
            try {
                switch(v.getId()) {
                    case R.id.back:
                        akhiri();
                        break;
                    case R.id.upload_foto:
                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(RegisterRecruiter.this, activity_foto_recruiter.class));
                            }
                        },100);
                        break;
                    case R.id.upload_foto_hint:
                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(RegisterRecruiter.this, activity_foto_recruiter.class));
                            }
                        },100);
                        break;
                    case R.id.simpan_recruiter:
                        try {
                             /* get spinner val */
                            String day_recruiter,month_recruiter,year_recruiter;
                            String job, birthplace;
                            Spinner sp_day_recruiter, sp_month_recruiter,sp_year_recruiter;
                            Spinner sp_job, sp_birthplace;

                            sp_day_recruiter = (Spinner) findViewById(R.id.day_recruiter);
                            sp_month_recruiter = (Spinner) findViewById(R.id.month_recruiter);
                            sp_year_recruiter = (Spinner) findViewById(R.id.year_recruiter);

                            sp_job = (Spinner) findViewById(R.id.job);
                            sp_birthplace = (Spinner) findViewById(R.id.birthplace);
                            day_recruiter = sp_day_recruiter.getSelectedItem().toString();
                            month_recruiter = sp_month_recruiter.getSelectedItem().toString();
                            year_recruiter = sp_year_recruiter.getSelectedItem().toString();

                            job = sp_job.getSelectedItem().toString();
                            birthplace = sp_birthplace.getSelectedItem().toString();
                            /* eof get spinner val */

                            /* get edittext val*/
                            EditText e_fullname, e_club;
                            EditText e_username, e_email, e_password;
                            EditText e_address,e_phone_no;
                            String fullname, club;
                            String username, email, password;
                            String club_address,phone_no;
                            e_fullname = (EditText) findViewById(R.id.fullname);
                            e_club = (EditText) findViewById(R.id.club);
                            e_username = (EditText) findViewById(R.id.username);
                            e_email = (EditText) findViewById(R.id.email);
                            e_password = (EditText) findViewById(R.id.password);
                            e_address = (EditText) findViewById(R.id.club_address);
                            e_phone_no = (EditText) findViewById(R.id.phone_no);

                            fullname = e_fullname.getText().toString();
                            club =  e_club.getText().toString();
                            username = e_username.getText().toString();
                            email = e_email.getText().toString();
                            password = e_password.getText().toString();
                            club_address = e_address.getText().toString();
                            phone_no = e_phone_no.getText().toString();
                            /* eof get edittext val */


                            String[] key_str = {"mode","usernamex","email","passwordx","club_address","phone_no","day_recruiter","month_recruiter","year_recruiter","job", "birthplace","fullname","club"};
                            String[] val_str = {"recruiter",username,email,password,club_address,phone_no,day_recruiter,month_recruiter,year_recruiter,job, birthplace,fullname, club};
                            String[] butuh_validasi = {"email","usernamex","passwordx"};

                            String res = spr._execute(getResources().getString(R.string.register_url),key_str, val_str, butuh_validasi);
                            if (res.indexOf("sukses")  != -1) {
                                new Handler().postDelayed(new Runnable() {
                                    @Override
                                    public void run() {
                                        startActivity(new Intent(RegisterRecruiter.this, RegisterResult.class));
                                    }
                                }, 300);
                            }
                            else {
                                Toast.makeText(getApplicationContext(),"Registrasi gagal !", Toast.LENGTH_LONG);
                            }
                        }
                        catch (Exception e) {
                            fso._do_log_debug(e, "gagal menyimpan");
                        }
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
