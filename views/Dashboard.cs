using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ijery.core;

namespace ijery.views
{
    public partial class Dashboard : Form
    {
        Model m = new Model();
        Method me = new Method();
        public Dashboard()
        {
            InitializeComponent();
        }

        void afficheFacture(String condition) {

            String table = "Factures";
            int i = 0;
            
            SqlDataReader dr = m.select(table, condition);
            factureListe.Columns.Clear();
            filmListe.Rows.Clear();

            factureListe.Columns.Add("Ref", "Ref");
            factureListe.Columns.Add("DateFacture", "DateFacture");
            factureListe.Columns.Add("IdAdmin", "IdAdmin");
            factureListe.Columns.Add("Etat", "Etat");

            while (dr.Read())
            {

                factureListe.Rows.Add();
                factureListe.Rows[i].Cells[0].Value = dr["Ref"];
                factureListe.Rows[i].Cells[1].Value = dr["DateFacture"];
                factureListe.Rows[i].Cells[2].Value = dr["IdAdmin"];
                factureListe.Rows[i].Cells[3].Value = dr["Etat"];
                ++i;
            }
            dr.Dispose();
            m.finConnection();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            bunifuFlatButton1.selected = true;
            
        }

        

        void setSelectForecolor(Bunifu.Framework.UI.BunifuFlatButton sender)
        {

            bunifuFlatButton1.Textcolor = Color.DimGray;
            bunifuFlatButton2.Textcolor = Color.DimGray;
            bunifuFlatButton3.Textcolor = Color.DimGray;
            bunifuFlatButton4.Textcolor = Color.DimGray;
            bunifuFlatButton5.Textcolor = Color.DimGray;



            sender.selected = true;
            if (sender.selected)
            {
                sender.Textcolor = Color.White;
            }




        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
            bunifuPages1.SetPage("films");


            String table = "Films";
            int i = 0;
            SqlDataReader dr = m.select(table, "1=1");
            filmListe.Columns.Clear();
            filmListe.Rows.Clear();

            filmListe.Columns.Add("IdFilm", "IdFilm");
            filmListe.Columns.Add("Titre", "Titre");

            while (dr.Read())
            {

                filmListe.Rows.Add();
                filmListe.Rows[i].Cells[0].Value = dr["IdFilm"];
                filmListe.Rows[i].Cells[1].Value = dr["Titre"];
                ++i;
            }
            dr.Dispose();
            m.finConnection();
            

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
            bunifuPages1.SetPage("Factures");

            //affichage
            afficheFacture("1=1");
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {       
            Form f = new Nouveau();
            f.Show();
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            String param = bunifuTextBox2.Text.ToUpper();
            afficheFacture("Ref like '%"+param+"%' ");
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            String test = factureListe.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(test);
        }

        private void factureListe_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];

                        // Here you can do whatever you want with the cell
                        this.factureListe.CurrentCell = clickedCell;  // Select the clicked cell, for instance

                        // Get mouse position relative to the vehicles grid
                        var relativeMousePosition = factureListe.PointToClient(Cursor.Position);

                        // Show the context menu
                        this.metroContextMenu1.Show(factureListe, relativeMousePosition);
                    }
                }

            }
        }

        private void voirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("factureView");
            
            String refFacture = factureListe.CurrentRow.Cells[0].Value.ToString();
            String table = "Ventes";
            String condition = "Ref = '" + refFacture + "'";
            int i = 0;
            factureViewList.Columns.Clear();
            factureViewList.Rows.Clear();

            factureViewList.Columns.Add("IdFilm", "IdFilm");
            factureViewList.Columns.Add("PrixAchat", "PrixAchat");
            factureViewList.Columns.Add("Quantite", "Quantite");
            factureViewList.Columns.Add("TelephoneClient", "TelephoneClient");
            refFactureN.Text = refFacture;
            //load factureView
            SqlDataReader dr = m.select(table, condition);
            while(dr.Read()){
                factureViewList.Rows.Add();
                factureViewList.Rows[i].Cells[0].Value = dr["IdFilm"].ToString();
                factureViewList.Rows[i].Cells[1].Value = dr["PrixAchat"].ToString();
                factureViewList.Rows[i].Cells[2].Value = dr["Quantite"].ToString();
                factureViewList.Rows[i].Cells[3].Value = dr["TelephoneClient"].ToString();
                ++i;
            }
            dr.Dispose();
            m.finConnection();
            
        }

        

       

       

        
        
    }
}
