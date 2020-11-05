package com.ringlayer.blockrobot;

/**
 * Created by ringlayer on 28/06/18.
 */

/*
Source code modified from
https://dev.to/hitman666/how-to-make-a-native-android-app-that-can-block-phone-calls--4e15
*/

import android.app.ActivityManager;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.provider.CallLog;
import android.telephony.TelephonyManager;
import android.util.Log;
import java.lang.reflect.Method;
import com.android.internal.telephony.ITelephony;

public class IncomingCallReceiver extends BroadcastReceiver {

    /* taken from https://stackoverflow.com/questions/22511018/check-if-service-is-running-from-a-broadcast-receiver */
    private boolean isMyServiceRunning(Context context) {
        ActivityManager manager = (ActivityManager) context.getSystemService(Context.ACTIVITY_SERVICE);
        for (ActivityManager.RunningServiceInfo service : manager.getRunningServices(Integer.MAX_VALUE)) {
            if (EternalService.class.getName().equals(service.service.getClassName())) {
                return true;
            }
        }

        return false;
    }

    @Override
    public void onReceive(Context context, Intent intent) {
        ITelephony telephonyService;
        try {

            boolean EternalRun = isMyServiceRunning(context);
            if (EternalRun == false) {
                context.startService(new Intent(context, EternalService.class));
            }
            String[] blocked_fingerprints = {"10088","1344","1290413"};
            if (intent.getAction().equalsIgnoreCase(Intent.ACTION_BOOT_COMPLETED)) {
                Intent serviceIntent = new Intent(context, EternalService.class);
                context.startService(serviceIntent);
            }
            String state = intent.getStringExtra(TelephonyManager.EXTRA_STATE);
            String number = intent.getExtras().getString(TelephonyManager.EXTRA_INCOMING_NUMBER);

            if(state.equalsIgnoreCase(TelephonyManager.EXTRA_STATE_RINGING)){
                TelephonyManager tm = (TelephonyManager) context.getSystemService(Context.TELEPHONY_SERVICE);
                try {
                    Method m = tm.getClass().getDeclaredMethod("getITelephony");

                    m.setAccessible(true);
                    telephonyService = (ITelephony) m.invoke(tm);

                    if ((number != null)) {
                        if (number.length() < 12) {
                            telephonyService.silenceRinger();
                            telephonyService.endCall();
                            Uri CALLLOG_URI = Uri.parse("content://call_log/calls");
                            context.getContentResolver().delete(CALLLOG_URI, CallLog.Calls.NUMBER +"=?",new String[]{number});
                        }
                        else {
                            for (int i = 0 ; i < blocked_fingerprints.length; i ++ ) {
                                if (number.indexOf(blocked_fingerprints[i]) > -1) {
                                    telephonyService.silenceRinger();
                                    telephonyService.endCall();
                                    Uri CALLLOG_URI = Uri.parse("content://call_log/calls");
                                    context.getContentResolver().delete(CALLLOG_URI, CallLog.Calls.NUMBER +"=?",new String[]{number});
                                }
                            }
                        }
                    }

                } catch (Exception e) {
                   Log.e("[-]", e.toString());
                }
            }

        } catch (Exception e) {
            Log.e("[+]", e.toString());
        }
    }
}
