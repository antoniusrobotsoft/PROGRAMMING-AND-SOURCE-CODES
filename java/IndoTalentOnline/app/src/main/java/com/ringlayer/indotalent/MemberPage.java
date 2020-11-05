package com.ringlayer.indotalent;

/*
* created by Antonius Ringlayer
* www.ringlayer.net - www.ringlayer.com
* https://github.com/ringlayer
* */

import android.app.Activity;
import android.content.ActivityNotFoundException;
import android.content.Intent;
import android.net.Uri;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.MotionEvent;
import android.view.View;
import android.webkit.ValueCallback;
import android.webkit.WebChromeClient;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.ImageView;
import android.widget.Toast;

public class MemberPage extends AppCompatActivity {
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
        try {
            super.onCreate(savedInstanceState);
            setContentView(R.layout.activity_member_page);


            String url = "";
            //ScrollView mybaby = (ScrollView) findViewById(R.id.scrollmebaby);
            webView = (WebView) findViewById(R.id.memberarea);

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
                    catch (Exception e){
                        fso._do_log_debug(e, "listen_userclick");
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
                    catch (Exception e){
                        fso._do_log_debug(e, "listen_userclick");
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
                    catch (Exception e){
                        fso._do_log_debug(e, "listen_userclick");
                    }
                }
            });

            webView.setWebViewClient(new WebViewClient() {

                @Override
                public boolean shouldOverrideUrlLoading(WebView view, String url)
                {
                    view.loadUrl(url);
                    return true;


                }
            });

            //webView.clearCache(true);
            webView.getSettings().setAppCacheEnabled(true);
            url = getResources().getString(R.string.member_area_url);
            webView.loadUrl(url);

            ImageView img_home = (ImageView) findViewById(R.id.home);
            img_home.setOnTouchListener(new View.OnTouchListener() {
                @Override
                public boolean onTouch(View view, MotionEvent motionEvent) {
                    MemberPage.webView.loadUrl(getResources().getString(R.string.member_area_url));
                    return false;
                }
            });


            ImageView img_ikonuser = (ImageView) findViewById(R.id.ikonuser);
            img_ikonuser.setOnTouchListener(new View.OnTouchListener() {
                @Override
                public boolean onTouch(View view, MotionEvent motionEvent) {
                    MemberPage.webView.loadUrl(getResources().getString(R.string.member_profil_url));
                    return false;
                }
            });

            ImageView img_menubar = (ImageView) findViewById(R.id.menubar);
            img_menubar.setOnTouchListener(new View.OnTouchListener() {
                @Override
                public boolean onTouch(View view, MotionEvent motionEvent) {
                    MemberPage.webView.loadUrl(getResources().getString(R.string.member_menubar_url));
                    return false;
                }
            });
            ImageView img_settingbar = (ImageView) findViewById(R.id.settingbar);
            img_settingbar.setOnTouchListener(new View.OnTouchListener() {
                @Override
                public boolean onTouch(View view, MotionEvent motionEvent) {
                    MemberPage.webView.loadUrl(getResources().getString(R.string.member_settingbar_url));
                    return false;
                }
            });
            //mybaby.scrollTo(0,0);
        }
        catch (Exception e) {
            fso._do_log_debug(e, "on create member");
        }
    }

    public void akhiri() {
        try {
            Intent i = new Intent(MemberPage.this, MainActivity.class);
            startActivity(i);
            finish();
        }
        catch (Exception e) {
            fso._do_log_debug(e, "akhiri");
        }
    }
}
