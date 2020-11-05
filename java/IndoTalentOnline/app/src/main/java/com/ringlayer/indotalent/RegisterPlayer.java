package com.ringlayer.indotalent;

/*
* created by Antonius Ringlayer
* www.ringlayer.net - www.ringlayer.com
* https://github.com/ringlayer
* */

import android.app.Activity;
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



public class RegisterPlayer extends AppCompatActivity {
    SendPostRequest spr = new SendPostRequest();
    private Toast mToastToShow;
    public int sukses = 0;
    FileSystemOp fso = new FileSystemOp();
    RegisterPlayer.MyTouchListener touchListener = new RegisterPlayer.MyTouchListener();




    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);

        setContentView(R.layout.activity_register_player);
        try {

            set_spinner(R.id.birthplace,R.array.birthplace_arrays);
            set_spinner(R.id.day_player,R.array.day_arrays);
            set_spinner(R.id.month_player,R.array.month_arrays);
            set_spinner(R.id.year_player,R.array.year_arrays);
            set_spinner(R.id.favourites_position, R.array.favourite_position_arrays);

            /* Ringlayer's Special Ultimate
            restore data trick, sorry not  so good in java, probably there is better a method */



            /* listen trick by Ringlayer */
            String[] _objtype_ar = {"img","but","but","but","but","but","but","but"};
            int[] _idtype_ar = {R.id.back,R.id.upload_foto,R.id.upload_foto_hint,R.id.upload_galeri_trophy,R.id.upload_galeri_trophy_hint,R.id.upload_talent_video_link, R.id.upload_talent_video_link_hint,R.id.simpan_player};
            set_listen_to_click(_objtype_ar,_idtype_ar);
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





    /*

    public void set_spinner_year(int spinner_uid) {
        try {
            Spinner spinner_year = (Spinner) findViewById(spinner_uid);
            int i = getcal(Calendar.YEAR);
            ArrayList<String> opsi = new ArrayList<String>();
            opsi.add("year");
            while (i >= 1960) {
                opsi.add(String.valueOf(i));
                i--;
            }
            ArrayAdapter<String> spinnerArrayAdapter = new ArrayAdapter<String>(
                    this,R.layout.spinner_item, opsi
            );
            spinnerArrayAdapter.setDropDownViewResource(R.layout.spinner_item);
            spinner_year.setSelection(-1);
            spinner_year.setAdapter(spinnerArrayAdapter);

        }
        catch (Exception e) {
            fso._do_log_debug(e, "set_spinner");
        }
    }

    public void set_spinner_md(int spinner_uid, String month_or_day_baby) {
        try {
            Spinner spinner_md = (Spinner) findViewById(spinner_uid);

            ArrayList<String> opsi = new ArrayList<String>();
            opsi.add(month_or_day_baby);
            if (month_or_day_baby == "day") {
                int _day = 1;
                while (_day <= 31) {
                    opsi.add(String.valueOf(_day));
                    _day++;
                }
            }
            else if (month_or_day_baby == "month") {
                String bulan = "?";
                int _month = 1;
                while (_month <= 12) {
                    switch (_month) {
                        case 1:
                            bulan = "January";
                            break;
                        case 2:
                            bulan = "February";
                            break;
                        case 3:
                            bulan = "March";
                            break;
                        case 4:
                            bulan  = "April";
                            break;
                        case 5:
                            bulan = "May";
                            break;
                        case 6:
                            bulan = "June";
                            break;
                        case 7:
                            bulan = "July";
                            break;
                        case 8:
                            bulan = "August";
                            break;
                        case 9:
                            bulan = "September";
                            break;
                        case 10:
                            bulan = "October";
                            break;
                        case 11:
                            bulan = "November";
                            break;
                        case 12:
                            bulan = "December";
                            break;
                    }
                    opsi.add(bulan);
                    _month++;
                }
            }
            ArrayAdapter<String> spinnerArrayAdapter = new ArrayAdapter<String>(
                    this,R.layout.spinner_item, opsi
            );
            spinnerArrayAdapter.setDropDownViewResource(R.layout.spinner_item);
            spinner_md.setAdapter(spinnerArrayAdapter);
            spinner_md.setSelection(((ArrayAdapter<String>)spinner_md.getAdapter()).getPosition(month_or_day_baby));
        }
        catch (Exception e) {
            fso._do_log_debug(e, "set_spinner");
        }
    }
    */
    public void akhiri() {
        try{
            Intent i = new Intent(RegisterPlayer.this, ProfileChooser.class);
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
    * modified from http://www.java2s.com/Code/Java/Development-Class/Getcurrentdateyearandmonth.htm
    * */
    public int getcal(int mode) {
        Calendar now = Calendar.getInstance();
        return now.get(mode);
    }


    /*
    start subclass
    modified from
    http://stackoverflow.com/questions/17864143/single-method-to-implement-ontouchlistener-for-multiple-buttons
    */

    public class MyTouchListener implements View.OnTouchListener {

        @Override
        /*
        * int[] _idtype_ar = {R.id.back,R.id.upload_foto,R.id.upload_foto_hint,
        * R.id.upload_galeri_trophy,R.id.upload_galeri_trophy_hint,
        * R.id.upload_talent_video_link, R.id.upload_talent_video_link_hint};
        * */


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
                                startActivity(new Intent(RegisterPlayer.this, activity_foto_player.class));
                            }
                        },100);
                        break;
                    case R.id.upload_foto_hint:

                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(RegisterPlayer.this, activity_foto_player.class));
                            }
                        },100);
                        break;
                    case R.id.upload_galeri_trophy:

                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(RegisterPlayer.this, activity_galeri_player.class));
                            }
                        },100);
                        break;
                    case R.id.upload_galeri_trophy_hint:

                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(RegisterPlayer.this, activity_galeri_player.class));
                            }
                        },100);
                        break;
                    case R.id.upload_talent_video_link:

                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(RegisterPlayer.this, activity_link_player.class));
                            }
                        },100);
                        break;
                    case R.id.upload_talent_video_link_hint:

                        new Handler().postDelayed(new Runnable() {
                            @Override
                            public void run() {
                                startActivity(new Intent(RegisterPlayer.this, activity_link_player.class));
                            }
                        },100);
                        break;
                    case R.id.simpan_player:
                        try {

                            /* get spinner val */
                            String day_player,month_player,year_player;
                            String favourites_position, birthplace;
                            Spinner sp_day_player, sp_month_player,sp_year_player;
                            Spinner sp_favourites_position, sp_birthplace;

                            sp_day_player = (Spinner) findViewById(R.id.day_player);
                            sp_month_player = (Spinner) findViewById(R.id.month_player);
                            sp_year_player = (Spinner) findViewById(R.id.year_player);

                            sp_favourites_position = (Spinner) findViewById(R.id.favourites_position);
                            sp_birthplace = (Spinner) findViewById(R.id.birthplace);

                            day_player = sp_day_player.getSelectedItem().toString();
                            month_player = sp_month_player.getSelectedItem().toString();
                            year_player = sp_year_player.getSelectedItem().toString();

                            favourites_position = sp_favourites_position.getSelectedItem().toString();
                            birthplace = sp_birthplace.getSelectedItem().toString();
                            /* eof get spinner val */

                            /* get edittext val*/
                            EditText e_username, e_email, e_password;
                            EditText e_address,e_phone_no,e_fullname;
                            String username, email, password;
                            String address,phone_no,fullname;

                            e_username = (EditText) findViewById(R.id.username);
                            e_fullname = (EditText) findViewById(R.id.fullname);
                            e_email = (EditText) findViewById(R.id.email);
                            e_password = (EditText) findViewById(R.id.password);
                            e_address = (EditText) findViewById(R.id.address);
                            e_phone_no = (EditText) findViewById(R.id.phone_no);

                            username = e_username.getText().toString();
                            fullname = e_fullname.getText().toString();
                            email = e_email.getText().toString();
                            password = e_password.getText().toString();
                            address = e_address.getText().toString();
                            phone_no = e_phone_no.getText().toString();
                             /* eof get edittext val */


                            String[] key_str = {"mode","usernamex","email","passwordx","address","phone_no","day_player","month_player","year_player","favourites_position", "birthplace","fullname"};
                            String[] val_str = {"player",username,email,password,address,phone_no,day_player,month_player,year_player,favourites_position, birthplace,fullname};
                            String[] butuh_validasi = {"email","usernamex","passwordx"};

                            String res = spr._execute(getResources().getString(R.string.register_url),key_str, val_str, butuh_validasi);

                            if (res.indexOf("sukses") != -1) {
                                new Handler().postDelayed(new Runnable() {
                                    @Override
                                    public void run() {
                                        startActivity(new Intent(RegisterPlayer.this, RegisterResult.class));
                                    }
                                }, 500);
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
