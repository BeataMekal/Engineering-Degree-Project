using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotRaspberryPi.Socket;

namespace RobotRaspberryPi.Interfejs
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        KomSocket socket = new KomSocket();
        private void btnZdanymi_Click(object sender, EventArgs e)
        {
            Form formZczujnkami = new Czujniki();
            formZczujnkami.Show(); //do formatki z czujnikami

        }

        private void btnSteruj_Click(object sender, EventArgs e)
        {
            Form formSterowanie = new Sterowanie();
            formSterowanie.Show(); //do formatki z Sterowaniem
        }

        private void btnBaza_Click(object sender, EventArgs e)
        {
            Form formZbaza = new PrzegladBazy();
            formZbaza.Show(); //do formatki z czujnikami
        }

        private void btnRozlacz_Click(object sender, EventArgs e)
        {
            var wiad = socket.sendReceive("KILL");
            socket.disconnect();
            if (socket.IsConnected != true)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Rozłączono";
            }
        }

        private void btnPolacz_Click(object sender, EventArgs e)
        {
            string host = txtHost.Text;
            socket.connect(host);
            if (socket.IsConnected == true)
            {
                label1.ForeColor = Color.Green;
                label1.Text = "Połączono z serwerem";
                btnZdanymi.Enabled = true;
                btnSteruj.Enabled = true;
                btnBaza.Enabled = true;
            }
            
        }
    }
}
