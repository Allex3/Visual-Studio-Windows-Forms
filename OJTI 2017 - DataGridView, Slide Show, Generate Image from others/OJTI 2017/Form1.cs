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
using System.IO;
using System.Globalization;
using System.Runtime.Remoting.Contexts;

namespace OJTI_2017
{
    public partial class TurismMain : Form
    {
        public TurismMain()
        {
            InitializeComponent();
        }

        public static string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Turism.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection conn = new SqlConnection(connstr);

        private void sterge()
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"TRUNCATE TABLE Imagini", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            cmd = new SqlCommand(@"TRUNCATE TABLE Localitati", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            cmd = new SqlCommand(@"TRUNCATE TABLE Planificari", conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();



            conn.Close();
        }

     
        private static void Initializare()
        {
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd;

            StreamReader sr = new StreamReader(Application.StartupPath + @"\Planificari.txt");
            string sir;
            char[] split = { '*' };

            conn.Open();
            DateTime dt1, dt2;


            while ((sir = sr.ReadLine()) != null)
            {
                string[] siruri = sir.Split(split);
                //siruri[i].Trim() reprezinta cuvantul i-1 de pe linia curenta
                //Trim doar sterge spatiul alb din stanga si din fata cuvantului sa ramana doar cuvantul

                //@localitate este parametrul localitate luat dintr-o linie din fisierul .txt
                //practic rn sunt in prima linie si despart cuvintele prin *, ca un strtok
                cmd = new SqlCommand(@"INSERT INTO Localitati(Nume) VALUES(@localitate)", conn);
                cmd.Parameters.AddWithValue("localitate", siruri[0].Trim());
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand(@"SELECT idlocalitate FROM localitati WHERE nume = @nume", conn);
                //numele localitatii este unic, deci id-ul pt un nume este unic
                //nu sunt mai multe id-uri cu acelasi nume de localitate
                cmd.Parameters.AddWithValue("nume", siruri[0].Trim());
                int idlocalitate = Convert.ToInt32(cmd.ExecuteScalar());
                int nrzile;
                //mai sus, nume si localitate reprezinta primul cuvant de pe linia curenta

                switch(siruri[1].Trim())
                {
                    case "ocazional":
                        string d1 = siruri[2].Trim(), d2 = siruri[3].Trim();
                        CultureInfo mor = new CultureInfo("it-IT");
                        DateTime.TryParseExact(d1, "dd.MM.yyyy", mor, System.Globalization.DateTimeStyles.None, out dt1);
                        DateTime.TryParseExact(d2, "dd.MM.yyyy", mor, System.Globalization.DateTimeStyles.None, out dt2);

                        //cele ramase sunt imagini, le inserez in db

                        int i = 4;
                        while (i < siruri.Length)
                        {
                            cmd = new SqlCommand(@"INSERT INTO Imagini(Idlocalitate, Calefisier) VALUES (@idlocalitate, @calefisier)", conn);
                            cmd.Parameters.AddWithValue("idlocalitate", idlocalitate);
                            cmd.Parameters.AddWithValue("calefisier", siruri[i].Trim());
                            cmd.ExecuteNonQuery();
                            i++;
                        }

                        //am inserat tot in Localitati si Imagini, mai am Planificari
                        cmd = new SqlCommand(@"INSERT INTO Planificari(IDLocalitate, frecventa, datastart, datastop)" +
                            " VALUES (@idlocalitate, @frecventa, @dt1, @dt2)", conn);
                        cmd.Parameters.AddWithValue("idlocalitate", idlocalitate);
                        cmd.Parameters.AddWithValue("frecventa", "ocazional");
                        cmd.Parameters.AddWithValue("dt1", dt1);
                        cmd.Parameters.AddWithValue("dt2", dt2);
                        cmd.ExecuteNonQuery();

                        break;
                    case "anual":
                        nrzile = int.Parse(siruri[2].Trim()); //daca sunt zile si nu data
                                                              //in rest la fel ca mai sus, oarecum
                        i = 3;
                        while (i < siruri.Length)
                        {
                            cmd = new SqlCommand(@"INSERT INTO Imagini(Idlocalitate, Calefisier) VALUES (@idlocalitate, @calefisier)", conn);
                            cmd.Parameters.AddWithValue("idlocalitate", idlocalitate);
                            cmd.Parameters.AddWithValue("calefisier", siruri[i].Trim());
                            cmd.ExecuteNonQuery();
                            i++;
                        }

                        cmd = new SqlCommand(@"INSERT INTO Planificari(IDLocalitate, frecventa, ziua)" +
                            " VALUES (@idlocalitate, @frecventa, @nrzile)", conn);
                        cmd.Parameters.AddWithValue("idlocalitate", idlocalitate);
                        cmd.Parameters.AddWithValue("frecventa", "anual");
                        cmd.Parameters.AddWithValue("nrzile", nrzile);
                        cmd.ExecuteNonQuery();

                        break;
                    case "lunar":
                        nrzile = int.Parse(siruri[2].Trim()); //daca sunt zile si nu data
                                                              //in rest la fel ca mai sus, oarecum
                        i = 3;
                        while (i < siruri.Length)
                        {
                            cmd = new SqlCommand(@"INSERT INTO Imagini(Idlocalitate, Calefisier) VALUES (@idlocalitate, @calefisier)", conn);
                            cmd.Parameters.AddWithValue("idlocalitate", idlocalitate);
                            cmd.Parameters.AddWithValue("calefisier", siruri[i].Trim());
                            cmd.ExecuteNonQuery();
                            i++;
                        }

                        cmd = new SqlCommand(@"INSERT INTO Planificari(IDLocalitate, frecventa, ziua)" +
                            " VALUES (@idlocalitate, @frecventa, @nrzile)", conn);
                        cmd.Parameters.AddWithValue("idlocalitate", idlocalitate);
                        cmd.Parameters.AddWithValue("frecventa", "lunar");
                        cmd.Parameters.AddWithValue("nrzile", nrzile);
                        cmd.ExecuteNonQuery();

                        break;
                }

            }
            MessageBox.Show("Initializarea a fost realizata cu succes!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sterge();
            Initializare();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form genpost = new GenerarePosterMain();
            genpost.Show();
            this.Hide();
            genpost.FormClosed += (a, b) =>
            {
                this.Show();
            };
        }

        private void vizexcursie_Click(object sender, EventArgs e)
        {
            Form vizex = new VizualizareExcursieMain();
            vizex.Show();
            this.Hide();
            vizex.FormClosed += (a, b) => { this.Show(); };
        }
    }
}
