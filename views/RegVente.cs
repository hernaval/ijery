using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ijery.core;

namespace ijery.views
{
    public partial class RegVente : MetroFramework.Forms.MetroForm
    {
        Method me = new Method();
        Model m = new Model();
        public RegVente()
        {
            InitializeComponent();
        }

        //element du combo box avec film information
        void fillCombo() { 
            String table ="Disponibilites,Films";
            String condition = "Disponibilites.IdFilm = Films.IdFilm";
            SqlDataReader dr = m.select(table, condition);

            while (dr.Read()) {
               metroComboBox1.Items.Add(dr["Titre"].ToString());
            }
            dr.Dispose();
            m.finConnection();
            
        }
        private void RegVente_Load(object sender, EventArgs e)
        {
            erreur.Text = "";
            telerreur.Text = "";
            prixLabel.Text = "";
            idfilmLabel.Text = "";
            bunifuFlatButton2.Visible = false;
            fillCombo();
            DateTime d = DateTime.Today;
            date.Text = d.ToString("yyyy-MM-dd");
            String refa ="FAC-"+me.refGen(6);
            refFacture.Text = refa;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            String tablea = "Ventes";
            String refaa = refFacture.Text;
            String idfilma = idfilm.Text;
            String tela = tel.Text;
           
            String qta = numericUpDown1.Value.ToString();
            String datea = date.Text;

            m.insertion(tablea, "Ref,IdFilm,TelephoneClient,PrixAchat,Quantite,DateAchat", " '" + refaa + "', '" + idfilma + "', '" + tela + "', '" + prixLabel.Text + "' , '" + qta + "', '" + datea + "' ");
            m.update("Disponibilites", "NbExemplaire = NbExemplaire - '" + qta + "' ", "IdFilm = '" + idfilma + "' ");
            MessageBox.Show("Vente réussi");

            qualite.Text = "";
            idfilm.Text = "";
            
        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String table = "Disponibilites,Films";
            String condition = " Disponibilites.IdFilm = Films.IdFilm and Films.Titre = '"+metroComboBox1.Text+"'  ";
            SqlDataReader dr = m.select(table, condition);

            if (dr.Read()) {
                idfilm.Text = dr["IdFilm"].ToString();
                idfilmLabel.Text = dr["IdFilm"].ToString();
                prixLabel.Text = dr["PrixFilm"].ToString();
                qualite.Text = dr["NomQualite"].ToString();

                int count = int.Parse(dr["NbExemplaire"].ToString());
                if (count == 0) {
                    bunifuFlatButton1.Enabled = false;
                    bunifuFlatButton2.Visible = true;
                    bunifuFlatButton2.BackColor = Color.Red;
                    bunifuFlatButton2.Text = "Solde out";
                }
                if (count > 0) {
                    bunifuFlatButton1.Enabled = true;
                    bunifuFlatButton2.BackColor = Color.Green;
                    bunifuFlatButton2.Text = "Dispo";
                } 

            }
            dr.Dispose();
            m.finConnection();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int qte = (int)numericUpDown1.Value;
            String table = "Disponibilites";
            String condition = "IdFilm = '"+idfilm.Text+"' ";
            SqlDataReader dr  = m.select(table, condition);
            if (dr.Read()) {
                int count = int.Parse(dr["NbExemplaire"].ToString());
                if (count < qte)
                {
                    bunifuFlatButton1.Enabled = false;
                    erreur.Text = "Quantitées insuffisantes";
                }
                else {
                    bunifuFlatButton1.Enabled = true;
                    erreur.Text = " ";
                }
            }
            dr.Dispose();
            m.finConnection();
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tel_Leave(object sender, EventArgs e)
        {
            String table = "clients";
            String function = "count";
            String fields = "TelephoneClient";
            String name = "nb";
            String condition = "TelephoneClient = '" + tel.Text + "' ";
            SqlDataReader dr = m.calcul(function, fields, name, table, condition);

            if (dr.Read()) {
                int count = int.Parse(dr["nb"].ToString());
                if (count != 1) {
                    //ajout du nouvel client
                    //modal
                    /*Form f = new AjoutClient();
                    f.Show();*/
                }
            }
            dr.Dispose();
            m.finConnection();
        }

        private void tel_KeyUp(object sender, KeyEventArgs e)
        {
            String param = tel.Text;
            Regex r = new Regex(@"[0-9]+");
            if (r.IsMatch(param) == false) {
                tel.Text = "";
                
            }
            if (param.Length != 10)  telerreur.Text = "essayer 10 chiffres";
            else telerreur.Text = "";
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            String refa = "FAC-" + me.refGen(6);
            refFacture.Text = refa;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String refa = "FAC-" + me.refGen(6);
            refFacture.Text = refa;
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            String datea = DateTime.Today.ToString("yyyy-MM-dd");
            String refaa = refFacture.Text;
            m.insertion("Factures", "Ref,DateFacture", " '" + refaa + "','" + datea + "' ");
            MessageBox.Show("Merci de votre confiance");
        }

        

        
    }
}
