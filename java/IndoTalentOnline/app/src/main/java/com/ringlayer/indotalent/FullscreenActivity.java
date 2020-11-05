package com.ringlayer.indotalent;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.os.Handler;

import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.ImageView;


public class FullscreenActivity extends AppCompatActivity {
    Animation animation ;
    ImageView imageView ;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_fullscreen);
        imageView = (ImageView)findViewById(R.id.splash);

        animation = AnimationUtils.loadAnimation(FullscreenActivity.this, R.anim.fade_in);
        imageView.setAnimation(animation);
        new Handler().postDelayed(new Runnable() {
            @Override
            public void run() {
                startActivity(new Intent(FullscreenActivity.this,MainActivity.class));
            }
        },5000);
        /*
        new Handler().postDelayed(new Runnable() {
            @Override
            public void run() {
                startActivity(new Intent(FullscreenActivity.this,activity_foto_player.class));
            }
        },5000);
        */
    }
}
