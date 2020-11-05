<?php
/*
simple php file to be included at the top of your php files
this little script will prevent basic web based attacks via get and post such as:
sql injection, local file inclusion, remote file inclusion
created by Antonius Robotsoft
www.robotsoft.co.id
*/
$blocked_array = array("extractvalue","select","union","../../","https://","http://", "ftp://","outfile","gopher://","null%2c","<script>", "%00");
foreach ($_POST as $key => $value){
  $small_val = strtolower($value);
  if (in_array($small_val, $blocked_array)) {
    print "<meta http-equiv=\"refresh\" content=\"0;url=index.php\" />";
    die();
  }
  else
    $$key = $value;
}
foreach ($_GET as $key => $value){
  $small_val = strtolower($value);
  if (in_array($small_val, $blocked_array)) {
    print "<meta http-equiv=\"refresh\" content=\"0;url=index.php\" />";
    die();
  }
  else
    $$key = $value;
}

foreach ($_SERVER as $key => $value){
  $small_val = strtolower($value);
  if (in_array($small_val, $blocked_array)) {
    print "<meta http-equiv=\"refresh\" content=\"0;url=index.php\" />";
    die();
  }
}

$get_req = strtolower(print_r($_GET, true));
foreach ($blocked_array as $banword) {
  if (strstr($get_req, $banword)) {
    print "<meta http-equiv=\"refresh\" content=\"0;url=index.php\" />";
    die();
  }
}

?>
