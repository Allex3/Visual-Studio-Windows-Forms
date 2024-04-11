using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace OJTI_2017
{
    public partial class GenerarePosterMain : Form
    {
        string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Turism.mdf;Integrated Security = True; Connect Timeout = 30";
        public GenerarePosterMain()
        {
            InitializeComponent();
        }

        private void GenerarePosterMain_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            saveFileDialog1.FileName = "defaultposter";
            saveFileDialog1.Filter = "png image|*.png";

            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Nume FROM Localitati", conn);
            var orase = cmd.ExecuteReader();
            while (orase.Read())
            {
                comboBox1.Items.Add(orase[0]); //se iau pe rand liniile
            }
            orase.Close();
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            pictureBox1.Image = null;

            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            int idlocalitatecurr = comboBox1.SelectedIndex + 1;
            //in combobox sunt in ordinea din db deci au acelasi id ca in db

            SqlCommand cmd = new SqlCommand("SELECT CaleFisier FROM Imagini WHERE idlocalitate = @idlocalitatecurr", conn);
            cmd.Parameters.AddWithValue("idlocalitatecurr", idlocalitatecurr);
            var orase = cmd.ExecuteReader();
            while (orase.Read())
            {
                comboBox2.Items.Add(orase[0]);
            }
            orase.Close();
            conn.Close();
        }

        private void adaugaimg_Click(object sender, EventArgs e)
        {
            if (comboBox2.Items.Count > 0 && comboBox2.Items.Count < 10)
            {
                if (comboBox2.SelectedItem != null)
                    listaimagini.Items.Add(comboBox2.SelectedItem);
            }
        }

        private void listaimagini_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + @"\Imagini\" + comboBox2.SelectedItem;
            
        }

        private void genpostbutton_Click(object sender, EventArgs e)
        {
            if (listaimagini.Items.Count == 0)
                return;

            int nrimg = listaimagini.Items.Count;
            int newWidth = 2000;
            int newHeight = 3200 / nrimg;
            Bitmap poster = new Bitmap(2000, 3000);
            
            for (int i=0; i<nrimg; i++)
            {
                Image img = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"\Imagini\" + listaimagini.Items[i].ToString());

                using (Graphics g = Graphics.FromImage(poster))
                {
                    g.DrawImage(img, 0, i*newHeight, newWidth, newHeight);
                }
            }

            Label titlu = new Label();
            titlu.Text = titluposter.Text;
            titlu.BackColor = Color.Transparent;
            titlu.Visible = true;
            titlu.Size = new Size(700, 100);
            Font big = new Font("Arial", 25);
            titlu.Font = big;

            titlu.DrawToBitmap(poster, new Rectangle(700, 200, 700, 100));

            PictureBox posterpb = new PictureBox();
            posterpb.Image = poster;

            posterpb.SizeMode = PictureBoxSizeMode.StretchImage;
            ImageFormat format = ImageFormat.Png;

            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {   
                posterpb.Image.Save(saveFileDialog1.FileName, format);
            }    
                
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
