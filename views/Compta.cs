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
    public partial class Compta : MetroFramework.Forms.MetroForm
    {
        Method me = new Method();
        Model m = new Model();
        public Compta()
        {
            InitializeComponent();
        }

        public int somme(NumericUpDown n, int i) {
            int[] constant = new int[5]{20000,10000,5000,2000,1000};
            int s = constant[i] * (int) n.Value ;

            return s;
        }

        public void afficheRecette() {
            int s = somme(numericUpDown1, 0) + somme(numericUpDown2, 1) + somme(numericUpDown3, 2) + somme(numericUpDown4, 3) + somme(numericUpDown5, 4);
            int d = int.Parse(depense.Text);
            recette.Text = s.ToString();
            int total =  int.Parse(totale.Text);
            if (total == s+d)
            {
                recette.BackColor = Color.Green;
                recette.OnHovercolor = Color.Green;
                Maj.Enabled = true;
            }
            else {
                recette.BackColor = Color.Red;
                Maj.Enabled = true;
            } 

        }

        private void Compta_Load(object sender, EventArgs e)
        {
            Maj.Enabled = false;
            Model m2 = new Model();
            String table = "Ventes";
            String name = "recette";
            String function = "sum";
            String fields = "Quantite*PrixAchat";
            String date = DateTime.Today.ToString("yyyy-MM-dd");
            String condition= "DateAchat = '"+date+"' ";
            SqlDataReader dr = m.calcul(function, fields, name, table, condition);  
            if (dr.Read()) totale.Text = dr["recette"].ToString();
            m.finConnection(); dr.Dispose();
            dr = m.calcul(function,"Valeur","depenses","Gestions","DateCompta = '"+date+"' ");
            if(dr.Read()) depense.Text = dr["depenses"].ToString();
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            afficheRecette();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            afficheRecette();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            afficheRecette();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            afficheRecette();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            afficheRecette();
        }

        private void Maj_Click(object sender, EventArgs e)
        {
            String table = "Comptabilites";
            String date = DateTime.Today.ToString("yyyy-MM-dd");
            m.insertion(table, "DateCompta", date);
            
        }

       
       

       
    }
}
