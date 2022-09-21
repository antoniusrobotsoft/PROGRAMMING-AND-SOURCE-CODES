<?php
header('Content-Type: application/javascript');
?>
/*
speech command support for robotsoft iot
www.robotsoft.co.id
*/
var found_command = 0;
var exec_this = 0;
var command = "";
var listen = 0;
var chrome = 0;

var light_on_commands = ["on", "light on", "lawson", "shazam", "savan", "avant", "savannah", "resume", "azam", "program","salsa", "exam", "sazon","lawton", "logon", "log on", "live fun", "lights on","rock on"];
var light_off_commands = ["off", "light off", "lights off","laugh", "all light off"];

var SpeechRecognition = window.webkitSpeechRecognition ||  window.SpeechRecognition;
if (SpeechRecognition === null || SpeechRecognition === undefined) {
  console.log("not supported");
}
else {
  chrome = 1;
  var recognition = new SpeechRecognition();
  var Content = '';
  recognition.continuous = true;
  recognition.interimResults = false;
  recognition.lang = "en-US";
  recognition.maxAlternatives = 3;
  recognition.onresult = function(event) {
    var current = event.resultIndex;
    var transcript = event.results[current][0].transcript.trim();

      Content = transcript.trim().toLowerCase();
      console.log("Got : " + Content);

      found_command = 0;

      if (light_on_commands.indexOf(Content) != -1) {
        found_command = 1;
        Content = "light on";
      }
      else if (light_off_commands.indexOf(Content) != -1) {
        found_command = 1;
        Content = "light off";
      }
      else if (Content.indexOf(" on") != -1) {
        found_command = 1;
        Content = "light on";
      }
      else if (Content.indexOf(" off") != -1) {
        found_command = 1;
        Content = "light off";
      }
      else {
          /* start fuzzy set calculations */
          //light on ?
          var light_on_percentage = fuzzyset_cal("light on", Content);
          var light_on_percentage_using_shazam_keyword = fuzzyset_cal("shazam", Content);
          var light_off_percentage = fuzzyset_cal("light off", Content);

          if ( (light_off_percentage > light_on_percentage) && (light_off_percentage >  light_on_percentage_using_shazam_keyword)) {
            found_command = 1;
            Content = "light off";
          }
          else {
            found_command = 1;
            Content = "light on";
          }
      }


      command = "Your command is " +  Content;
      if (found_command == 1) {
        send_speech_command(Content);
      }
      else {
        command += "  Sorry, unknown command !";
      }
      $('#speech_result').html(command);

  };

  recognition.onstart = function() {
    console.log("speech recognition started");
  }

  recognition.onend = function() {
    if (listen == 1) {
      restart_recognition();
    }
    else {
      recognition.stop();
    }
  }

  function restart_recognition() {
    recognition.stop();
    recognition.continuous = true;
    recognition.interimResults = false;
    recognition.lang = "en-US";
    recognition.maxAlternatives = 3;
    recognition.start();
  }

}


function recog() {
  <?php
  $ua = $_SERVER['HTTP_USER_AGENT'];
  if (!strstr($ua, "Chrom")) {
  ?>
    var title = "Your Browser not Supported !";
    var htm = "<center>Please use google chrome browser. <br>Speech Command supported on google chrome only !</center>";

    modal_htm(title, htm);
  <?php
  }
  else {
  ?>
  if (listen == 0) {
    console.log("current listen = 1");
    listen = 1;
    $('#start_speech').hide();
    $('#stop_speech').show();
    $('#speech').fadeIn();
    if (chrome == 1) {
      recognition.start();
    }

  }
  else {
    console.log("current listen = 0");
    listen = 0;
    $('#stop_speech').hide();
    $('#start_speech').show();
    $('#speech').fadeOut();
    if (chrome == 1) {
        recognition.stop();
    }
  }
  <?php
  }
  ?>
}


function send_speech_command(cmd) {
  var comm = "";
  if ($('#all').prop('checked')) {
    console.log("all light on");
    comm = "light-on";
  }
  else {
    console.log("all light off");
    comm = "light-off";
  }

  if (light_on_commands.indexOf(cmd) != -1) {
    cmd = "light-on";
    exec_this = 1;
  }
  else if (light_off_commands.indexOf(cmd) != -1) {
    cmd = "light-off";
    exec_this = 1;
  }


  if ( exec_this == 1 ) {
    $.get("modals/update.php?comm=" + cmd + "&mode=all", function( data ) {
      console.log(data);
      if (data.indexOf("database updated") != -1) {
        $('#ajax_lights').load("inc/table_lights.php");
      }
    });
    exec_this = 0;
  }
}

function fuzzyset_cal(string_command, string_recognize) {
  a = FuzzySet();
  a.add(string_command);
  var dirty = a.get(string_recognize);
  var result = (dirty[0][0].toFixed(1)) * 100;

  return result;
}
