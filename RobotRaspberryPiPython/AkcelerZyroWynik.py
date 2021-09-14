#!/usr/bin/python

import smbus
import math

power_mgmt_1 = 0x6b
power_mgmt_2 = 0x6c

def read_byte(adr):
    return bus.read_byte_data(address, adr)

def read_word(adr):
    high = bus.read_byte_data(address, adr)
    low = bus.read_byte_data(address, adr+1)
    val = (high << 8) + low
    return val

def read_word_u2(adr):
    val = read_word(adr)
    if (val >= 0x8000):
        return -((65535 - val) + 1)
    else:
        return val

def dist(a,b):
    return math.sqrt((a*a)+(b*b))

def get_y_rotation(x,y,z):
    radians = math.atan2(x, dist(y,z))
    return -math.degrees(radians)

def get_x_rotation(x,y,z):
    radians = math.atan2(y, dist(x,z))
    return math.degrees(radians)

bus = smbus.SMBus(1) 
address = 0x68      
bus.write_byte_data(address, power_mgmt_1, 0)

def WynikZyroX():
    gyro_xout = read_word_u2(0x43)
    reply = str(gyro_xout / 131)
    return reply

def WynikZyroY():
    gyro_yout = read_word_u2(0x45)
    reply = str(gyro_yout / 131)
    return reply

def WynikZyroZ():
    gyro_zout = read_word_u2(0x47)
    reply = str(gyro_zout / 131)
    return reply

def WynikAkcelX():
    accel_xout = read_word_u2(0x3b)
    accel_xout_s = accel_xout / 16384.0
    accel_xout_s = round(accel_xout_s,2)
    reply = str(accel_xout_s)
    return reply

def WynikAkcelY():
    accel_yout = read_word_u2(0x3d)
    accel_yout_s = accel_yout / 16384.0
    accel_yout_s = round(accel_yout_s,2)
    reply = str(accel_yout_s)
    return reply

def WynikAkcelZ():
    accel_zout = read_word_u2(0x3f)
    accel_zout_s = accel_zout / 16384.0
    accel_zout_s = round(accel_zout_s,2)
    reply = str(accel_zout_s)
    return reply
