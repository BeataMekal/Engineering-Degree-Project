using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotRaspberryPi.Socket;
using RobotRaspberryPi.bazaDanych;
using System.Timers;

namespace RobotRaspberryPi.Interfejs
{
    public partial class Czujniki : Form
    {
      
        public Czujniki()
        {
            
            InitializeComponent();
            
        }

        KomSocket socket = new KomSocket();
        DBConnect baza = new DBConnect();
        private void txtPomiary_TextChanged(object sender, EventArgs e)
        {
            txtPomiary.ScrollBars = ScrollBars.Vertical;
            txtPomiary.SelectionStart = txtPomiary.Text.Length;
            txtPomiary.ScrollToCaret();
        }

        private void btnPobierz_Click(object sender, EventArgs e)
        {
            String nazwaPomiaru = txtNazwaPom.Text;
            DBConnect baza = new DBConnect();
            if (nazwaPomiaru == "")
            {
                MessageBox.Show("Wpisz nazwę!");
                txtNazwaPom.Focus();
            }
           else
           {
               try
               {
                   timer.Enabled = true;
                   timer.Start();
                   string NazwaPomiaru = txtNazwaPom.Text;
                   var Npomiar = new Insert();
                   Npomiar.InsertNazwePomiaru(NazwaPomiaru);
                   msg("\u201E" + NazwaPomiaru + "\u201D");
                   msg("------------------------");
                   timer_Tick(null, EventArgs.Empty);//odpala timer(zbiera pomiary) od razu po kliknieciu 
               }
               catch (Exception ex)
               {
                   timer.Enabled = false;
                   MessageBox.Show(ex.Message);
                   
               }

            }
        }
        private void ZbierzPomiary()
        {
            String NazwaPomiaru = txtNazwaPom.Text;
            String CzasPomiaru = txtCzPom.Text;
            if (socket.IsConnected == false)
            {
                timer.Enabled = false;
            }
            if (chbCzSwiatla.Checked){
                var nat = socket.sendReceive("natezenie");
                var pomiar = new Insert();
                pomiar.InsertPomiarJednaWartosc(NazwaPomiaru, nat, "5");
                msg("Natężenie w lux:  " + nat);
            }
            if (chbCzTemp.Checked)
            {
                var temp = socket.sendReceive("temp");
                msg("Temperatura w *C:  " + temp);
                var pomiar = new Insert();
                pomiar.InsertPomiarJednaWartosc(NazwaPomiaru,temp, "4");
            }
            if (chbCzZyros.Checked)
            {
                var zyroX = socket.sendReceive("zyroX");
                var zyroY = socket.sendReceive("zyroY");
                var zyroZ = socket.sendReceive("zyroZ");
                msg("Żyroskop: x " + zyroX);
                msg("y " + zyroY);
                msg("z " + zyroZ);
                var pomiar = new Insert();
                pomiar.InsertPomiarTrzyWartosci(NazwaPomiaru, zyroX, zyroY, zyroZ, "3");
            }
            if (chbCzAkcel.Checked)
            {
                var akcelX = socket.sendReceive("akcelX");
                var akcelY = socket.sendReceive("akcelY");
                var akcelZ = socket.sendReceive("akcelZ");
                msg("Akcelerometr: x " + akcelX);
                msg("y " + akcelY);
                msg("z " + akcelZ);
                var pomiar = new Insert();
                pomiar.InsertPomiarTrzyWartosci(NazwaPomiaru, akcelX, akcelY, akcelZ, "2");
            }
            if (chbCzOdleg.Checked)
            {
                var odleg = socket.sendReceive("odleglosc");
                msg("Odległość w cm:  " + odleg);
                var pomiar = new Insert();
                pomiar.InsertPomiarJednaWartosc(NazwaPomiaru,odleg,"1");

            }
            if (txtCzPom.Text != null)
            {
                msg("-----------" + CzasPomiaru + "s-------------");
            }
        }
        public void msg(String mesg)
        {
            txtPomiary.Text = txtPomiary.Text + Environment.NewLine + " >> " + mesg;
        }

        
        private void btnStopPob_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
            txtNazwaPom.Text = "";
            msg("Zatrzymano pobieranie danych.");
            msg("------------------------");
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
                ZbierzPomiary();}

        private void txtCzPom_Leave(object sender, EventArgs e)
        {
            int t = 0;
            if (Int32.TryParse(txtCzPom.Text, out t) && txtCzPom.Text != "0")
            {
                int czas = Int32.Parse(txtCzPom.Text);
                timer.Interval = czas * 1000; //zamienienie milisekund na sekundy
            }
            else
            {
                MessageBox.Show("Wpisz liczbę!");
                txtCzPom.Focus();
            }
        }

        private void txtNazwaPom_Leave(object sender, EventArgs e)
        {
            String nazwaPomiaru = txtNazwaPom.Text;
            Selecty x = baza.SelectGlowny(nazwaPomiaru);
            if (nazwaPomiaru == x.nazwaPom)
            {
                MessageBox.Show("Nazwa zajęta, wybierz inną!");
                txtNazwaPom.Focus();
            }
            if (nazwaPomiaru == "")
            {
                MessageBox.Show("Wpisz nazwę!");
                txtNazwaPom.Focus();
            }
        }
        

        
       

       
    }
}
