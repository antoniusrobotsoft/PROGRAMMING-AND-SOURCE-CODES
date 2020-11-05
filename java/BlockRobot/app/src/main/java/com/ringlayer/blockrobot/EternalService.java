package com.ringlayer.blockrobot;

/* a bit modification from from https://www.dropbox.com/s/nn0vsnfqmxgtham/UnstoppableService.zip */
import android.app.Notification;
import android.app.PendingIntent;
import android.app.Service;
import java.util.Timer;
import java.util.TimerTask;


import android.content.Intent;
import android.content.IntentFilter;
import android.os.IBinder;

import android.support.v4.app.NotificationCompat;
import android.telephony.PhoneStateListener;
import android.telephony.TelephonyManager;
import android.util.Log;



/**
 * Created by ringlayer on 28/06/18.
 */

public class EternalService extends Service  {


    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }

    @Override
    public void onCreate() {
        super.onCreate();


    }

    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
        Intent notificationIntent = new Intent(this, MainActivity.class);

        PendingIntent pendingIntent = PendingIntent.getActivity(this, 0,
                notificationIntent, 0);

        Notification notification = new NotificationCompat.Builder(this)
                .setContentIntent(pendingIntent).build();
        startForeground(1337, notification);

        registerReceiver(new IncomingCallReceiver(),  new IntentFilter(TelephonyManager.ACTION_PHONE_STATE_CHANGED));
        return START_STICKY;
    }

    private Timer mTimer;

    TimerTask timerTask = new TimerTask() {

        @Override
        public void run() {
            Log.i("[-]", "run");
        }
    };

    public void onDestroy() {
        try {
            mTimer.cancel();
            timerTask.cancel();
            Intent launchIntent = getPackageManager().getLaunchIntentForPackage("com.ringlayer.blockrobot");
            if (launchIntent != null) {
                startActivity(launchIntent);//null pointer check in case package name was not found
            }
            registerReceiver(new IncomingCallReceiver(),  new IntentFilter(TelephonyManager.ACTION_PHONE_STATE_CHANGED));

        } catch (Exception e) {
            Log.i("[-]", "on destroy");
        }

    }


}
