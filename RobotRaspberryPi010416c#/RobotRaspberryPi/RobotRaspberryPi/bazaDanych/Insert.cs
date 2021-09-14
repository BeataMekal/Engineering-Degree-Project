using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotRaspberryPi.bazaDanych
{
    class Insert
    {
        DBConnect glownyInsert = new DBConnect();
        public void InsertNazwePomiaru(String nazwaPomiaru)
        {
            string query = "INSERT INTO NazwyPomiarow (nazwaPomiaru) VALUES ('" + nazwaPomiaru + "')";
            
            glownyInsert.Insert(query);
        }
        public void InsertPomiarJednaWartosc(String nazwaPomiaru, String wartosc1, String idCzujniki)
        {
            string query = "INSERT INTO Pomiary (NazwyPomiarow_idNazwy,data,godzina,wartosc1,Czujniki_idCzujniki) SELECT idNazwy,CURDATE(),CURTIME(),'" + wartosc1 + "','" + idCzujniki + "' FROM NazwyPomiarow WHERE nazwaPomiaru='" + nazwaPomiaru + "'"; //INSERT INTO VALUES ('" + nazwaPomiaru + "','" + dataPom + "','" + godzinaPom + "','" + wartosc1 + "','" + idCzujniki + "')";
            
            glownyInsert.Insert(query);
        }
        public void InsertPomiarTrzyWartosci(String nazwaPomiaru, String wartosc1, String wartosc2, String wartosc3, String idCzujniki)
        {
            string query = "INSERT INTO Pomiary (NazwyPomiarow_idNazwy,data,godzina,wartosc1,wartosc2,wartosc3,Czujniki_idCzujniki) SELECT idNazwy,CURDATE(),CURTIME(),'" + wartosc1 + "','" + wartosc2 + "','" + wartosc3 + "','" + idCzujniki + "' FROM NazwyPomiarow WHERE nazwaPomiaru='" + nazwaPomiaru + "'"; //INSERT INTO VALUES ('" + nazwaPomiaru + "','" + dataPom + "','" + godzinaPom + "','" + wartosc1 + "','" + idCzujniki + "')";
            
            glownyInsert.Insert(query);
        }
        public void InsertSekwencje(String nazwa, String kroki)
        {
            string query = "INSERT INTO SekwencjeRuchow (nazwa, kroki) VALUES ('" + nazwa + "','" + kroki + "')";
            
            glownyInsert.Insert(query);
        }
    }
}
