<?php
date_default_timezone_set('Asia/Jakarta');
$koneksi = bukadb();
/*
https://thevaluable.dev/php-datetime-create-compare-format/
https://www.w3schools.com/php/func_date_date.asp
*/

$tahun = date('Y');
$bulan = date('m');
$tgl = date('d');
$tanggal = $tgl;
$jam = date('h');
$menit = date('i');
$current_fulldate = new DateTime("$tahun-$bulan-$tanggal $jam:$menit");
$current_time = new DateTime("$jam:$menit");

set_each_lights_command_scheduled();

function set_each_lights_command_scheduled() {
  global $koneksi, $hasil, $current_time, $jam, $menit, $tgl, $bulan, $tahun;
  $current_inject_date = "$tgl/$bulan/$tahun";
  if ($koneksi) {
    $s = "select * from `lights` where `controllable` = 'yes'";
    $q = kueridb($s);
    if ($q) {
      while ($r = getrow($q)) {
        $id = trim($r[0]);
        $scheduled_on = trim($r[6]);
        $scheduled_off = trim($r[7]);
        $move_capability = $r[9];

        $ar_scheduled_on = explode(":", $scheduled_on);
        $ar_scheduled_off = explode(":", $scheduled_off);

        $jam_scheduled_on = $ar_scheduled_on[0];
        if (intval($jam_scheduled_on) < 10) {
          $jam_scheduled_on = "0" . $jam_scheduled_on;
        }

        $menit_scheduled_on = $ar_scheduled_on[1];
        $menit_scheduled_on = str_replace("am","", $menit_scheduled_on);
        $menit_scheduled_on = str_replace("pm","", $menit_scheduled_on);


        $jam_scheduled_off = $ar_scheduled_off[0];
        if (intval($jam_scheduled_off) < 10) {
          $jam_scheduled_off = "0" . $jam_scheduled_off;
        }


        $menit_scheduled_off = $ar_scheduled_off[1];
        $menit_scheduled_off = str_replace("am","", $menit_scheduled_off);
        $menit_scheduled_off = str_replace("pm","", $menit_scheduled_off);


        if (strstr($scheduled_on, "pm")) {
          $jam_scheduled_on = intval($jam_scheduled_on) + 12;
        }

        if (strstr($scheduled_off, "pm")) {
          $jam_scheduled_off = intval($jam_scheduled_off) + 12;
        }

        $corrected_jam_scheduled_off = new DateTime("$jam_scheduled_off:$menit_scheduled_off");
        $corrected_jam_scheduled_on = new DateTime("$jam_scheduled_on:$menit_scheduled_on");

        $interval_scheduled_off = $current_time->diff($corrected_jam_scheduled_off);
        $interval_scheduled_on = $current_time->diff($corrected_jam_scheduled_on);

        print "<br>current_time : $jam:$menit<br>";
        print "<br>jam off : $jam_scheduled_off:$menit_scheduled_off<br>";
        print "<br>jam on : $jam_scheduled_on:$menit_scheduled_on<br>";

        echo "<hr>interval off jam : " . $interval_scheduled_off->h;
        echo "<hr>interval on jam : " . $interval_scheduled_on->h . "<hr>";

        if (intval($interval_scheduled_off->h) < 1) {
          $s = "update `lights` set `on_off` = 'light-off', `current_light_status` = 'off'  where `id` like '$id'";
          @mysqli_query($koneksi, $s) or die("err : $s");

          $s = "update `global_light_command` set `cmd` = '-', `cmd_date` = '$current_inject_date'";
          @mysqli_query($koneksi, $s) or die("err : $s");

          if ($move_capability == "1") {
            $s = "update `lights` set `move` = 'move-off', `current_move_status` = 'off'  where `id` like '$id'";
            @mysqli_query($koneksi, $s) or die("err : $s");

            $s = "update `global_movement_command` set `cmd` = '-', `cmd_date` = '$current_inject_date'";
            @mysqli_query($koneksi, $s) or die("err : $s");
          }

        }

        if (intval($interval_scheduled_on->h) < 1) {
          $s = "update `lights` set `on_off` = 'light-on', `current_light_status` = 'on'  where `id` like '$id'";
          @mysqli_query($koneksi, $s) or die("err : $s");

          $s = "update `global_light_command` set `cmd` = '-', `cmd_date` = '$current_inject_date'";
          @mysqli_query($koneksi, $s) or die("err : $s");

          if ($move_capability == "1") {
            $s = "update `lights` set `move` = 'move-on', `current_move_status` = 'on'  where `id` like '$id'";
            @mysqli_query($koneksi, $s) or die("err : $s");

            $s = "update `global_movement_command` set `cmd` = '-', `cmd_date` = '$current_inject_date'";
            @mysqli_query($koneksi, $s) or die("err : $s");
          }
        }
      }
    }
  }
}





function bukadb()  {
    global $hostname,$database, $username, $password, $koneksi;

    $hostname = "localhost";
    $username = "root";
    $password = "";
    $database = "robotsoft_iot";

    $koneksi = mysqli_connect($hostname, $username, $password, $database) or die("Connection to server lost, please contact admin");

    return $koneksi;
}

function kueridb($sql) {
    global $hasil,$koneksi;

    $retme = NULL;
    $sql = str_replace("--", "", $sql);
    $sql = str_replace("union", "", $sql);
    $hasil = @mysqli_query($koneksi, $sql) or die("err : $sql");
    if (!$hasil) {
        print $sql;
        die();
    }
    $retme = $hasil;
    return $retme;
}

function getrow($q) {
    return mysqli_fetch_row($q);
}

function countrow($q) {
    return mysqli_num_rows($q);
}

?>
