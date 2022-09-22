#!/usr/bin/env python3
'''
simple alarm reminder
https://github.com/antoniusrobotsoft/PROGRAMMING-AND-SOURCE-CODES/tree/main/python/utils/simple_alarm
'''

import os,sys, time
import datetime
with open("timer.txt") as fp:
    data = fp.readline()
    
data = data.replace("\n", "").strip()
ar_data = data.split("|")

while True:
    now = datetime.datetime.now()
    jam = int(now.hour)
    menit = int(now.minute)
    
    for jam_alarm in ar_data:
        jam_alarm = int(jam_alarm)
        if jam_alarm == jam and (menit == 0 or menit == 5) :
            os.system("espeak -s 140 -ven-us+f2 'Hello master ! Time is up, now is "+str(jam_alarm)+", please switch to next task based on your to do list'")
    time.sleep(3)
    
