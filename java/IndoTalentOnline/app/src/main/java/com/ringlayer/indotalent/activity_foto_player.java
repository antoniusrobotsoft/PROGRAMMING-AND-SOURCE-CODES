package com.ringlayer.indotalent;

import android.app.Activity;
import android.app.TaskStackBuilder;
import android.content.ActivityNotFoundException;
import android.content.Intent;

import android.net.Uri;
import android.os.Build;
import android.support.v4.app.NavUtils;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.MotionEvent;
import android.view.View;
import android.webkit.ValueCallback;
import android.webkit.WebChromeClient;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.ImageView;
import android.widget.Toast;

public class activity_foto_player extends AppCompatActivity {
    final Activity activity = this;
    final FileSystemOp fso = new FileSystemOp();

    /* webview trick from https://stackoverflow.com/questions/5907369/file-upload-in-webview */
    static WebView webView;
    private ValueCallback<Uri> mUploadMessage;
    public ValueCallback<Uri[]> uploadMessage;
    public static final int REQUEST_SELECT_FILE = 100;
    private final static int FILECHOOSER_RESULTCODE = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_foto_player);

        try {
            listen_userclick();
            String url = "";

            //ScrollView scrollfvck = (ScrollView) findViewById(R.id.scrollfvck);

            webView = (WebView) findViewById(R.id.player_foto);

            /* webview trick from https://stackoverflow.com/questions/5907369/file-upload-in-webview */
            WebSettings mWebSettings = webView.getSettings();
            mWebSettings.setJavaScriptEnabled(true);
            mWebSettings.setSupportZoom(false);
            mWebSettings.setAllowFileAccess(true);
            mWebSettings.setAllowFileAccess(true);
            mWebSettings.setAllowContentAccess(true);


            webView.setWebChromeClient(new WebChromeClient()
            {
                protected void openFileChooser(ValueCallback uploadMsg, String acceptType)
                {
                    try {
                        mUploadMessage = uploadMsg;
                        Intent i = new Intent(Intent.ACTION_GET_CONTENT);
                        i.addCategory(Intent.CATEGORY_OPENABLE);
                        i.setType("image/*");
                        startActivityForResult(Intent.createChooser(i, "File Browser"), FILECHOOSER_RESULTCODE);

                    }
                    catch (Exception e) {
                        Log.e("[-] error", e.toString());
                    }
                }


                // For Lollipop 5.0+ Devices
                public boolean onShowFileChooser(WebView mWebView, ValueCallback<Uri[]> filePathCallback, WebChromeClient.FileChooserParams fileChooserParams)
                {
                    if (uploadMessage != null) {
                        uploadMessage.onReceiveValue(null);
                        uploadMessage = null;
                    }

                    uploadMessage = filePathCallback;

                    Intent intent = fileChooserParams.createIntent();
                    try
                    {
                        startActivityForResult(intent, REQUEST_SELECT_FILE);
                    } catch (ActivityNotFoundException e)
                    {
                        uploadMessage = null;
                        Toast.makeText(getApplicationContext(), "Cannot Open File Chooser", Toast.LENGTH_LONG).show();
                        return false;
                    }
                    return true;
                }

                //For Android 4.1 only
                protected void openFileChooser(ValueCallback<Uri> uploadMsg, String acceptType, String capture)
                {
                    try {
                        mUploadMessage = uploadMsg;
                        Intent intent = new Intent(Intent.ACTION_GET_CONTENT);
                        intent.addCategory(Intent.CATEGORY_OPENABLE);
                        intent.setType("image/*");
                        startActivityForResult(Intent.createChooser(intent, "File Browser"), FILECHOOSER_RESULTCODE);

                    }
                    catch (Exception e) {
                        Log.e("[-] error", e.toString());
                    }
                }

                protected void openFileChooser(ValueCallback<Uri> uploadMsg)
                {
                    try {
                        mUploadMessage = uploadMsg;
                        Intent i = new Intent(Intent.ACTION_GET_CONTENT);
                        i.addCategory(Intent.CATEGORY_OPENABLE);
                        i.setType("image/*");
                        startActivityForResult(Intent.createChooser(i, "File Chooser"), FILECHOOSER_RESULTCODE);
                    }
                    catch (Exception e) {
                        Log.e("[-] error", e.toString());
                    }
                 }
              });



            webView.setWebViewClient(new WebViewClient() {
            /*
            @Override
            public void onReceivedError(WebView view, int errorCode, String description, String failingUrl)
            {

            }
            */

                @Override
                public boolean shouldOverrideUrlLoading(WebView view, String url)
                {
                    view.loadUrl(url);
                    return true;
                }
            });

            webView.clearCache(true);

            url = getResources().getString(R.string.register_upload_player_foto);
            webView.loadUrl(url);

            //scrollfvck.scrollTo(0,0);
        }
        catch (Exception e) {
            fso._do_log_debug(e, "onCreate foto player");
        }
    }

    protected void listen_userclick() {
        try {
            MyTouchListener touchListener = new MyTouchListener();
            ImageView img_back = (ImageView) findViewById(R.id.back);
            img_back.setOnTouchListener(touchListener);
            ImageView img_close = (ImageView) findViewById(R.id.close);
            img_close.setOnTouchListener(touchListener);
        }
        catch (Exception e){
            fso._do_log_debug(e, "listen_userclick");
        }
    }

    /* taken from https://stackoverflow.com/questions/5907369/file-upload-in-webview */
    @Override
    public void onActivityResult(int requestCode, int resultCode, Intent intent)
    {
        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP)
        {
            if (requestCode == REQUEST_SELECT_FILE)
            {
                if (uploadMessage == null)
                    return;
                uploadMessage.onReceiveValue(WebChromeClient.FileChooserParams.parseResult(resultCode, intent));
                uploadMessage = null;
            }
        }
        else if (requestCode == FILECHOOSER_RESULTCODE)
        {
            if (null == mUploadMessage)
                return;
            // Use MainActivity.RESULT_OK if you're implementing WebView inside Fragment
            // Use RESULT_OK only if you're implementing WebView inside an Activity
            Uri result = intent == null || resultCode != MainActivity.RESULT_OK ? null : intent.getData();
            mUploadMessage.onReceiveValue(result);
            mUploadMessage = null;
        }
        else
            Toast.makeText(getApplicationContext(), "Failed to Upload Image", Toast.LENGTH_LONG).show();
    }

    public void akhiri() {
        try{
            /* taken from http://www.zoftino.com/android-app-up-navigation-implementation */
            Intent upIntent = NavUtils.getParentActivityIntent(this);
            if (NavUtils.shouldUpRecreateTask(this, upIntent)) {

                TaskStackBuilder.create(this)
                        .addNextIntentWithParentStack(upIntent)
                        .startActivities();
            } else {
                NavUtils.navigateUpTo(this, upIntent);
            }
        }
        catch (Exception e) {
            fso._do_log_debug(e, "akhiri");
        }
    }


    /*
    start subclass
    http://stackoverflow.com/questions/17864143/single-method-to-implement-ontouchlistener-for-multiple-buttons
    */

    public class MyTouchListener implements View.OnTouchListener {
        @Override
        public boolean onTouch(View v, MotionEvent event) {
            try {
                switch(v.getId()) {
                    case R.id.back:
                        akhiri();
                        break;
                    case R.id.close:
                        akhiri();
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
