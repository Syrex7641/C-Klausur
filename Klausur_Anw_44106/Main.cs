/*
* Beschreibung: Klausuraufgabe - 44106
*
* Autor: Markus Zielke
* Last changed: 2021-11-26 09:06
* git version: master
*
* ToDo
* ----
*
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Klausur_Anw_44106
{
    public partial class frm_Bestellform : Form
    {

        DataSet bestellungenDS = new DataSet();
        DataTable bestellungenDT = new DataTable();

        string bestellungenXml = "Bestellungen3.xml";


        public frm_Bestellform()
        {
            InitializeComponent();

            if (File.Exists(bestellungenXml))
            {
                bestellungenDT.ReadXml(bestellungenXml);
            }
            else
            {

                bestellungenDT.Columns.Add("Tagnummer");
                bestellungenDT.Columns.Add("Anzahl");
                bestellungenDT.Columns.Add("Warenname");

                bestellungenDS.Tables.Add(bestellungenDT);

                dgv_Bestellform.DataSource = bestellungenDT;

            }

        }

        /*

        int customerRow = dgvCustomers.CurrentRow.Index;
        string customerName = customers.Rows[customerRow][2].ToString() + " " + customers.Rows[customerRow][1].ToString();
        int itemRow = dgvItems.CurrentRow.Index;
        string itemName = items.Rows[itemRow][1].ToString();
        string itemPrice = items.Rows[itemRow][3].ToString();

        purchases.AddPurchase(customerName, itemName, itemPrice);
            purchases.Location = new Point(this.Location.X + this.Width, this.Location.Y);
        purchases.Show();
        */

        private void dgv_Bestellform_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Bestellform_Load(object sender, EventArgs e)
        {

        }

        private void tbx_Tagnummer_TextChanged(object sender, EventArgs e)
        {



        }

        private void tbx_Anzahl_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_Warenname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                string tagnummer = tbx_Tagnummer.Text.ToString();
                int tagnummerInt = Convert.ToInt32(tagnummer.ToString());

                string anzahl = tbx_Anzahl.Text;
                int anzahlInt = Convert.ToInt32(anzahl.ToString());

                string warenname = tbx_Warenname.Text;

                if (tagnummerInt >= 1 & tagnummerInt <= 3)
                {



                    if (anzahlInt > 0 & anzahlInt <= 12)
                    {



                        if (warenname != "")
                        {



                            bestellungenDT.Rows.Add(tagnummerInt.ToString(), anzahlInt.ToString(), warenname);
                            //bestellungenDS.WriteXml("Bestellungen.xml");
                        }
                    }
                }

                tbx_Anzahl.Clear();
                tbx_Tagnummer.Clear();
                tbx_Warenname.Clear();

            }
            catch
            {
                MessageBox.Show("Es ist ein fehler aufgetreten! Falsche Eingabe?");


                tbx_Anzahl.Clear();
                tbx_Tagnummer.Clear();
                tbx_Warenname.Clear();

            }

            



        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bestellungenDT.Rows.Clear();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   bestellungenDS.WriteXml("Bestellungen1.xml");
         //auskommentiert da andernfalls Fehler 
        }

        private void verlaufToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verlaufsform verlaufsform = new Verlaufsform();
            verlaufsform.Show();
        }


        public void getData()
        {
                   

            int rowIndex = bestellungenDT.Rows.Count;
       string tagNummMaxString = bestellungenDT.Rows[1][rowIndex].ToString();
        int tagNumMaxInt = Convert.ToInt32(tagNummMaxString);
       


        //  bestellungenDT.Columns;

         }

}


}
