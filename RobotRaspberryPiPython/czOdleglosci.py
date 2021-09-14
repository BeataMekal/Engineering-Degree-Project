import RPi.GPIO as GPIO
import time
GPIO.setmode(GPIO.BOARD)

def WynikOdleg():
    TRIG = 22
    ECHO = 32

    GPIO.setup(TRIG,GPIO.OUT)
    GPIO.setup(ECHO,GPIO.IN)
 
    GPIO.output(TRIG,0)
    time.sleep(0.1)
    GPIO.output(TRIG,1)
    time.sleep(0.00001)
    GPIO.output(TRIG,0)

    while GPIO.input(ECHO)== 0:
        start_impuls = time.time()

    while GPIO.input(ECHO)== 1:
        stop_impuls = time.time()
   
    czas_trw_impulsu = stop_impuls - start_impuls
    dystans = (czas_trw_impulsu * 34350)/2
    dystans = round(dystans, 1)
    reply = str(dystans)
    return reply

    GPIO.cleanup()
