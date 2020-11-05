<?php
   if(isset($_FILES['file'])){
      $file_name = $_FILES['file']['name'];
      $file_tmp = $_FILES['file']['tmp_name'];
      $file_name = strtolower($file_name);
      if (!strstr($file_name, ".php")) {
        move_uploaded_file($file_tmp,"your_path/".$file_name);
      }     
   }
?>
