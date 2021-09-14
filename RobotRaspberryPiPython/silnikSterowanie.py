import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BOARD)
# st1
BIA1 = 11 
BIB1 = 13
AIA1 = 29
AIB1 = 31
# st2
BIA2 = 16 
BIB2 = 18
AIA2 = 33
AIB2 = 35

#wartosc PWM
speedMAX = 100
speedMN = 15              

sleepT = 1.453

def setupMain():
        GPIO.setmode(GPIO.BOARD)
        GPIO.setup(AIA1, GPIO.OUT) # ustawienie pinow na wyjscia - beda przesylane do nich dane z Raspberry
        GPIO.setup(AIB1, GPIO.OUT)
        GPIO.setup(AIA2, GPIO.OUT)
        GPIO.setup(AIB2, GPIO.OUT)
        
        GPIO.setup(BIA1, GPIO.OUT) 
        GPIO.setup(BIB1, GPIO.OUT)
        GPIO.setup(BIA2, GPIO.OUT)
        GPIO.setup(BIB2, GPIO.OUT)
     
def doPrzodu():
        setupMain()
        #prawy PWMy
        PpwmBIA1=GPIO.PWM(BIA1,50) #czestotliwosc sygnalu na PWM to 50Hz
        PpwmAIB1=GPIO.PWM(AIB1,50) 
        
        #lewy
        LpwmAIA2=GPIO.PWM(AIA2,50)
        LpwmBIA2=GPIO.PWM(BIA2,50)

        GPIO.output(AIA1,0)
        GPIO.output(AIB2,0)
        GPIO.output(BIB1,0)
        GPIO.output(BIB2,0)
        
        LpwmAIA2.start(speedMAX)
        PpwmAIB1.start(speedMAX)
        LpwmBIA2.start(speedMAX)
        PpwmBIA1.start(speedMAX)
        
        time.sleep(sleepT)
        
        PpwmAIB1.stop()
        LpwmAIA2.stop()
        PpwmBIA1.stop()
        LpwmBIA2.stop()
        GPIO.cleanup()
        
def doTylu():
        setupMain()
        
        PpwmBIB1=GPIO.PWM(BIB1,50)
        PpwmAIA1=GPIO.PWM(AIA1,50) 
        
        LpwmAIB2=GPIO.PWM(AIB2,50)
        LpwmBIB2=GPIO.PWM(BIB2,50)
        
        PpwmAIA1.start(speedMAX)
        LpwmAIB2.start(speedMAX)
        PpwmBIB1.start(speedMAX)
        LpwmBIB2.start(speedMAX)
        
        GPIO.output(AIB1,0)
        GPIO.output(AIA2,0)
        GPIO.output(BIA1,0)
        GPIO.output(BIA2,0)
        
        time.sleep(sleepT)
        
        PpwmAIA1.stop()
        LpwmAIB2.stop()
        PpwmBIB1.stop()
        LpwmBIB2.stop()
        GPIO.cleanup()
	
def wLewo():
        setupMain()
        PpwmBIA1=GPIO.PWM(BIA1,50)
        PpwmAIB1=GPIO.PWM(AIB1,50) 
        
        LpwmAIA2=GPIO.PWM(AIA2,50)
        LpwmBIA2=GPIO.PWM(BIA2,50)
        
        GPIO.output(AIA1,0)
        GPIO.output(AIB2,0)
        GPIO.output(BIB1,0)
        GPIO.output(BIB2,0)
        
        LpwmAIA2.start(speedMN)
        PpwmAIB1.start(speedMAX)
        LpwmBIA2.start(speedMN) 
        PpwmBIA1.start(speedMAX)
        
        time.sleep(sleepT)
        
        PpwmAIB1.stop()
        LpwmAIA2.stop()
        PpwmBIA1.stop()
        LpwmBIA2.stop()
        
        GPIO.cleanup()

def wPrawo():
        setupMain()
        PpwmBIA1=GPIO.PWM(BIA1,50)
        PpwmAIB1=GPIO.PWM(AIB1,50)
        
        LpwmAIA2=GPIO.PWM(AIA2,50)
        LpwmBIA2=GPIO.PWM(BIA2,50)
        
        GPIO.output(AIA1,0)
        GPIO.output(AIB2,0)
        GPIO.output(BIB1,0)
        GPIO.output(BIB2,0)
        
        LpwmAIA2.start(speedMAX)
        PpwmAIB1.start(speedMN)
        LpwmBIA2.start(speedMAX)
        PpwmBIA1.start(speedMN)
        
        time.sleep(sleepT)
        
        PpwmAIB1.stop()
        LpwmAIA2.stop()
        PpwmBIA1.stop()
        LpwmBIA2.stop()
        GPIO.cleanup()

