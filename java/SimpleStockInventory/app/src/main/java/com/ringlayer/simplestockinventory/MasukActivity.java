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

public class MasukActivity extends AppCompatActivity {
    Button in_cancel;
    Button in_save;

    EditText masuk_kode;
    EditText masuk_name;
    EditText masuk_amount;
    public Util util =  new Util(MasukActivity.this);

    private Toast mToastToShow;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_masuk);
    }

    @Override
    protected void onStart() {
        super.onStart();
        try {
            in_cancel = (Button) findViewById(R.id.in_cancel);
            in_cancel.setOnClickListener(new View.OnClickListener() {
                public void onClick(View v) {
                    Back();
                }
            });

            in_save = (Button) findViewById(R.id.in_save);
            in_save.setOnClickListener(new View.OnClickListener() {
                public void onClick(View v) {
                    Save();
                }
            });

        } catch (Exception e) {
            Log.e("error", e.toString());
        }
    }

    private void Back() {
        try {
            Intent intent = new Intent(MasukActivity.this, MainActivity.class);
            startActivity(intent);
            finish();
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }
    }

    protected void Save() {
        try {
            int i;
            String full_data = "";
            boolean valid = false;
            masuk_kode = (EditText) findViewById(R.id.masuk_kode);
            masuk_name = (EditText) findViewById(R.id.masuk_name);
            masuk_amount = (EditText) findViewById(R.id.masuk_amount);

            String kode = masuk_kode.getText().toString().toLowerCase().trim();
            String name = masuk_name.getText().toString().toLowerCase().trim();
            String amount = masuk_amount.getText().toString().toLowerCase().trim();

            valid = util.ValidateCodeNameAmount(name, amount);
            if (valid) {
                String IsiFullFile = BacaIsiFile();
                String[] ParseRest = util.ParseStock(IsiFullFile);
                /* check whether code or name exists */
                if ((IsiFullFile.contains(kode)) && (IsiFullFile.contains(name))) {
                    Log.e("info", "UpdateProduct called");
                    UpdateProduct(kode, name, amount, ParseRest);
                }
                else {
                    if (IsiFullFile.contains("No stock data")) {
                        Log.e("info","CleanUpStockData called");
                        CleanUpStockData();
                    }
                    Log.e("info", "AppendNewProduct called");
                    AppendNewProduct(kode, name, amount);
                }
            }
            else {
                showToast("product name and amount must be filled, minimum amount is 1", 4);
            }
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }
    }

    private int RetStockAmount(String[] parts, String GivenAmount) {
        int OrigAmount = 0;
        int NewAmount = 0;

        try {
            Log.e("info", "parts2 at retstockamount : " + parts[2]);
            OrigAmount = Integer.parseInt(parts[2]);
            int GivenAmountInt = Integer.parseInt(GivenAmount);
            NewAmount = OrigAmount + GivenAmountInt;
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }

        return NewAmount;
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
                   /*
                   Log.e("info", "parts[0]:" + parts[0]);
                   Log.e("info", "parts[1]:" + parts[1]);
                   Log.e("info", "parts[2]:" + parts[2]);
                   Log.e("info", "compare to kode : " + kode + " - name : " + name);
                   */
                   if ( (parts[0].trim().equals(kode.trim())) && (parts[1].trim().equals(name.trim())) ) {
                       Log.e("info", "got match kode : " + kode + " match name : " + name);
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


    private void AppendNewProduct(String kode, String name, String amount) {
        try {
            String full_data = kode + "@@" + name + "@@" + amount + "_____";
            util.append_file(getResources().getString(R.string.sfil), full_data);
            showToast("new product added !", 4);
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }
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
        mToastToShow = Toast.makeText(MasukActivity.this, msg_to_display, Toast.LENGTH_LONG);
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

    private void CleanUpStockData() {
        try {
            util.writeFile(getResources().getString(R.string.sfil), "");
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }
    }
}
