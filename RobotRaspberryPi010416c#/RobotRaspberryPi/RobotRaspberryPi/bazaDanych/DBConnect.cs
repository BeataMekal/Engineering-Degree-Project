using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace RobotRaspberryPi.bazaDanych
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "mydb";
            uid = "root";
            password = "";

            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(String query)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        //Delete statement
        public void Delete(string queryD ,string queryR)
        {

            if (this.OpenConnection() == true && MessageBox.Show("Czy na pewno chcesz usunąć zaznaczony rekord?","USUN",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                MySqlCommand cmd = new MySqlCommand(queryD, connection);
                //cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Rekord usunięty!");
                }
                this.CloseConnection();
                Retrieve(queryR);
            }
        }

        public void Retrieve(string query)
        {
            if (this.OpenConnection() == true)
            {
                
                MySqlDataAdapter cmd = new MySqlDataAdapter(query, connection);
                DataSet DS = new DataSet();
                cmd.Fill(DS);
                DataGridView gridView = Application.OpenForms["PrzegladBazy"].Controls["dgvPrzeglad"] as DataGridView; //wyswietla bezposrednio w datagridview w PrzegladBazy
                //gridView.Rows.Clear();
                gridView.DataSource = null;
                gridView.DataSource = DS.Tables[0];
                this.CloseConnection();
            }

        }
        public void SelectDGV(String query)//dataGridView
        {
            if (this.OpenConnection() == true)
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter(query, connection);
                DataSet DS = new DataSet();
                cmd.Fill(DS);
                DataGridView gridView = Application.OpenForms["PrzegladBazy"].Controls["dgvPrzeglad"] as DataGridView; //wyswietla bezposrednio w datagridview w PrzegladBazy
                gridView.DataSource=DS.Tables[0];
                this.CloseConnection();
            }

        }
        public void SelectComboBox(String query)//combo
        {
            if (this.OpenConnection() == true)
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter(query, connection);
                DataTable DT = new DataTable();
                cmd.Fill(DT);
                ComboBox comboBox = Application.OpenForms["Sterowanie"].Controls["combxSekw"] as ComboBox; //wyswietla bezposrednio w datagridview w PrzegladBazy
                
                comboBox.DataSource = DT;//.Tables[0];
                comboBox.DisplayMember = "nazwa";//nazwa wyswietlana w comboboxie
                comboBox.ValueMember = "kroki";//wartosc pod nazwa
                this.CloseConnection();
            }

        }
        internal Selecty SelectGlowny(String nPomiaru)//porownywanie nazwPomiarow
        {
            string query = "SELECT * FROM NazwyPomiarow WHERE nazwaPomiaru='"+nPomiaru+"'";//@nPomiaru";
            Selecty pasujaceNazwy= new Selecty();


            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
               // cmd.Parameters.AddWithValue("@nazPomiaru", nPomiaru);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    pasujaceNazwy.nazwaPom = dataReader["nazwaPomiaru"].ToString();
                    //return nPomiaru;
                }

                this.CloseConnection();
                
            }
            
            return pasujaceNazwy;
        }


    
    }
}