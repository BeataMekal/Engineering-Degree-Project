using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using RobotRaspberryPi.Interfejs;
using System.Windows.Forms;

namespace RobotRaspberryPi.Socket
{
    class KomSocket
    {
        public static System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
          
        public string sendReceive(String wiadomosc)
        {
            try
            {
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = System.Text.Encoding.UTF8.GetBytes(wiadomosc + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                byte[] inStream = new byte[10025];
                serverStream.Read(inStream, 0, inStream.Length); //(int)clientSocket.ReceiveBufferSize);
                String returndata = System.Text.Encoding.UTF8.GetString(inStream);
                return returndata;
           }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                string i = "klops";
                return i;
                
            }
        }
        public void connect(string host)
        {   //pozniej najlepiej ustawianie adresu z formatki
            try
            {
                clientSocket.Connect(host, 5560); //sony: 192.168.43.14/w domu 192.168.178.46 statyczny adres raspberry pi(ustawiony w routerze), nr portu na ktorym odbywa sie komunikacja
            }
            catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void disconnect()
        {
            try
            {
            clientSocket.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool IsConnected //false-brak polaczenia, true - jest polaczenie
        {
            get
            {
                try
                {
                    if (clientSocket != null && clientSocket.Client != null && clientSocket.Client.Connected)
                    {
                        if (clientSocket.Client.Poll(0, SelectMode.SelectRead))
                        {
                            byte[] buff = new byte[1];
                            if (clientSocket.Client.Receive(buff, SocketFlags.Peek) == 0)
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
        }
    
    }
}
