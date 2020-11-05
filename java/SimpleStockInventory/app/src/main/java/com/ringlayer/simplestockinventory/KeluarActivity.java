package com.ringlayer.simplestockinventory;

import android.content.Intent;
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

public class KeluarActivity extends AppCompatActivity {
    public Util util =  new Util(KeluarActivity.this);

    Button out_cancel;
    Button out_save;

    EditText keluar_kode;
    EditText keluar_name;
    EditText keluar_amount;

    private Toast mToastToShow;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_keluar);
    }

    @Override
    protected void onStart() {
        super.onStart();
        try {
            out_cancel = (Button) findViewById(R.id.out_cancel);
            out_cancel.setOnClickListener(new View.OnClickListener() {
                public void onClick(View v) {
                    Back();
                }
            });

            out_save = (Button) findViewById(R.id.out_save);
            out_save.setOnClickListener(new View.OnClickListener() {
                public void onClick(View v) {
                    Save();
                }
            });
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }
    }

    private void Back() {
        try {
            Intent intent = new Intent(KeluarActivity.this, MainActivity.class);
            startActivity(intent);
            finish();
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }
    }


    protected void Save() {
        try {
            boolean valid = false;
            keluar_kode = (EditText) findViewById(R.id.keluar_kode);
            keluar_name = (EditText) findViewById(R.id.keluar_name);
            keluar_amount = (EditText) findViewById(R.id.keluar_amount);

            String kode = keluar_kode.getText().toString().toLowerCase().trim();
            String name = keluar_name.getText().toString().toLowerCase().trim();
            String amount = keluar_amount.getText().toString().toLowerCase().trim();
            valid = util.ValidateCodeNameAmount(name, amount);
            if (valid) {
                String IsiFullFile = BacaIsiFile();
                String[] ParseRest = util.ParseStock(IsiFullFile);

                /* check whether code or name exists */
                if ((IsiFullFile.indexOf(kode) == -1) && (IsiFullFile.indexOf(name) == -1)) {
                    showToast("product name or code not found ! please use stock-in button to input product before stock-out", 4);
                }
                else {
                    UpdateProduct(kode, name, amount, ParseRest);
                }
            }
            else {
                showToast("product name and amount must be filled", 4);
            }
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }
    }

    private void UpdateProduct(String kode, String name, String amount, String[] ParseRest) {
        try {
            int NewAmount = 0;
            int i;
            String[] parts;
            String NewFullFile = "";

            for (i = 0; i < ParseRest.length; i++) {
                if ((ParseRest[i].length() > 1) && (ParseRest[i].contains("@@"))) {
                    parts = ParseRest[i].split("@@");
                   /* do code or name match our criteria ? */
                    if ( (parts[0].trim().equals(kode.trim()) ) && (parts[1].trim().equals(name.trim())) ) {
                        NewAmount = RetStockAmount(parts, amount);
                        NewFullFile += kode + "@@" + name + "@@" + String.valueOf(NewAmount) + "_____";
                    }
                   /* nope ? */
                    else {
                        NewFullFile += parts[0] + "@@" + parts[1] + "@@" + parts[2] + "_____";
                    }
                }
            }

            util.writeFile(getResources().getString(R.string.sfil), NewFullFile);
            showToast("stock data updated !", 4);


        }
        catch (Exception e) {
            Log.e("error",e.toString());
        }
    }

    private int RetStockAmount(String[] parts, String GivenAmount) {
        int OrigAmount = 0;
        int NewAmount = 0;

        try {
            OrigAmount = Integer.parseInt(parts[2]);
            int GivenAmountInt = Integer.parseInt(GivenAmount);
            if (GivenAmountInt > OrigAmount) {
                showToast("Current Stock is Smaller than out ! Operation Failed !", 4);
            }
            else {
                NewAmount = OrigAmount - GivenAmountInt;
            }
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }
        Log.e("info", "got new amount : " + Integer.toString(NewAmount));

        return NewAmount;
    }


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

    private void showToast(String msg_to_display, int second_to_disp) {
        int toastDurationInMilliSeconds = second_to_disp * 1000;
        mToastToShow = Toast.makeText(KeluarActivity.this, msg_to_display, Toast.LENGTH_LONG);
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
}
