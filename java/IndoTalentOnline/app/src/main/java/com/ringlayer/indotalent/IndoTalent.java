package com.ringlayer.indotalent;

import android.content.Intent;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class IndoTalent extends AppCompatActivity {
    FileSystemOp fso = new FileSystemOp();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_indo_talent);
        fso.prepare_log_dir();
        fso.createFileInSDCard("/sdcard/indotalent/indotalent.log");
        fso._syslog("/sdcard/indotalent/indotalent.log", "_init_");
        new Handler().postDelayed(new Runnable() {
            @Override
            public void run() {
                startActivity(new Intent(IndoTalent.this,FullscreenActivity.class));
            }
        },100);
    }
}
