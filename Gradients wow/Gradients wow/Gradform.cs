using SplashScreen.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gradients_wow
{
    public partial class Gradformmain : Form
    {
        public Gradformmain()
        {
            InitializeComponent();

            Splash();

        }

        void Splash()
        {
            Splasher spl = new Splasher("the splash");
            spl.Show();

            Thread.Sleep(1500); //HeavyMethod

            spl.Close();
        }

        private void Gradformmain_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Blue, Color.Coral, 45F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        private void Gradformmain_Load(object sender, EventArgs e)
        {

        }
    }
}
