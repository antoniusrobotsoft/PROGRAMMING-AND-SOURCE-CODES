package com.ringlayer.indotalent;

import android.os.StrictMode;
import android.util.Log;

import org.json.JSONObject;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.net.HttpURLConnection;
import java.net.URL;
import java.net.URLEncoder;
import java.util.Arrays;
import java.util.Iterator;
import java.util.List;

/**
 * Created by ringlayer on 23/06/18.
 *
 * modified from https://www.studytutorial.in/android-httpurlconnection-post-and-get-request-tutorial
 */

public class SendPostRequest {
    protected String _execute(String url_post,String[] key_str, String[] val_str, String[] butuh_validasi) {
        try {
            StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
            StrictMode.setThreadPolicy(policy);

            URL url = new URL(url_post);
            int i;
            List<String> list = Arrays.asList(butuh_validasi);
            for (i = 0; i < key_str.length; i++) {
                if (list.contains(key_str[i])) {
                    if (val_str[i].length() < 1) {
                        return new String("invalid input");
                    }
                }
            }
            JSONObject postDataParams = new JSONObject();
            for (i = 0; i < key_str.length; i++) {
                postDataParams.put(key_str[i], val_str[i]);
            }
            Log.e("params", postDataParams.toString());
            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setReadTimeout(15000 /* milliseconds */);
            conn.setConnectTimeout(15000 /* milliseconds */);
            conn.setRequestMethod("POST");
            conn.setDoInput(true);
            conn.setDoOutput(true);
            conn.connect();

            OutputStream os = conn.getOutputStream();
            BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(os, "UTF-8"));
            writer.write(getPostDataString(postDataParams));

            writer.flush();
            writer.close();
            os.close();

            InputStreamReader in = new InputStreamReader((InputStream) conn.getContent());
            BufferedReader buff = new BufferedReader(in);
            String line = "";
            StringBuffer text = new StringBuffer();
            while (line != null) {
                line = buff.readLine();
                text.append(line + "\n");
            }
            Log.e("res:", text.toString());
            String res = text.toString();
            return res;
        }
        catch (Exception e){
            return new String("Exception: " + e.getMessage());
        }

    }
    /*
    taken from https://www.studytutorial.in/android-httpurlconnection-post-and-get-request-tutorial
    */
    public String getPostDataString(JSONObject params) throws Exception {

        StringBuilder result = new StringBuilder();
        boolean first = true;

        Iterator<String> itr = params.keys();

        while(itr.hasNext()){

            String key= itr.next();
            Object value = params.get(key);

            if (first)
                first = false;
            else
                result.append("&");

            result.append(URLEncoder.encode(key, "UTF-8"));
            result.append("=");
            result.append(URLEncoder.encode(value.toString(), "UTF-8"));

        }
        return result.toString();
    }


}
