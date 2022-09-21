<?php
session_start();
header('Content-Type: application/javascript');
header("Cache-Control: no-store, no-cache, must-revalidate, max-age=0");
header("Cache-Control: post-check=0, pre-check=0", false);
header("Pragma: no-cache");
header('Access-Control-Allow-Origin: *');
header('Access-Control-Allow-Methods: GET, POST');
header("Access-Control-Allow-Headers: X-Requested-With");

require_once("../../../inc/cl.php");
$robomall = new RoboMall;


if (!isset($_SESSION['sesssion_logged']))
  $_SESSION['sesssion_logged'] = 0;
?>

console.log("main user start");

var session_logged = <?php print $_SESSION['sesssion_logged'];?>;
const SIGNALING_SERVER_URL = 'https://robotsoft.co.id:9999';
const TURN_SERVER_URL = 'robotsoft.co.id:3478';
const TURN_SERVER_USERNAME = 'turn';
const TURN_SERVER_CREDENTIAL = '12345';

let pc;
let localStream;
let remoteStreamElement = document.querySelector('#remoteStream');
let localStreamElement = document.querySelector('#localStream');

let dataChannel;

const dataChannelOptions = {
  ordered: true,
  maxPacketLifeTime: 5000,
};


const PC_CONFIG = {
  iceServers: [
    {
      urls: 'turn:' + TURN_SERVER_URL + '?transport=tcp',
      username: TURN_SERVER_USERNAME,
      credential: TURN_SERVER_CREDENTIAL
    },
    {
      urls: 'turn:' + TURN_SERVER_URL + '?transport=udp',
      username: TURN_SERVER_USERNAME,
      credential: TURN_SERVER_CREDENTIAL
    }
  ]
};

// Signaling methods
let socket = io(SIGNALING_SERVER_URL, { autoConnect: true });

socket.on('data', (data) => {
  console.log('Data received: ',data);
  handleSignalingData(data);
});

socket.on('ready', () => {
  console.log('Ready');
  pc = createPeerConnection();
  InitDataChannel(pc);
  sendOffer();
});

function sendData(data) {
  console.log("[+] sending data :" + data);
  socket.emit('data', data);
}

function getLocalStream() {
  console.log("\nget local stream\n");
  navigator.mediaDevices.getUserMedia({ audio: true, video: true })
    .then((stream) => {
      console.log('Stream found');
      localStream = stream;
      localStreamElement.srcObject = localStream;
      console.log("\n stream available ... connection\n");
      socket.connect();
    })
    .catch(error => {
      console.warn('Stream not found: ', error);
      socket.connect();
    });

    console.log("\ndone\n");
}



function createPeerConnection () {
  try {
    pc = new RTCPeerConnection(PC_CONFIG);
    pc.onicecandidate = onIceCandidate;
    pc.ontrack = onTrack;
    try {
	     pc.addStream(localStream);
    }
    catch (error) {
	     console.warn('Camera for user now allowed : ', error);
    }

    console.log('PeerConnection created');
    return pc;
  } catch (error) {
    console.warn('PeerConnection failed: ', error);
  }
}

let sendOffer = () => {
  console.log('Send offer');
  pc.createOffer().then(
    setAndSendLocalDescription,
    (error) => { console.warn('Send offer failed: ', error); }
  );
};

let sendAnswer = () => {
  console.log('Send answer');
  pc.createAnswer().then(
    setAndSendLocalDescription,
    (error) => { console.warn('Send answer failed: ', error); }
  );
};

let setAndSendLocalDescription = (sessionDescription) => {
  pc.setLocalDescription(sessionDescription);
  console.log('Local description set');
  sendData(sessionDescription);
};

let onIceCandidate = (event) => {
  if (event.candidate) {
    console.log('ICE candidate');
    sendData({
      type: 'candidate',
      candidate: event.candidate
    });
  }
};

let onTrack = (event) => {
  try {
    console.log('Add track');
    remoteStreamElement.srcObject = event.streams[0];
  }
  catch(err) {
		console.warn("Add remote track failed ! Camera from user is now allowed or not available :", err);
	}
};

