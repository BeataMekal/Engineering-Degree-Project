using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using RobotRaspberryPi.bazaDanych;
using RobotRaspberryPi.Socket;
using System.Collections;
using System.Threading;

namespace RobotRaspberryPi.Interfejs
{
    public partial class Sterowanie : Form
    {
        KomSocket socket = new KomSocket();
        private bool btnNagrajSekwKlikniety = false;
        //private bool btnZatrzymajSekwKlikniety = false;
        String ostatnioWys;
        String nagrane;
        DateTime czasOstatniegoKliku;

        public Sterowanie()
        {
            InitializeComponent();
        }
     
        private void DodajKierunek(string kier)// z listą zamiast textboxa
        {
           List<string> klikniecia = new List<string>();
            if (btnNagrajSekwKlikniety)//do zrobienia!
            {
                ostatnioWys = kier;
                if (ostatnioWys != null)
                {
                    nagrane = Convert.ToString(getTime()).PadLeft(3, '0') + ","+ostatnioWys;
                    nagrane += "";//aktualizuje zmienna
                    lbSekwencja.Text += nagrane;
                    lbSekwencja.Text += ",";
                    
                }
                czasOstatniegoKliku = DateTime.Now;
                }
            }
      
            private int getTime()
            {
 	            return Convert.ToInt16(DateTime.Now.Subtract(czasOstatniegoKliku).TotalSeconds);
            }

        
        
        private void btnNsekw_Click(object sender, EventArgs e)
        {
            
            czasOstatniegoKliku = DateTime.Now;
            btnNagrajSekwKlikniety = true;

        }
        private void btnZsekw_Click(object sender, EventArgs e)//z listą zamiast textboxa
        {
            
            btnNagrajSekwKlikniety = false;
            lbSekwencja.Text += "#";
            string kuku = lbSekwencja.Text;
            string NazwaSekwencji = txtSekwencja.Text;
            var nSekwencji = new Insert();
            nSekwencji.InsertSekwencje(NazwaSekwencji, kuku);
            txtSekwencja.Text = "";
            lbSekwencja.Text = "";
      

        }

        private void btnProsto_MouseDown(object sender, MouseEventArgs e)
        {
            timerProsto.Enabled = true;
            timerProsto.Start();
            timerProsto_Tick(null, EventArgs.Empty);
        }

        private void btnProsto_MouseUp(object sender, MouseEventArgs e)
        {
            timerProsto.Enabled = false;
            timerProsto.Stop();
        }

        private void timerProsto_Tick(object sender, EventArgs e)
        {
            var wiad = socket.sendReceive("f");
            DodajKierunek(wiad);
        }

        private void timerTyl_Tick(object sender, EventArgs e)
        {
            var wiad = socket.sendReceive("b");
            DodajKierunek(wiad);
        }

        private void btnTyl_MouseDown(object sender, MouseEventArgs e)
        {
            timerTyl.Enabled = true;
            timerTyl.Start();
            timerTyl_Tick(null, EventArgs.Empty);
        }

        private void btnTyl_MouseUp(object sender, MouseEventArgs e)
        {
            timerTyl.Enabled = false;
            timerTyl.Stop();
        }

        private void timerPrawo_Tick(object sender, EventArgs e)
        {
            var wiad = socket.sendReceive("r");
            DodajKierunek(wiad);
        }

        private void btnPrawo_MouseDown(object sender, MouseEventArgs e)
        {
            timerPrawo.Enabled = true;
            timerPrawo.Start();
            timerPrawo_Tick(null, EventArgs.Empty);
        }

        private void btnPrawo_MouseUp(object sender, MouseEventArgs e)
        {
            timerPrawo.Enabled = false;
            timerPrawo.Stop();
        }

        private void timerLewo_Tick(object sender, EventArgs e)
        {
            var wiad = socket.sendReceive("l");
            DodajKierunek(wiad);
        }

        private void btnLewo_MouseDown(object sender, MouseEventArgs e)
        {
            timerLewo.Enabled = true;
            timerLewo.Start();
            timerLewo_Tick(null, EventArgs.Empty);
        }

        private void btnLewo_MouseUp(object sender, MouseEventArgs e)
        {
            timerLewo.Enabled = false;
            timerLewo.Stop();
        }


