package com.ringlayer.simplestockinventory;

import android.app.Activity;
import android.content.pm.PackageManager;
import android.os.Environment;
import android.os.StrictMode;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.util.Log;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;

/**
 * Created by ringlayer on 24/11/18.
 */

public class Util {
    Activity mContext;

    public Util (Activity context)
    {
        mContext = context;

        StrictMode.VmPolicy.Builder builder = new StrictMode.VmPolicy.Builder();
        StrictMode.setVmPolicy(builder.build());

        if (android.os.Build.VERSION.SDK_INT > 9) {
            StrictMode.ThreadPolicy policy =
                    new StrictMode.ThreadPolicy.Builder().permitAll().build();
            StrictMode.setThreadPolicy(policy);}
    }

    public void askForPermission(String permission, Integer requestCode) {

        if (ContextCompat.checkSelfPermission(mContext, permission) != PackageManager.PERMISSION_GRANTED) {
            if (ActivityCompat.shouldShowRequestPermissionRationale(mContext, permission)) {
                ActivityCompat.requestPermissions(mContext, new String[]{permission}, requestCode);
            } else {
                ActivityCompat.requestPermissions(mContext, new String[]{permission}, requestCode);
            }
        }
    }


    public int buat_dir(String Dirname) {
        int retme = 0;
        try {
            boolean exists = false;

            exists = CheckIfDirectoryExists(Dirname);
            if (exists == false) {
                new File(Dirname).mkdirs();
            }

        }
        catch (Exception e) {
            Log.e("error",e.toString());
        }

        return retme;
    }

    public boolean CheckIfDirectoryExists(String path) {
        boolean exists = false;
        try {

            File dir = new File(path);
            exists = dir.exists();
            return exists;
        }
        catch (Exception e) {
            Log.e("error",e.toString());
            return false;
        }
    }

    public void append_file(String path, String content)
    {
        try {
            File file = new File(path);
            if (!file.exists()) {
                file.createNewFile();
            }
            FileWriter fw = new FileWriter(file,true);
            BufferedWriter bw = new BufferedWriter(fw);
            PrintWriter pw = new PrintWriter(bw);
            pw.println(content);
            pw.close();
        }  catch(Exception e) {
            Log.e("error",e.toString());
        }
    }

    public String read(String fname){

        BufferedReader br = null;
        String line = null;

        try {
            br = new BufferedReader(new FileReader(fname));
            line = br.readLine();
            if (line == null) {
                line = "";
            }
        } catch(IOException e) {
            Log.e("error", e.toString());
            return null;
        }

        return line;
    }


    public Boolean write(String fname, String fcontent){
        try {
            String fpath =  fname;

            File file = new File(fpath);

            if (!file.exists()) {
                file.createNewFile();
            }

            FileWriter fw = new FileWriter(file.getAbsoluteFile());
            BufferedWriter bw = new BufferedWriter(fw);
            bw.write(fcontent);
            bw.close();

            return true;
        } catch(IOException e) {
            Log.e("error",e.toString());
            return false;
        }
    }

    public void createFileInSDCard(String path) {
        try {
            int exists = check_file_exists(path);

            if (exists == 0) {
                File file = new File(path);
                file.createNewFile();
            }
        }
        catch (Exception e) {
            Log.e("error",e.toString());
        }
    }

    public int check_file_exists(String full_path) {
        int retme = 0;
        try {
            File file = new File(full_path);
            if(file.exists()) {
                retme = 1;
            }
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }

        return retme;
    }

    /*
    * SAMPLE FILE CONTENT TO PARSE :
    * code1@@pencil@@0
    * code2@@book@@2
    */

    public String[] ParseStock(String IsiFullFile) {
        String[] ParseRest = {"No stock data yet ! \n Please input some goods using STOCK-IN BUTTON"};

        try {
            ParseRest = IsiFullFile.split("_____");
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }


        return ParseRest;
    }

    public String ChangeParsedIntoBharis(String[] ParseRest) {
        String ViewMe = "";
        int i;

        try {
            if (ParseRest[0].indexOf("No stock data yet") != -1) {
                Log.e("info", "no stock data yet :(");
                ViewMe =  ParseRest[0].trim();
            }
            else {

                for (i = 0; i < ParseRest.length;i++) {
                    if ( (ParseRest[i].length() > 1) && (ParseRest[i].contains("@@"))) {
                        String[] parts = ParseRest[i].split("@@");
                        ViewMe += "\nProduct Code : " + parts[0] + "\n";
                        ViewMe += "Product Name : " + parts[1] + "\n";
                        ViewMe += "Stock : " + parts[2];
                        ViewMe += "\n________________________________________\n";
                    }
                }
            }
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }

        return ViewMe;
    }

    /*
    * writeFile method taken from
    * https://stackoverflow.com/questions/36740254/how-to-overwrite-a-file-in-sdcard-in-android
    * */

    void writeFile(String fileName, String data) {
        try {
            File outFile = new File(fileName);
            FileOutputStream out = new FileOutputStream(outFile, false);
            byte[] contents = data.getBytes();
            out.write(contents);
            out.flush();
            out.close();
        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }
    }

    public boolean ValidateCodeNameAmount(String name, String amount) {
        boolean valid = false;
        try {
            if (name.trim().length() > 0) {
                valid = true;
            }

            if ( (amount.trim().length() > 0) && (Integer.parseInt(amount) > 0) ){
                valid = true;
            }

        }
        catch (Exception e) {
            Log.e("error", e.toString());
        }

        return valid;
    }

}