let handleSignalingData = (data) => {
  switch (data.type) {
    case 'offer':
      pc  = createPeerConnection();
      InitDataChannel(pc);
      pc.setRemoteDescription(new RTCSessionDescription(data));
      sendAnswer();
      break;
    case 'answer':
      pc.setRemoteDescription(new RTCSessionDescription(data));
      break;
    case 'candidate':
      pc.addIceCandidate(new RTCIceCandidate(data.candidate));
      break;
    default:
	   console.log("\ngot data : " + data + "\n\n");
  }
};

function LogRoboMallSession(robot_id) {
  console.log("[+] call log session");
  $.get("api/log_session.php?robot_id=" + robot_id, function(data, status){
    console.log("Data: " + data + "\nStatus: " + status);
  });

  console.log("[+] initialize lat long session");
  $.get("api/session_lat_long_set.php", function(data, status){
    console.log("Data: " + data + "\nStatus: " + status);
  });

  console.log("[+] initialize ongkir session");
  $.get("api/session_jarak_set.php", function(data, status){
    console.log("Data: " + data + "\nStatus: " + status);
  });
}

function InitDataChannel(pc) {
  var robot_id = "<?php print $robot_id;?>";

  pc.addEventListener('datachannel', event => {
      dataChannel = event.channel;
      dataChannel.onerror = (error) => {
        console.log("Data Channel Error:", error);
      };
      dataChannel.onmessage = (event) => {
        console.log("Got Data Channel Message:", event.data);

        if (event.data.includes("order-deliver")) {
          modal_load("modals/modal_confirm_delivery.php", "Your order has been delivered !");
        }

        if (event.data.includes("robot_id=")) {
          var ar = event.data.split("=");
          robot_id = ar[1];
        }
        session_logged = <?php print  $_SESSION['sesssion_logged']; ?>;
        if (session_logged == 0) {
          LogRoboMallSession(robot_id);
        }
      };
      dataChannel.onopen = () => {
        console.log("datachannel ready");
        session_logged = <?php print  $_SESSION['sesssion_logged']; ?>;
        if (session_logged == 0) {
          LogRoboMallSession(robot_id);
        }
      };
      dataChannel.onclose = () => {
        console.log("The Data Channel is Closed");
      };
  });
}

function TransmitCmd(cmd) {
  try {
    console.log("[+] transmit cmd : " + cmd);
    sendData(cmd);
  }
  catch (error) {
    console.warn(error);
    sendData(cmd);
    //TransmitPhp(cmd);
  }
}

function TransmitPhp(cmd) {
  try {
    console.log("[+] transmit cmd : " + cmd);
    $.get("api/cmd.php?cmd=" + cmd, function(data, status){
       console.log("Data: " + data + "\nStatus: " + status);
    });
  }
  catch (error) {
    console.warn(error);
  }
}


/*
START MOTORIC COMMANDS !
*/

$("#left").click(function(){
  TransmitCmd("turn-left");
  TransmitPhp("turn-left");
});

$("#right").click(function(){
  TransmitCmd("turn-right");
  TransmitPhp("turn-right");
});

$("#backward").click(function(){
  TransmitCmd("turn-backward");
  TransmitPhp("turn-backward");
});

$("#forward").click(function(){
  TransmitCmd("turn-forward");
  TransmitPhp("turn-forward");
});

$("#stop").click(function(){
  TransmitCmd("turn-stop");
  TransmitPhp("turn-stop");
});

$("#exit").click(function(){
  TransmitCmd("turn-stop");
  TransmitPhp("turn-stop");
});

function head_up() {
  TransmitCmd("head-up");
}

function head_down() {
  TransmitCmd("head-down");
}

function head_init() {
  TransmitCmd("head-init");
}

function set_speed_fastest() {
  TransmitCmd("speed-250");
  TransmitPhp("speed-250");
}

function set_speed_fast() {
  TransmitCmd("speed-200");
  TransmitPhp("speed-200");
}

function set_speed_medium() {
  TransmitCmd("speed-150");
  TransmitPhp("speed-150");
}

function set_speed_slow() {
  TransmitCmd("speed-100");
  TransmitPhp("speed-100");
}

function set_speed_slowest() {
  TransmitCmd("speed-50");
  TransmitPhp("speed-50");
}

/*
EOF MOTORIC COMMANDS !
*/

console.log("\n main user end \n");
getLocalStream();
