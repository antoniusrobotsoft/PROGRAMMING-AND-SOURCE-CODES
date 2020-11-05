package com.ringlayer.simplestockinventory;

import android.Manifest;
import android.content.Intent;
import android.os.Build;
import android.os.CountDownTimer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.Gravity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileReader;

public class MainActivity extends AppCompatActivity {
    Button in;
    Button out;
    Button go;
    EditText Esearch;
    EditText Edata_stok;
    private Toast mToastToShow;

    public Util util =  new Util(MainActivity.this);
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    void ProcessMain() {
        try {
            String IsiFullFile;
            String[] ParseRest;
            String ViewMe = "No stock data yet";

            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
                util.askForPermission(Manifest.permission.WRITE_EXTERNAL_STORAGE, 1);
                util.askForPermission(Manifest.permission.READ_EXTERNAL_STORAGE, 2);
            }
            util.buat_dir(getResources().getString(R.string.sdir));
            util.createFileInSDCard(getResources().getString(R.string.sfil));
            IsiFullFile  = BacaIsiFile();
            if (IsiFullFile.length() < 3) {
                Log.e("info", "writefile");
                util.writeFile(getResources().getString(R.string.sfil), ViewMe);

            }


            if (IsiFullFile.contains("@@")) {
                ParseRest = util.ParseStock(IsiFullFile);
                ViewMe = util.ChangeParsedIntoBharis(ParseRest);
            }
            Edata_stok = (EditText)findViewById(R.id.data_stok);
            Edata_stok.setText(ViewMe);

        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }
    }

    /*
    * SAMPLE FILE CONTENT TO PARSE :
    * code1@@pencil@@0
    * code2@@book@@2
    */

    private String BacaIsiFile() {
        String IsiFullFile = "";
        try {
            String st;
            int exists = util.check_file_exists(getResources().getString(R.string.sfil));
            if (exists == 1) {
                File file = new File(getResources().getString(R.string.sfil));
                BufferedReader br = new BufferedReader(new FileReader(file));
                while ((st = br.readLine()) != null) {
                    IsiFullFile += st;
                }
            }
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }

        return IsiFullFile;
    }


    @Override
    protected void onStart() {
        super.onStart();
        try {
            try {
                ProcessMain();
            }
            catch (Exception e) {
                Log.e("error", e.toString());
            }

            in = (Button) findViewById(R.id.in);
            in.setOnClickListener(new View.OnClickListener() {
                public void onClick(View v) {
                    In();
                }
            });

            out = (Button) findViewById(R.id.out);
            out.setOnClickListener(new View.OnClickListener() {
                public void onClick(View v) {
                    Out();
                }
            });

            go = (Button) findViewById(R.id.go);
            go.setOnClickListener(new View.OnClickListener() {
                public void onClick(View v) {
                    Go();
                }
            });

        } catch (Exception e) {
            Log.e("error", e.toString());
        }
    }

    private void showToast(String msg_to_display, int second_to_disp) {
        int toastDurationInMilliSeconds = second_to_disp * 1000;
        mToastToShow = Toast.makeText(MainActivity.this, msg_to_display, Toast.LENGTH_LONG);
        mToastToShow.setGravity(Gravity.CENTER_VERTICAL|Gravity.CENTER_HORIZONTAL, 0, 0);
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

    void Go() {
        try {
            Esearch = (EditText) findViewById(R.id.search);
            String kunci = Esearch.getText().toString().toLowerCase().trim();

            if (kunci.length() < 1) {
                showToast("please input product name to search !", 3);
            }
            else {
                showToast("Searching product ... please wait ...", 2);
                String IsiFullFile = BacaIsiFile();

                if (IsiFullFile.indexOf(kunci) == -1) {
                    showToast("product name or code not found !", 4);
                }
                else {
                    String[] ParseRest = util.ParseStock(IsiFullFile);
                    DisplaySearchResult(ParseRest, kunci);
                }
            }
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }
    }

    void DisplaySearchResult(String[] ParseRest, String kunci) {
        try {
            int i;
            String[] parts;
            String ViewMe = "No Data Found !";

            for (i = 0; i < ParseRest.length; i++) {
                if ((ParseRest[i].length() > 1) && (ParseRest[i].contains("@@"))) {
                    parts = ParseRest[i].split("@@");
                    if ( (parts[0].trim().equals(kunci.trim()) ) || (parts[1].trim().equals(kunci.trim())) ) {
                        ViewMe = "Product Code : " + parts[0] + "\n";
                        ViewMe += "Product Name : " + parts[1] + "\n";
                        ViewMe += "Stock : " + parts[2];
                        ViewMe += "\n===============================\n";

                        break;
                    }
                }
            }

            Edata_stok = (EditText)findViewById(R.id.data_stok);
            Edata_stok.setText(ViewMe);

        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }
    }

    void In() {
        try {
            Intent intent = new Intent(MainActivity.this, MasukActivity.class);
            startActivity(intent);
            finish();
        }
        catch (Exception e) {
            Log.e("err", e.toString());
        }
    }

    void Out() {
        try {
            Intent intent = new Intent(MainActivity.this, KeluarActivity.class);
            startActivity(intent);
            finish();
        }
        catch (Exception e) {
            Log.e("err", e.toString());
        }
    }
}
