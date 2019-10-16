using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ijery.core;

namespace ijery.views
{
    public partial class Gestion : MetroFramework.Forms.MetroForm
    {
        Model m = new Model();
        Method me = new Method();
        public Gestion()
        {
            InitializeComponent();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            metroComboBox1.Items.Add("Perte");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            String table = "Gestions";
            String date = DateTime.Today.ToString("yyyy-MM-dd");
            String motifs = motif.Text;
            String value = valeur.Text;
            String type = metroComboBox1.SelectedItem.ToString();
            m.insertion(table, "DateCompta,Type,Motif,Valeur", " '"+date+"', '"+type+"', '"+motifs+"', '"+value+"'  ");
            
        }

       
    }
}
