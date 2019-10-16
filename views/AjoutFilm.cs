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
    public partial class AjoutFilm : MetroFramework.Forms.MetroForm
    {
        Method me = new Method();
        Model m = new Model();
        public AjoutFilm()
        {
            InitializeComponent();
        }

        private void AjoutFilm_Load(object sender, EventArgs e)
        {

            String idfilm = "FI-" + me.refGen(8);
            metroIdFilm.Text = idfilm;
        }

      
        private void bunifu_Click(object sender, EventArgs e)
        {
            String films = "Films";
            String disponibilites = "Disponibilites";
            String idfilm = metroIdFilm.Text;
            String titre = metroTitre.Text;
            String qal = metroQualite.Text;
            String prix = metroPrix.Text;
            String qte = numericUpDown1.Value.ToString();

            m.insertion(films, "IdFilm,Titre", " '" + idfilm + "','" + titre + "' ");
            m.insertion(disponibilites, "IdFilm,NomQualite,NbExemplaire", " '" + idfilm + "','" + qal + "', '" + qte + "' ");
        }
    }
}
;