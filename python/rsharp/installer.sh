#!/bin/bash
apt-get -y update
apt-get -y install python-pip python-dev build-essential cmake
apt-get -y install libopencv-dev python-opencv
pip install --upgrade pip 
pip install numpy
pip install scipy