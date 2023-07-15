#!/usr/bin/env python3

'''
lpse bot
This bot will simply monitor every tenders in lpse based on spesific keywords

keywords = ["aplikasi", "web", "server", "komputer", "software", "sistem informasi", "fids", "bandar udara"]

written by Antonius Robotsoft

use crontab to run every 24 hours to get updated result
'''

from selenium import webdriver
from selenium.webdriver.chrome.options import Options
import os,sys, time, inspect, codecs, signal
from random import randint
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys

found = 0
tahaps = ["Pengumuman Pascakualifikasi", "Pengumuman Prakualifikasi", "Download Dokumen", "Penjelasan Dokumen", "Kirim Persyaratan"]

lpse = [5]*25
lpse[0] = "https://www.lpse.kemenkeu.go.id/eproc4/lelang"
lpse[1] = "https://lpse.kemlu.go.id/eproc4/lelang"
lpse[2] = "https://lpse.kemenag.go.id/eproc4/lelang"
lpse[3] = "https://lpse.atrbpn.go.id/eproc4/lelang"
lpse[4] = "https://eproc.esdm.go.id/eproc4/lelang"
lpse[5] = "https://lpse.kemenkumham.go.id/eproc4/lelang"
lpse[6] = "https://lpse.kkp.go.id/eproc4/lelang"
lpse[7] = "https://lpse.kemkes.go.id/eproc4/lelang"
lpse[8] = "https://lpse.kemnaker.go.id/eproc4/lelang"
lpse[9] = "https://lpse.kemendagri.go.id/eproc4/lelang"
lpse[10] = "https://lpse.kominfo.go.id/eproc4/lelang"
lpse[11] = "https://lpse.menlhk.go.id/eproc4/lelang"
lpse[12] = "https://lpse.kemdikbud.go.id/eproc4/lelang"
lpse[13] = "https://lpse.kemendag.go.id/eproc4/lelang"
lpse[14] = "https://lpse.dephub.go.id/eproc4/lelang"
lpse[15] = "https://lpse.kemenperin.go.id/eproc4/lelang"
lpse[16] = "https://lpse.pertanian.go.id/eproc4/lelang"
lpse[17] = "https://lpse.kemensos.go.id/eproc4/lelang"
lpse[18] = "https://lpse.kemenkopukm.go.id/eproc4/lelang"
lpse[19] = "https://lpse.kemenparekraf.go.id/eproc4"
lpse[20] = "https://lpse.bmkg.go.id/eproc4/lelang"
lpse[21] = "https://lpse.tangerangkota.go.id/eproc4/lelang"
lpse[22] = "https://lpse.jakarta.go.id/eproc4/lelang"
lpse[23] = "https://lpse.tangerangkab.go.id/eproc4/lelang"
lpse[24] = "https://eproc.kotabogor.go.id/eproc4/lelang"


keywords = ["aplikasi", "web", "server", "komputer", "software", "sistem informasi", "fids", "bandar udara"]

def RandomUa():
    try:
        selected_ua = "?"
        ua_lists = []
        ua_lists.append("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:57.0) Gecko/20100101 Firefox/57.0")
        ua_lists.append("Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:55.0) Gecko/20100101 Firefox/55.0")
        ua_lists.append("Mozilla/5.0 (Windows NT 6.1; rv:55.0) Gecko/20100101 Firefox/55.0")
        total = len(ua_lists)
        rand_num = randint(0, total - 1)
        selected_ua = ua_lists[rand_num].strip()
        return selected_ua
    except Exception as e:
        print(e)
        print ("[-] exception :" + inspect.stack()[0][3])
        pass
    
def InitLpse():
    try:
        print("[+] init lpse ...")
        ua = "?"
        ua = RandomUa()
        opts = webdriver.ChromeOptions()
        opts.add_argument('headless')
        opts.add_argument('--user-agent=' + ua)
        driver = webdriver.Chrome(chrome_options=opts)

        return driver

    except Exception as e:
        raise e
 
def GetRes(input, driver, keyword, lp):
    try:
        global tahaps, found
        
        fp = open('tender.html', 'a') 
        input.clear()
        input.send_keys(keyword)
        input.send_keys(Keys.ENTER)
        time.sleep(3)
        trs = driver.find_elements(By.TAG_NAME, 'tr')
        for tr in trs:
            val = tr.get_attribute("class")
            if val == "odd":
                html = tr.get_attribute("innerHTML")
                if html.find("eproc4/lelang/") != -1:
                    for tahap in tahaps:
                        if html.find(tahap) != -1:
                            fp.write("<tr><td colspan=5><br><hr><br></td></tr>")
                            res = "<tr><td colspan=5>keyword : "+keyword+" </td></tr><tr>"
                            fp.write(res)
                            html = html.replace("/eproc4/lelang", lp)
                            fp.write(html)
                            fp.write("</tr>")
        fp.close()
    except Exception as e:
        raise e
    
    
def Main():
    try:
        global lpse, keywords
        
    
        driver = InitLpse()
        os.system("rm -f tender.html, touch tender.html")
        for lp in lpse:
            print(lp)
            res = "<style>td {border:1px solid silver}</style><table style='border:1px solid silver'>"
            with open('tender.html', 'a') as fp:
                fp.write(res)
            driver.get(lp)
            time.sleep(3)
            inputs = driver.find_elements(By.TAG_NAME, 'input')
            for input in inputs:
                val1 = input.get_attribute("type")
                val2 = input.get_attribute("aria-controls") 
                if val1 == "search" and val2 == "tbllelang":
                    for keyword in keywords:
                        GetRes(input, driver, keyword, lp)
            with open('tender.html', 'a') as fp:
                res = "</table><br><hr><br>"
                fp.write(res)
        time.sleep(10)
    except Exception as e:
        raise e
    

Main()