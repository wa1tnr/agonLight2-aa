#!/usr/bin/python3

## Title:       send.py
## Author:      Jeroen Venema - reduction 'nis' on Discord 18 Nov 2023
## Created:     25/10/2022
## Last update: 11/09/2023

## syntax
## send.py FILENAME <PORT> <BAUDRATE>
## 

## Modinfo:
## 25/10/2022 initial version
## 10/09/2023 Script converts binary file to Intel Hex during transmission. 
##            Using defaults as constants.
## 11/09/2023 Wait time variable introduced for handling PC serial drivers with low buffer memory

DEFAULT_START_ADDRESS = 0x40000
DEFAULT_SERIAL_PORT   = 'COM11'
DEFAULT_BAUDRATE      = 115200
DEFAULT_LINE_WAITTIME = 0       ## A value of +/- 0.003 Helps PC serial drivers with low buffer memory

def errorexit(message):
  print(message)
  print('Press ENTER to continue')
  input()
  exit()
  return

import sys
import time
import os.path
import tempfile
import serial.tools.list_ports
try:
  import serial
except ModuleNotFoundError:
  errorexit('Please install the \'pyserial\' module with pip')
try:
  from intelhex import IntelHex
except ModuleNotFoundError:
  errorexit('Please install the \'intelhex\' module with pip')

if len(sys.argv) == 1 or len(sys.argv) >4:
  sys.exit('Usage: send.py FILENAME <PORT> <BAUDRATE>')

ihex = IntelHex()
ihex.loadbin(sys.argv[1], offset=DEFAULT_START_ADDRESS)

  # use:  ./thisprogram.py ./thissource.bin > ./thatconverted.hex

ihex.write_hex_file(sys.stdout)
