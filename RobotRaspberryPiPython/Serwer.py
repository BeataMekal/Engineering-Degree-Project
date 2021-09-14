import socket
from silnikSterowanie import *
from czNatezenia import WynikNatezenie
from czTemp import  WynikTemp
#from AkcelerZyroWynik import *
from czOdleglosci import WynikOdleg

host = ''
port = 5560

def setupServer():
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
     
    print("Socket utworzony")
    try:
        s.bind((host, port))
    except socket.error as msg:
        print(msg)
    print("Polaczenie socket uworzone")
    return s
def setupConnection():
    s.listen(1) #Pozwala na jedno polaczenie na raz
    conn, address = s.accept()
    print("Polaczono z: " +address[0] + ":" + str(address[1]))
    return conn


def dataTransfer(conn):
    while True:
        #Otrzymujemy dane
        data = conn.recv(1024) #otrzymam dane
        data = data.decode('utf-8')
        #Podzeilic dane: komendy od reszty danych
        dataMessage = data.split(' ',0)
        command = dataMessage[0]
        if command =='GET$':
            reply = GET()
        elif command == 'REPEAT$':
            reply = REPEAT(dataMessage)
        elif command == 'f$':
            doPrzodu()
            reply = 'f'
        elif command == 'b$':
            doTylu()
            reply = 'b'
        elif command == 'r$':
            wPrawo()
            reply = 'r'
        elif command == 'l$':
            wLewo()
            reply = 'l'
        elif command == 'natezenie$':
            WynikNatezenie()
            reply = WynikNatezenie()
        elif command == 'temp$':
            WynikTemp()
            reply = WynikTemp()
##        elif command == 'zyroX$':
##            WynikZyroX()
##            reply = WynikZyroX()
##        elif command == 'zyroY$':
##            WynikZyroY()
##            reply = WynikZyroY()
##        elif command == 'zyroZ$':
##            WynikZyroZ()
##            reply = WynikZyroZ()
##        elif command == 'akcelX$':
##            WynikAkcelX()
##            reply = WynikAkcelX()
##        elif command == 'akcelY$':
##            WynikAkcelY()
##            reply = WynikAkcelY()
##        elif command == 'akcelZ$':
##            WynikAkcelZ()
##            reply = WynikAkcelZ()
        elif command == 'odleglosc$':
            WynikOdleg()
            reply = WynikOdleg()
        elif command == 'EXIT$':
            print("Klient nas zostawil :(")
            break
        elif command == 'KILL$': #chcemy zamknac nasz serwer
            print("serwer jest zamykany")
            s.close()
            break
        else:
            reply = 'Nieznana komenda'
        #wyslij odpowiedz do klienta
        conn.sendall(str.encode(reply))
        print("Dane zostaly wyslane")
    conn.close()

s = setupServer()

while True:
    try:
        conn = setupConnection()
        dataTransfer(conn)
    except:
        break
    
