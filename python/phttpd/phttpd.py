#!/usr/bin/env python3

'''
Simple httpd by : Antonius Robotsoft

https://github.com/antoniusrobotsoft
'''
import sys, os, re, socket, mimetypes,logging, time, logging, hashlib
from http.server import BaseHTTPRequestHandler, HTTPServer
from datetime import datetime
from os.path import exists
import config
from sys import argv
from stopit import SignalTimeout as Timeout


list_regex_incoming = []
list_redirect = []


class S(BaseHTTPRequestHandler):
    
    def CreateViewDir(self, dir_path):
        length = 0
        response = "<html><head><title>index of "+dir_path+"</title></head><body><br><h2>index of "+dir_path+"</h2><br>"
        res = []
        try:
            for path in os.listdir("web/" + dir_path):
                response +=  "<a href='"+path+"'>" + path + "</a><br><hr>" 
        except Exception as e:
            raise e
        response += "</body></html>"
        length = len(response)
        return response, length
        
    def CreateLog(self, length, ret):
        try:
            print("[+] CreateLog")
            
            #ip - - [datetime.now()] "GET / HTTP/1.1" 200 content_length

            ip = self.client_address[0]
            current_time = datetime.now()
            request_line = self.requestline
            
            print("[+] ip : " + str(ip))
            print("[+] requestline: " + request_line)
            print("[+] ret : " + str(ret))
            print("[+] content length : " + str(length))
            
            strlog = ip + " - - [" + str(current_time) + '] "' + str(request_line) + '" ' +  str(ret) + " " + str(length);
            with open('logs/access.log', 'a') as f:
                f.write(strlog)
                f.write("\n")
            
        except Exception as e:
            raise e
        
    def CheckCondition(self, ret, last_modified, etag):
        try:
            print("[+] check the condition header")
            '''
            CONDITIONS :
            - If-Modified-Since
            - If-Unmodified-Since
            - If-Match
            - If-None-Match
            '''
            
            etag = etag.replace('"', "")
            
            #- If-Modified-Since
            cond_if_modified_since = self.headers.get('If-Modified-Since', "")
            if len(cond_if_modified_since) > 0:
                print("[+] got header If-Modified-Since : " + str(cond_if_modified_since))
                formatted_cond_if_modified_since = time.strptime(cond_if_modified_since, "%Y-%m-%d")
                formatted_last_modified = time.strptime(last_modified, "%Y-%m-%d")
                if formatted_last_modified >= formatted_cond_if_modified_since:
                    ret = 200
                else:
                    ret = 304
            
            cond_if_unmodified_since = self.headers.get('If-Unmodified-Since', "")
            if len(cond_if_unmodified_since) > 0:
                print("[+] got header If-Unmodified-Since : " + str(cond_if_unmodified_since))
                formatted_cond_if_modified_since = time.strptime(cond_if_unmodified_since, "%Y-%m-%d")
                formatted_last_modified = time.strptime(last_modified, "%Y-%m-%d")
                if formatted_last_modified <= formatted_cond_if_modified_since:
                    ret = 200
                else:
                    ret = 412
            
                

            cond_if_match = self.headers.get('If-Match', "")
            if len(cond_if_match) > 0:
                print("[+] got header If-Match : " + str(cond_if_match))
                cond_if_match = cond_if_match.replace('"', "")
                if etag == cond_if_match:
                    ret = 200
                else:
                    ret = 412
            
            cond_if_none_match = self.headers.get('If-None-Match', "")
            if len(cond_if_none_match) > 0:
                print("[+] got header If-None-Match : " + str(cond_if_none_match))
                cond_if_none_match = cond_if_none_match.replace('"', "")
                if etag != cond_if_none_match:
                    ret = 200
                else:
                    ret = 412
            
            
            return ret
            
        except:
            raise
        
    def _set_response(self, ret, response = "", mode = "", mime = "", file_path = "", length=0):
        try:
            ar_num = 0
            is_directory = 0
            last_modified = ""
            full_date = self.GetDate()
            rawdata = ""
            found_regex = 0
            regex_redirect = ""
            global list_regex_incoming
            global list_redirect

            
            print("[+] SET_RESPONSE")
            last_modified = self.GetLastModified(file_path)
            etag = '"' + str( hashlib.md5(file_path.encode()).hexdigest() ) + '"'
            ret = self.CheckCondition(ret, last_modified, etag)
            
            requestline = str(self.raw_requestline, 'iso-8859-1')
            requestline = requestline.rstrip('\r\n')
            self.requestline = requestline
            words = requestline.split()
            if (words[2] != "HTTP/1.1"):
                ret = 505
            if file_path.find("//") != -1:
                file_path.replace("//", "/")
                
                
            '''
            START REGEX
            global list_regex_incoming
            global list_redirect
            
            found_regex = 0
            regex_redirect = ""
            '''
            for incoming_pattern in list_regex_incoming:
                print("[+] incoming : " + incoming_pattern)
                
                result = re.match(incoming_pattern, file_path)
                if result:
                    found_regex = 1
                    regex_redirect = list_redirect[ar_num]
                    break
                ar_num = ar_num + 1
            
            if found_regex == 1:
                if regex_redirect.find("302:") != -1:
                    ret = 302
                else:
                    ret = 301
                
                regex_redirect = regex_redirect.replace("301:","")
                regex_redirect = regex_redirect.replace("302:","")
            
                
            '''
            EOF REGEX
            '''  
                
                
            #not a virtual path
            if file_path.find(".well-known/access.log") == -1:
                tmp_path = file_path.replace("web/", "").replace("//", "/")
                cmd = "file web/" + tmp_path
                print("[+] executing cmd : " + cmd)
                rawdata = os.popen(cmd).read()
                print("[+] cmd result : " + rawdata)
                if rawdata.find("No such file or directory") != -1:
                    ret = 404
                elif rawdata.find(": directory") != -1:
                    mime = "text/html"
                    print("[+] w00t ! GOT A DIRECTORY !")
                    is_directory = 1
                    print("[+] checking last character of file_path :" + file_path)
                    if file_path[-1] != "/":
                        print("[+] directory file_path :" + file_path + " adding /")
                    
                        ret = 301
                    else:
                        ret = 200
                        response, length = self.CreateViewDir(tmp_path)
            
            self.send_response(ret)
            if ret == 301 or ret == 302:
                tmp_path = file_path.replace("web/", "")
                if tmp_path[-1] != "/":
                    self.send_header('Location', tmp_path + "/")
              
                
            host = self.headers.get('Host', "")
            self.send_header('Host', host)
            self.send_header('Content-Type', mime)
            if (mode == "OPTIONS"):
                content_length = 0
            else:
                content_length = len(response)
            self.send_header('Content-Length', length)
            self.send_header('Last-Modified', last_modified)
            
            conntype = self.headers.get('Connection', "")
            if conntype == "close":
                self.send_header('Connection', 'close')
            else:
                self.send_header('Connection', 'keep-alive')
            self.send_header('ETag', etag)
                
                
            if (mode == "OPTIONS"):
                self.send_header('Allow', 'GET, HEAD, OPTIONS, TRACE')
            
            self.end_headers()
            
            return ret, is_directory, response
        except Exception as e:
            raise e
        
    def GetDate(self):
        try:
            fdate = datetime.now()
            current_time = fdate.strftime("%a, %d %b %Y %H:%M:%S")
            
            return current_time
        except Exception as e:
            raise e
        
    def GetLastModified(self, file_path):
        try:
            last_modified = ""
            virtual = 0
            
            print("[+] get last modified of : " + file_path)
            if file_path.find(".well-known/access.log") != -1:
                virtual = 1    
            if exists(file_path) or virtual == 1:
                print("[+] start get last modified from file : " + file_path)
                if file_path.find(".well-known/access.log") != -1:
                    dirty = os.popen("stat logs/access.log |  grep Modify").read().replace("Modify: ","").strip()
                else:
                    dirty = os.popen("stat " + file_path + " |  grep Modify").read().replace("Modify: ","").strip()
                ar_dirty = dirty.split(" ")
                last_modified = ar_dirty[0].strip()
            return last_modified
        except:
            raise
 
    def GetNon200Response(self, ret):
        result = ""
        try:
            if ret != 200 and ret != 302:
                with open("response/" + str(ret) + ".html") as f:
                    result = f.read()
                
        except Exception as e:
            raise e
        return result
        
    def GetFileLength(self, file_path):
        try:
            virtual = 0
            file_exists = 0
            length = 0
            file_exists = exists(file_path)
            print("[+] at GetFileLength , file_path : " + file_path)
            if file_exists is False:
                if file_path.find(".well-known/access.log") != -1:
                    file_exists = 1
                    virtual = 1
                    
            print("[+] get file length of : " + file_path)
            if file_exists:
                if virtual == 1:
                    print("[+] virtual")
                    dirty = os.popen("wc -c logs/access.log").read()
                    ar_dirty = dirty.split(" ")
                    length = ar_dirty[0]
                    file_exists = 1
                else:
                    print("[+] non virtual")
                    dirty = os.popen("wc -c " + file_path).read()
                    ar_dirty = dirty.split(" ")
                    length = ar_dirty[0]
                    file_exists = 1
            print("[+] Length : " + str(length))
            return file_exists, length
        except:
            raise
        
    def GetPlainFileContent(self, file_path, mime):
        result = ""
        ret_type = "plain"
        ret = 500
        file_len = 0
        plain_mime_lists = ["text/html", "application/javascript", "text/plain", "text/xml"]
        
        print("[+] GetPlainFileContent Executed")
        '''
        START WELLKNOWN
        '''
        if file_path.find(".well-known/access.log") != -1:
            print("[+] GOT ACCESS LOG !")
            print("[+] opening [" + file_path + "]")
            with open("logs/access.log", "r") as f:
                result = f.read()
                ret = 200
                '''
        EOF WELLKNOWN
        '''

        else:
            try:
                if file_path == "web//":
                    file_path = "web/" + config.default_page
                if exists(file_path):
                    print("[+] opening [" + file_path + "]")
                    try:
                        print("[+] checking mime : " + mime)
                        if mime not in plain_mime_lists:
                            ret_type = "byte"
                            with open(file_path, "rb") as f:
                                result = f.read()
                        else:
                            with open(file_path) as f:
                                result = f.read()
                        ret = 200
                    except Exception as e:
                        pass
                        ret = 403
                        #raise e
                else:
                    ret = 404
            
                isdir = os.path.isdir(file_path)
                if isdir == True:
                    ret = 301
                print("[+] got ret : " + str(ret))
            
                if ret == 404 or ret == 403 or ret == 500 or ret == 301:
                    result = self.GetNon200Response(ret)
            except Exception as e:
                raise e

        
        return ret, result, ret_type

    def RetMime(self, get_path):
        mime = "application/octet-stream"
        try:
            if get_path[-4:] == ".php" or get_path[-4:] == ".htm" or get_path[-4:] == "html" or get_path[-4:] == "HTML" or get_path[-4:] == ".HTM":
                mime = "text/html"
            elif get_path.find(".well-known/access.log") != -1:
                mime = "text/plain"
            elif get_path[-4:].find(".js") != -1:
                mime = "application/javascript"
            elif get_path[-4:] == ".txt":
                mime = "text/plain"
            elif get_path[-4:] == ".xml":
                mime = "text/xml"
            elif get_path[-4:] == ".png":
                mime = "image/png"
            elif get_path[-4:] == ".jpg" or get_path[-4:] == "jpeg":
                mime = "image/jpeg"
            elif get_path[-4:] == ".gif":
                mime = "image/gif"
            elif get_path[-4:] == ".pdf":
                mime = "application/pdf"
            elif get_path[-4:] == ".ppt" or get_path[-4:] == ".pptx":
                mime = "application/vnd.ms-powerpoint"
            elif get_path[-4:] == ".docx" or get_path[-4:] == ".doc":
                mime = "application/vnd.ms-word"
            elif (get_path[-4:] == ".mp4" or get_path[-4:] == ".wav" or get_path[-4:] == ".mp3" or get_path[-4:] == ".mpeg" or get_path[-4:] == ".ogg"):
                mime = "application/octet-stream"
            else:
                mime = "application/octet-stream"
        except Exception as e:
            raise e
        return mime
        
    def do_TRACE(self):
        try:
            length = 0
            is_directory = 0
            ret = 501
            print("[+] TRACE method called")
            
            with Timeout(config.timeout) as timeout_ctx:
                ret, is_directory, response = self._set_response(ret, response, "TRACE", "text/html", "", 0)
                response = self.GetNon200Response(ret)
                self.wfile.write(response.encode('utf-8'))
            
            strlog = "TRACE request,\nPath: %s\nHeaders:\n%s\n", str(self.path), str(self.headers)
            logging.info(strlog)
            
            self.CreateLog(length, ret)
        except Exception as e:
            raise e

    def do_OPTIONS(self):
        try:
            print("[+] OPTIONS method called from httpd.py")
            ret = 200
            length = 0
            get_path = str(self.path)
            if get_path.find("web/") == -1:
                get_path = "web/" + str(self.path)
            if get_path == "web//":
                get_path = "web/" + config.default_page
            
            if len(get_path) > 256:
                ret = 400
                response = self.GetNon200Response(ret)
            else:
                
                file_exists, length = self.GetFileLength(get_path)
                if file_exists == 1:
                    ret = 200
                else:
                    ret = 404
            
            with Timeout(config.timeout) as timeout_ctx:
                ret, is_directory, response = self._set_response(ret, "", "OPTIONS", "text/html", get_path, length)
            
            strlog = "OPTIONS request,\nPath: %s\nHeaders:\n%s\n", str(self.path), str(self.headers)
            logging.info(strlog)
            
            self.CreateLog(length, ret)
        except Exception as e:
            raise e

    def do_HEAD(self):
        try:
            length = 0
            file_exists = 0
            ret = 0
            response = ""
            print("[+] HEAD method called from httpd.py")
            get_path = str(self.path)
            
            
            if get_path.find("web/") == -1:
                get_path = "web/" + str(self.path)
            if get_path == "web//":
                    get_path = "web/" + config.default_page
            if len(get_path) > 256:
                ret = 400
                response = self.GetNon200Response(ret)
            else:
                
                file_exists, length = self.GetFileLength(get_path)
                if file_exists == 1:
                    ret = 200
                else:
                    ret = 404
             
            with Timeout(config.timeout) as timeout_ctx:
                ret, is_directory, response = self._set_response(ret, response, "HEAD", "text/html", get_path, length)
            
            strlog = "HEAD request,\nPath: %s\nHeaders:\n%s\n", str(self.path), str(self.headers)
            logging.info(strlog)
            
            self.CreateLog(length, ret)
        except Exception as e:
            raise e
        
    def do_GET(self):
        try:
            is_directory = 0
            invalid = 0
            length = 0
            response = ""
            mime = "application/octet-stream"
            get_path = str(self.path)
            ar_num = 0
            
            
            if get_path.find("web/") == -1:
                get_path = "web/" + str(self.path)
                
                
            if get_path == "web//":
                get_path = "web/" + config.default_page
            
            '''
            START VALIDATION
            '''
            if str(self.path).find("../") != -1:
                ret = 400
                invalid = 1
            if len(get_path) > 256:
                ret = 400
                invalid = 1
            '''
            END VALIDATION
            '''
            
            
            if invalid == 1: 
                response = self.GetNon200Response(ret)
            else:
                file_exists, length = self.GetFileLength(get_path)
                if file_exists != 1:
                    ret = 404
                else:
                    ret = 200
                    #get mime
                    mime = self.RetMime(get_path)

                    print("[+] mime : " + mime)
                    
                    ret, response, ret_type = self.GetPlainFileContent(get_path, mime)
                with Timeout(config.timeout) as timeout_ctx:
                    ret, is_directory, response = self._set_response(ret, response, "GET", mime, get_path, length)
                    if ret != 200:
                        response = self.GetNon200Response(ret)
                        self.wfile.write(response.encode('utf-8'))
                    else:
                        if is_directory == 1:
                            print("[+] viewing directory")
                            self.wfile.write(response.encode('utf-8'))
                            
                        else:
                            if ret_type == "byte":
                                print("[+] got byte mime")
                                try:
                                    self.wfile.write(response)
                                except:
                                    pass
                            else:
                                print("[+] got plain mime")
                                try:
                                    self.wfile.write(response.encode('utf-8'))
                                except:
                                    pass
                        
                    
            strlog = "GET request,\nPath: %s\nHeaders:\n%s\n", str(self.path), str(self.headers)
            logging.info(strlog)
            
            self.CreateLog(length, ret)
            
            
        except Exception as e:
            raise e
        
def run(server_class=HTTPServer, handler_class=S, port=80):
    logging.basicConfig(filename="logs/raw.log", level=logging.DEBUG)
    server_address = ('0.0.0.0', port)
    httpd = server_class(server_address, handler_class)
    logging.info('Starting httpd...\n')
    print("Listening on 0.0.0.0 on port " + str(port))
    try:
        httpd.serve_forever()
    except KeyboardInterrupt:
        pass
    httpd.server_close()
    logging.info('Stopping httpd...\n')

def GetRegexConfig():
    global list_regex_incoming
    global list_redirect 
    
    try:
        with open("config_redirection_incoming.txt") as fp:
            list_regex_incoming = fp.readlines()
        with open("config_redirection_redirect.txt") as fp:
            list_redirect = fp.readlines()
  
    except:
        raise

if __name__ == '__main__':
    if len(argv) == 2:
        GetRegexConfig()
        run(port = int(argv[1]))
    else:
        run()
