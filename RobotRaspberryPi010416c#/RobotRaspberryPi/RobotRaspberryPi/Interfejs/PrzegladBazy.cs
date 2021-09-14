using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotRaspberryPi.bazaDanych;

namespace RobotRaspberryPi.Interfejs
{
    public partial class PrzegladBazy : Form
    {
        public PrzegladBazy()
        {
            InitializeComponent();
        }
        private void PrzegladBazy_Load(object sender, EventArgs e)
        {
            
            combxTabele.Items.AddRange(new object[] {"Pomiary","Sekwencje ruchów"});//dodane elementy do comboBoxa
            combxTabele.SelectedIndex = 0;//wyswietla sie pierwszy(zerowy) element z combo
        }

        DBConnect daneZbazy = new DBConnect();

        private void combxTabele_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combxTabele.SelectedIndex == 0)
            {
                String query = "SELECT pomiary.idPomiary, nazwypomiarow.NazwaPomiaru, pomiary.data, pomiary.godzina, pomiary.wartosc1, pomiary.wartosc2, pomiary.wartosc3, pomiary.wartosc4, czujniki.nazwaCzujnika FROM pomiary INNER JOIN nazwypomiarow ON pomiary.NazwyPomiarow_idNazwy = nazwypomiarow.idNazwy INNER JOIN czujniki ON pomiary.Czujniki_idCzujniki = czujniki.idCzujniki ORDER BY pomiary.idPomiary";
                daneZbazy.SelectDGV(query);
            }
            if (combxTabele.SelectedIndex == 1)
            {
                String query = "SELECT * FROM sekwencjeruchow";
                daneZbazy.SelectDGV(query);
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Delete usun = new Delete();
            string zaznaczonyWiersz = dgvPrzeglad.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(zaznaczonyWiersz);
            if (combxTabele.SelectedIndex == 0)
            {
                usun.DeletePomiar(id);
            }
            if (combxTabele.SelectedIndex == 1)
            {
                usun.DeleteSekwencje(id);
            }
        }


        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            if (combxTabele.SelectedIndex == 0)
            {
                String query = "SELECT pomiary.idPomiary, nazwypomiarow.NazwaPomiaru, pomiary.data, pomiary.godzina, pomiary.wartosc1, pomiary.wartosc2, pomiary.wartosc3, pomiary.wartosc4, czujniki.nazwaCzujnika FROM pomiary INNER JOIN nazwypomiarow ON pomiary.NazwyPomiarow_idNazwy = nazwypomiarow.idNazwy INNER JOIN czujniki ON pomiary.Czujniki_idCzujniki = czujniki.idCzujniki ORDER BY pomiary.idPomiary";
                daneZbazy.Retrieve(query);
            }
            if (combxTabele.SelectedIndex == 1)
            {
                String query = "SELECT * FROM sekwencjeruchow";
                daneZbazy.Retrieve(query);
            }
        }

        private void kopiujDoSchowka()
        {
            dgvPrzeglad.SelectAll();
            DataObject dataObject = dgvPrzeglad.GetClipboardContent();
            if (dataObject != null)
                Clipboard.SetDataObject(dataObject);

        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            kopiujDoSchowka();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }
        }
    }

