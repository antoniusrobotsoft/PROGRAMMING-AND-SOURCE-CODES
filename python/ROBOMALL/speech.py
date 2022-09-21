#!/usr/bin/env python3

'''
ROBOMALL version 1.0
Manufactured by Robotsoft
www.robotsoft.co.id
Developed by : Antonius Robotsoft
speech to text
'''

import os, sys, time, inspect,config, threading, kamus, aiml
from random import randint
from util import Util
from gtts import gTTS

SpeechUtil = Util

lists_menu = []
lists_url = []
lists_keyword = []


class Speech():
    
    global speech_util, kernel
    
    speech_util = SpeechUtil

    '''
    START TEXT TO SPEECH
    '''
    
    def speech_check_proc(self):
        try:
            while True:
                ps_mpg = os.popen("ps aux | grep mpg321").read().strip()
                if ps_mpg.find("tmp.mp3") != -1:
                    os.system("echo 'blocked' > ipc/vision_speech.txt")
                else:
                    os.system("echo '0' > ipc/vision_speech.txt")
                time.sleep(1.5)
        except Exception as e:
            #raise e
            speech_util.err_proc(self, e)
            pass
        
    def speech_init(self):
        try:
            global kernel
            
            print("[+] speech init")
            self.speech_mall_info_get_mall_data()
            kernel = aiml.Kernel()
            kernel.learn(config.robomall_aiml_path)
            
            speechproc_thread = threading.Thread(target=self.speech_check_proc)
            speechproc_thread.start()

        except Exception as e:
            #raise e
            speech_util.err_proc(self, e)
            pass
            
    def speech_speak(self, words, lang=config.robomall_language):
        try:
            print("[+] Robot berbicara : " + str(words))
            ps_mpg = os.popen("ps aux | grep mpg321").read().strip()
            while (ps_mpg.find("tmp.mp3") != -1):
                ps_mpg = os.popen("ps aux | grep mpg321").read().strip()
                time.sleep(0.1)
            if os.path.exists("tmp.mp3"):
                os.system("rm -f tmp.mp3")
            tts = gTTS(text=words, lang=lang, slow=True)
            tts.save("tmp.mp3")
            os.system("killall -9 mpg321;mpg321 tmp.mp3 &")
        except Exception as e:
            speech_util.err_proc(self, e)
            pass
  

    def speech_mall_info_get_mall_data(self):
        try:
            global lists_menu, lists_url, lists_keyword
            
            print("[+] getting mall data")
            path = "mall_databases/" + config.robomall_current_city + "/" +  config.robomall_current_mall + "/data.txt"
            lines = []
            with open(path) as f:
                lines = f.readlines()
            for line in lines:
                if len(line.strip()) > 1 and "|" in line:
                    ar = line.split("|")
                    if len(ar[0]) > 1:
                        lists_menu.append(ar[0].strip())
                    if len(ar[1]) > 1:
                        lists_url.append(ar[1].strip())
                        
            path = "mall_databases/" + config.robomall_current_city + "/" +  config.robomall_current_mall + "/keywords.txt"
            lists_keyword = []
            with open(path) as f:
                lists_keyword = f.readlines()
                
            print ("[+] end getting mall data")
        except Exception as e:
            browser_util.err_proc(self, e)
            pass
        
        
    def speech_give_answer(self, question):
        try:
            global kernel, lists_menu, lists_keyword
            
            response = ""
            print("[+] got question : " + question)
            response = str(kernel.respond(question)).strip()
           
            return response
        except Exception as e:
            speech_util.err_proc(self, e)
            pass
        
    '''
    EOF TEXT TO SPEECH
    '''
    
    '''
    START SPEECH RECOGNITION
    '''
    
    def speech_recognize_pipe_mic_to_wav(self):
        try:
            #http://www.voxforge.org/home/docs/faq/faq/linux-how-to-determine-your-audio-cards-or-usb-mics-maximum-sampling-rate
            #http://www.thegeekstuff.com/2009/05/sound-exchange-sox-15-examples-to-manipulate-audio-files/?utm_source=twitterfeed&utm_medium=twitter
            os.system("rm -f tmp/tmp.wav")
            #os.system("arecord -f cd -t wav > tmp.wav &")
            cmd = "AUDIODEV=" +  str(config.mic2) + " rec -b 16 -c 2 tmp/tmp.wav &"
            os.system(cmd)
            time.sleep(16)
            os.system("killall -9 rec")
        except Exception as e:
            speech_util.err_proc(self, e)
            pass
    
    
    def speech_recognize_online_google(self):
        try:
            print (inspect.stack()[0][3])
            r = sr.Recognizer()
            AUDIO_FILE = ("tmp/tmp.wav")
            with sr.AudioFile(AUDIO_FILE) as source:
                audio = r.record(source)
            print ("[+] start recognizing")
            res =  r.recognize_google(audio)
            print ("[+] result : " + res)
            print ("[+] recognizing done")
            
            return res
        except Exception as e:
            speech_util.err_proc(self, e)
            pass

    '''
    EOF SPEECH RECOGNITION
    '''

