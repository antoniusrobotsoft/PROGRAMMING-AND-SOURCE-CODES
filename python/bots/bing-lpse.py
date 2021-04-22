#!/usr/bin/env python3

from selenium import webdriver
from selenium.webdriver.chrome.options import Options
import os,sys, time, inspect, codecs, signal
from random import randint



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


def StopBrowser(driver):
    try:
        print("[+] stop browser")
        driver.quit()
    except Exception as e:
        print(e)
        print ("[-] exception :" + inspect.stack()[0][3])
        pass

def Main():
    try:
        driver = 0
        list_lpse = []
        list_blocked_strings = ["microsoft", "bing", "helpdesk", "arsip", "ppid", "inaproc", "report", "latihan"]
        print("[+] main start ...")
        os.system("echo ''>lpse.txt")
        fp = open("lpse.txt","a+")
        driver = InitBing()
        first = 1
        if (str(type(driver)).find("webdriver") != -1):
            for i in range(1, 101):
                if (i > 1) :
                    first = (i * 10) + 1
                url = "http://www.bing.com/search?q=lpse&first=" + str(first)
                print("[+] ==>  " + url)
                driver.get(url)
                links = driver.find_elements_by_tag_name("a")
                for link in links:
                    if link is not None and link.get_attribute("href") is not None:
                        dirty_href = link.get_attribute("href")
                        if ( (dirty_href.find("go.id") != -1) or (dirty_href.find(".ac.id") != -1) ):
                            valid = 1
                            for blocked in list_blocked_strings:
                                if blocked in dirty_href:
                                    valid = 0
                                    break
                            if ( (dirty_href.find("lpse.") == -1) and (dirty_href.find("eproc.") == -1) ):
                                valid = 0
                            if valid == 1:
                                ar_href = dirty_href.split("/")
                                lpse = ar_href[2].replace("/", "").strip()
                                if lpse not in list_lpse:
                                    list_lpse.append(lpse)
                                    fp.write(lpse + "\n")
                                    print("----------------------- " + lpse)
        fp.close()
        StopBrowser(driver)

    except Exception as e:
        raise


def InitBing():
    try:
        print("[+] init bing ...")
        ua = "?"
        ua = RandomUa()
        opts = webdriver.ChromeOptions()
        opts.add_argument('headless')
        opts.add_argument('--user-agent=' + ua)
        driver = webdriver.Chrome(chrome_options=opts)

        return driver

    except Exception as e:
        raise


if __name__ == "__main__":
    Main()
