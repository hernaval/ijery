using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ijery.views
{
    public partial class Nouveau : Form
    {
        public Nouveau()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            Form v = new RegVente();
            v.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Form f = new AjoutFilm();
            f.Show();
        }
    }
}
