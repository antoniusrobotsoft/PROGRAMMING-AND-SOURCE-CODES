<?php
session_start();
header('Content-Type: application/javascript');
header("Cache-Control: no-store, no-cache, must-revalidate, max-age=0");
header("Cache-Control: post-check=0, pre-check=0", false);
header("Pragma: no-cache");
?>

var listen = 0;
var chrome = 0;
var end_button_clicked = 0;


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
      if (Content.length > 0) {
        console.log("[+] speech recognition result : " + Content);
      }
      else {
        console.log("no data");
      }
  };

  recognition.onstart = function() {
    //console.log("speech recognition started");
  }

  recognition.onend = function() {
	if (end_button_clicked != -1) {
		button_action_restart_wrapper();
	}
  }

  function button_action_restart_wrapper() {
    try {
      stop_recog();
    }
    catch (err) {
      console.log("[-] speech recognition already stopped");
    }
    try {
      setTimeout(start_recog, 100);
    }
    catch (err) {
      console.log("[-] speech recognition already start");
    }
  }
  function restart_recognition() {
    try {
      recognition.stop();
    }
    catch(err) {
      //console.log("[-] recognition is not started");
    }
    finally {
      recognition.continuous = true;
      recognition.interimResults = false;
      recognition.lang = "en-US";
      recognition.maxAlternatives = 3;
      try {
        recognition.start();
      }
      catch(err) {
      }
    }
  }

  recognition.onerror = function(event) {
	if (end_button_clicked != -1) {
		button_action_restart_wrapper();
	}
  }
}
function start_recog() {
  $('#start_recognition').click();
  end_button_clicked = 0;
}
function stop_recog() {
  $('#stop_recognition').click();
  end_button_clicked = 1;
}
setTimeout(start_recog, 2000);