        private void btnSekwencje_Click(object sender, EventArgs e)
        {
            DBConnect daneZbazy = new DBConnect();
            String query = "SELECT nazwa,kroki FROM sekwencjeruchow";
            daneZbazy.SelectComboBox(query);
            combxSekw.SelectedIndex = 0;
        }

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {
            btnSekwencje.Enabled = true;
            btnGo.Enabled = true;
            btnLewo.Enabled = false;
            btnPrawo.Enabled = false;
            btnProsto.Enabled = false;
            btnTyl.Enabled = false;
            btnNsekw.Enabled = false;
            btnZsekw.Enabled = false;
            txtSekwencja.Enabled = false;

        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            btnSekwencje.Enabled = false;
            btnGo.Enabled = false;
            btnLewo.Enabled = true;
            btnPrawo.Enabled = true;
            btnProsto.Enabled = true;
            btnTyl.Enabled = true;
            btnNsekw.Enabled = true;
            btnZsekw.Enabled = true;
            txtSekwencja.Enabled = true;
            
        }
        String kierunek;
        List <string> kierunki = new List<string>();
        List <int> liczby = new List<int>();
        int licznik =0;
        List<string> podzieloneSekwencje = new List<string>();
        int licznikLiczb = 0;
        Int32 liczba;
        private void SzukanieCzasu()
        {
            liczba = liczby[licznikLiczb];
            timerOdczyt.Interval = 1000 * liczba;
            timerOdczyt.Enabled = true;
            timerOdczyt.Start();
            licznikLiczb++;
            if (liczba == liczby[liczby.Count - 1])
            {
                licznikLiczb = 0;
            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            var sekwencja = combxSekw.SelectedValue;
            licznikLiczb = 0;
            licznik = 0;
            lbSekwencja.Text = "";
            if (sekwencja != null)
            {
                if(podzieloneSekwencje !=null){
                podzieloneSekwencje.Clear();
                }
                string sekw = sekwencja.ToString();
                podzieloneSekwencje = sekw.Split(',').ToList();
                liczby.Clear();
                kierunki.Clear();
                

                for (int i = 0; i < podzieloneSekwencje.Count(); i++)
                {
                    string podzialkaI = podzieloneSekwencje[i];
                    if (podzialkaI.Contains("b")||podzialkaI.Contains("f")||podzialkaI.Contains("r")||podzialkaI.Contains("l")||podzialkaI.Contains("#"))
                    {
                        kierunki.Add(podzialkaI);
                    }
                    for (int j = 0; j < podzieloneSekwencje.Count(); j++)
                    {
                        string podzialkaJ = podzieloneSekwencje[j];
                        int t = 0;
                        if (Int32.TryParse(podzialkaJ, out t))// && txtCzPom.Text != "0")
                        {
                            int czas = Int32.Parse(podzialkaJ);
                            liczby.Add(czas);
                        }
                    }
                   SzukanieCzasu();

                }
            }
            else
                MessageBox.Show("Wybierz sekwencję z listy!");
        }

        private void timerOdczyt_Tick(object sender, EventArgs e)
        {
            kierunek = kierunki[licznik];
            licznik++;
            lbSekwencja.Text += timerOdczyt.Interval;
                if (kierunek == "f")
                {
                    socket.sendReceive("f");
                    lbSekwencja.Text += "f";
                    SzukanieCzasu();
                }
                if (kierunek =="r")
                 {  
                    socket.sendReceive("r");
                    lbSekwencja.Text += "r";
                    SzukanieCzasu();
                }
                if (kierunek =="b")
                {
                    socket.sendReceive("b");
                    lbSekwencja.Text += "b";
                    SzukanieCzasu();
                
                }
                if (kierunek =="l")
                {
                    lbSekwencja.Text += "l";
                    socket.sendReceive("l");
                    SzukanieCzasu();
                }

                if (kierunek =="#")
                {
                    timerOdczyt.Enabled = false;
                    timerOdczyt.Stop();
                    licznik = 0;
                    lbSekwencja.Text += "Stop";

                }
                
        }

        private void combxSekw_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = combxSekw.SelectedValue.ToString();
        }

    }
    
}
