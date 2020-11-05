#!/usr/bin/python -W ignore::DeprecationWarning
try:
    import cv2
except:
    print ("[-] Sorry sir ! please install python opencv !")
import sys, os, getopt
try:
    import numpy as np
except:
    print ("[-] Sorry sir ! please install numpy !")
try:
    import config
except:
    print ("[-] Sorry sir ! config.py not found  !")
    
def cv_blurcheck(frame, treshold):
    try:
        selisih = 0
        blur_or_not = "sharp"
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
        lapl = cv2.Laplacian(gray, cv2.CV_64F).var()
        if lapl < treshold:
            blur_or_not = "blur"
            selisih = treshold - lapl
        else:
            selisih = lapl - treshold
        return blur_or_not, selisih
    except:
        print ("[-] there's an error executing function blur check, sorry !")
        pass

def cv_get_img_property(img, print_res):
    height, width, channels = img.shape
    if print_res == 1:  
        print ("[+] We got image height: " + str(height))
        print ("[+] We got image width: " +  str(width))
    return width, height
    
def cv_convert_selisih_to_percentage(selisih):
    persen = selisih /  10
    return persen
    
def _check_black(img, max_treshold, width, height):
    retme = 0
    str_coor = []
    count = 0
    y = 0
    while y < (width - 1):
        x = 0
        while x < (height - 1):
            if ((img[x, y][0] < 10) or (img[x, y][1] < 10) or (img[x, y][2] < 10)):       
                count = count + 1
                if count > max_treshold:
                    retme = 1
                    break
            x = x + 1
        y = y + 1
    return retme


def _cropped(img, width, height, crop_percentage):
    '''
    cropped = img[y1:y2, x1:x2]
    The (x1, y1) would be the top left corner and the (x2, y2) the bottom right.
    '''
    reduce_x = crop_percentage * width
    reduce_y = crop_percentage * height
    x1 = int(0 + reduce_x)
    y1 = int(0 + reduce_y)
    x2 = int(width - reduce_x)
    y2 = int(height - reduce_y)
    cropped = img[y1:y2, x1:x2]
    return cropped
 

def _process_main(file_path):
    if (".jpg" in file_path) or (".jpeg" in file_path) or (".png" in file_path) or (".gif" in file_path) or (".bmp" in file_path):
        print ("\n====================================================\n")
        print ("[+] Checking file : " + file_path)
        img = cv2.imread(file_path)     
        width, height = cv_get_img_property(img, 1)
        # cropping 19% of image */
        crop_percentage = config.cfg_crop_percentage / 100.0 
        img = _cropped(img, width, height, crop_percentage)
        width, height = cv_get_img_property(img, 0)
        if width > 640:
            # resizing image to make it easier to process */
            img = cv2.resize(img, (640, 480),  interpolation = cv2.INTER_AREA) 
            width, height = cv_get_img_property(img, 0)
        # when 90 % of pixels are dark will be considered as black image */
        max_treshold = (640 * 480) * (config.cfg_max_black_percentage / 100.0) 
        black = _check_black(img, max_treshold, width, height)
        if black == 1:
            print ("[-] Whooops our image contains 90% of dark pixels nearly black :-(")
        else:
            # looks like our image is not nearly dark totally, let's process */
            res, selisih = cv_blurcheck(img, config.cfg_blur_treshold)
            persen = "%.2f" % cv_convert_selisih_to_percentage(selisih)
            print ("[+] Checking result found that image is : "  + res)
            print ("[+] Checking percentage around :" + str(persen) + " %")

def _process_directory(dir_name):
    dirs = os.listdir(dir_name)
    for file in dirs:
        file_path = dir_name + "/" + file
        _process_main(file_path)
     
def _usage():
    print ("\t************************************************************************************************************")
    print ("\t[+] Rsharp - Simple image sharpness analyzer by : Antonius (www.ringlayer.net - www.ringlayer.com)")
    print ("\t[+] Usage:")
    print ("\t\t " + sys.argv[0] +" -f <img>")
    print ("\t\t " + sys.argv[0] +" -d <dir>")
    print ("\t[+] Example usages :")
    print ("\t\t Specifying an image as input file, e.g : " + sys.argv[0] + " -f file_image_path_name")
    print ("\t\t Specifying a directory which contains some images, e.g : " + sys.argv[0] + " -d directory_with_images_name")
    print ("\t\t Specifying my_file.jpg as input file, e.g : " + sys.argv[0] + " -f my_file.jpg")
    print ("\t\t Specifying my_image_dir which contains some images, e.g : " + sys.argv[0] + " -d my_image_dir")
    
    print ("\t************************************************************************************************************")
    sys.exit()
    
def main(argv):
    try:
        opts, args = getopt.getopt(sys.argv[1:], 'f:d:h', ['file=', 'dir=', 'help'])
    except getopt.GetoptError:
        _usage()
    file_path = ""
    dir_name = ""
    for opt, arg in opts:
        if opt in ('-h', '--help'):
            _usage()
        elif opt in ('-f', '--file'):
            file_path = arg
        elif opt in ('-d', '--dir'):
            dir_name = arg
        else:
            _usage()
    if (len(file_path) < 1) and (len(dir_name) < 1):
        _usage()
    else:
        if (len(dir_name) > 0):
            _process_directory(dir_name)
        elif (len(file_path) > 0):
            if (".jpg" in file_path) or (".jpeg" in file_path) or (".png" in file_path) or (".gif" in file_path) or (".bmp" in file_path):
                _process_main(file_path)
            else:
                _usage()
        else:
            _usage()
    
if __name__ == "__main__":
    main(sys.argv)
    