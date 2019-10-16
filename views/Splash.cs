using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ijery.views
{
    public partial class Splash : Form
    {
        public Splash()
        {
            Thread t = new Thread(new ThreadStart(SplashS));
            t.Start();
            InitializeComponent();
            String str = String.Empty;
            for (int i = 0; i < 10000; i++) {
                str += i.ToString(); 
            }
            t.Abort();
        }

        void SplashS()
        {
            SplashScreen.SplashForm  sp = new SplashScreen.SplashForm();
            sp.AppName = "ijery";
            Application.Run(sp);
        }
    }
}
