import spidev
import time
import os

#Otwieramy SPI
spi = spidev.SpiDev()
spi.open(0,0)

#Funkcja czytajaca dane SPI z czipa MCP3008
#Kanal-channel musi byc liczba calkowita
def ReadChannel(channel):
    adc = spi.xfer2([1,(8+channel)<<4,0])
    data = ((adc[1]&3) << 8) + adc[2]
    return data
#Funkcja konwertujaca dane na poziomy napiecia
#zaokragla do okreslonej liczby miejsc po przecinku
def ConvertVolts(data,places):
    volts = (data * 3.3) / float(1023) 
    volts = round(volts,places)
    return volts

#konwersja na luksy
def ConvertLux(volts,places):
    amps = volts / float(10000)
    microamps = amps * float(1000000)
    lux = microamps * float(2)
    lux = round(lux,places)
    return lux

#definiuje kanal-channel czujnika
light_channel = 0
def WynikNatezenie():
    light_level = ReadChannel(light_channel)
    light_volts = ConvertVolts(light_level,2)
    light_lux = ConvertLux(light_volts,2)

    reply = str(light_lux)
    return reply

