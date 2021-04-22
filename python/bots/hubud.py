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
        list_emails = []
        print("[+] main start ...")
        os.system("echo ''>emails.txt")
        fp = open("emails.txt","a+")
        driver = InitHubud()
        if (str(type(driver)).find("webdriver") != -1):
            for i in range(11, 500):
                driver.get("http://hubud.dephub.go.id/website/BandaraDetail.php?id=" + str(i))
                list_td = []
                list_td = driver.find_elements_by_tag_name('td')
                for cell in list_td:
                    if ( (cell.text.find("@") != -1) and (cell.text.find(".") != -1)):
                        list_emails.append(cell.text)
            for email in list_emails:
                fp.write(email + "\n")
            fp.close()
            StopBrowser(driver)
        else:
            print("[-] error quitting...")
            sys.exit()

    except Exception as e:
        raise


def InitHubud():
    try:
        print("[+] init hubud ...")
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
