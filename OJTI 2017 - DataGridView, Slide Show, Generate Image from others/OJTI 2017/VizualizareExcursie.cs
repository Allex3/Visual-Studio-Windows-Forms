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
using System.Globalization;
using System.Threading;

namespace OJTI_2017
{
    public partial class VizualizareExcursieMain : Form
    {

        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer { Interval = 2000 }; //2 sec
        List<Imagini> imagini = new List<Imagini>();
        private int index = -1; //numara imaginile

        public static string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Turism.mdf;Integrated Security = True; Connect Timeout = 30";
        public static DateTime datastart, dataend;
        public VizualizareExcursieMain()
        {
            InitializeComponent();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            t.Tick += (a, b) =>
            {
                if (index<imagini.Count-1)
                {
                    progressBar1.Maximum = imagini.Count - 1;
                    index++;
                    progressBar1.Value++;
                    loadForIndex();
                }
            };
        }

        private void VizualizareExcursieMain_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            SqlCommand cmd = new SqlCommand(@"SELECT l.Nume, p.DataStart, p.DataStop, p.Frecventa, p.Ziua FROM Localitati l FULL JOIN Planificari p ON l.IDLocalitate = p.IDLocalitate", conn); ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;


            conn.Close();
        }

        private async void genexc_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            datastart = Convert.ToDateTime(dateTimePicker1.Text, CultureInfo.GetCultureInfo("FR-fr"));
            dataend = Convert.ToDateTime(dateTimePicker2.Text, CultureInfo.GetCultureInfo("FR-fr"));
            SqlCommand cmd = new SqlCommand(@"SELECT l.Nume, p.DataStart, p.DataStop, p.Frecventa, p.Ziua FROM Localitati l FULL JOIN Planificari p ON l.IDLocalitate = p.IDLocalitate WHERE (p.DataStart BETWEEN @datastart AND @datastop) OR (p.DataStop BETWEEN @datastart AND @datastop) OR (p.Ziua IS NOT NULL)", conn);
            cmd.Parameters.AddWithValue("datastart", datastart);
            cmd.Parameters.AddWithValue("datastop", dataend);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataTable dtexc = new DataTable();
            adapter.Fill(dt);
            dtexc = dt.Clone();
            DataRow dr;

            conn.Close();

            //daca data de inceput a unei excursii e inainte de cea de inceput aleasa
            //atunci cea de inceput aleasa va fi pusa
            //iar daca cea de sfarsit este dupa data de sfarsit aleasa
            //atunci o pun pe cea de sfarsit fiindca acolo se termina
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                if (Convert.ToString(dr["Frecventa"]) == "ocazional") //ocazional
                {
                    DateTime drdatestart = Convert.ToDateTime(dr["DataStart"], CultureInfo.GetCultureInfo("FR-fr"));
                    if (DateTime.Compare(drdatestart, datastart) < 0)
                        dr["DataStart"] = datastart;
                    DateTime drdateend = Convert.ToDateTime(dr["DataStop"], CultureInfo.GetCultureInfo("FR-fr"));
                    if (DateTime.Compare(drdateend, dataend) > 0)
                        dr["DataStop"] = dataend;


                    dtexc.ImportRow(dr);

                }
                else if (Convert.ToString(dr["Frecventa"]) == "anual")
                {
                    //daca e anual se afiseaza in toti anii din selectie pe data sa
                    int zian = Convert.ToInt32(dr["Ziua"]);
                    int ancurr = datastart.Year;
                    int anend = dataend.Year;
                    for (int an = ancurr; an <= anend; an++)
                    {
                        DateTime date = new DateTime(an, 1, 1).AddDays(zian - 1);
                        //nu am veirifcat daca ziua anului se afla totusi intre datele excursiei
                        if (DateTime.Compare(date, datastart) < 0 || DateTime.Compare(date, dataend) > 0)
                            continue; //sarim peste linia curenta, inainte de start sau dupa end

                        //la 1 ianuarie am adaugat zian-1 zile si am ajuns in ziua curenta
                        dr["DataStart"] = dr["DataStop"] = date;
                        //pun o singura data fiindca viziteaza anual
                        dtexc.ImportRow(dr);
                    }
                }
                else // lunar
                {
                    //ca sa afisez lunar pornesc luna asta sau luna urmatoare
                    //si merg cate o luna cat pot, in fiecare an
                    int ziluna = Convert.ToInt32(dr["Ziua"]);
                    int ancurr = datastart.Year;
                    int anend = dataend.Year;
                    for (int an = ancurr; an <= anend; an++)
                    {
                        int lunastart = datastart.Month + 1;
                        if (datastart.Day < ziluna) //ziua se va atinge in prima luna a excursiei
                            lunastart = datastart.Month;
                        int lunaend = dataend.Month - 1;
                        if (dataend.Day > ziluna) //daca ziua se atinge si in ultima luna a excursiei
                            lunaend = dataend.Month;
                        for (int luna = lunastart; luna <= lunaend; luna++)
                        {
                            DateTime date = new DateTime(an, luna, ziluna);
                            dr["DataStart"] = dr["DataStop"] = date;
                            dtexc.ImportRow(dr);
                        }
                    }
                }
            }

            dtexc.Columns.Remove("Ziua");
            dataGridView2.DataSource = dtexc.DefaultView;

            //Itinerariul luand toate datele intre un intergval de date din dtexc
            //incerc toate datele intre datastart si dataend si vad daca se afla
            //intre un interval din dtexc, si pun in dtit Localitatea si o Data
            
           

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
           

            bw.RunWorkerAsync();




        }



        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            DataTable dtexc = new DataTable();
            foreach (DataGridViewColumn col in dataGridView2.Columns)
                dtexc.Columns.Add(col.Name);
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataRow drow = dtexc.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                    drow[cell.ColumnIndex] = cell.Value;
                dtexc.Rows.Add(drow);
            }
            dtexc.Rows[11].Delete();
            DataTable dtit = new DataTable();
            dtit.Columns.Add("Localitate", typeof(String));
            dtit.Columns.Add("Data", typeof(DateTime));


            for (DateTime data = datastart; DateTime.Compare(data, dataend) <= 0; data = data.AddDays(1))
            {

                foreach (DataRow row in dtexc.Rows)
                {

                    //se verifica pt fiecare excursie daca data curenta se afla in ea
                    if (DateTime.Compare(data, Convert.ToDateTime(row["DataStart"], CultureInfo.GetCultureInfo("FR-fr"))) >= 0 && DateTime.Compare(data, Convert.ToDateTime(row["DataStop"], CultureInfo.GetCultureInfo("FR-fr"))) <= 0)
                    {

                        DataRow dr = dtit.NewRow();
                        dr["Localitate"] = Convert.ToString(row["Nume"]);
                        dr["Data"] = data;
                        dtit.Rows.Add(dr);
                    }
                }
            }
            dataGridView3.DataSource = dtit.DefaultView;

            //Incarcam imaginile in slideshow pe thread-ul worker-ului
            //e mai eficient asa si e bine fiindca aici se afla dtexc
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            int[] countloc = new int[20];
            for (int i = 0; i < 20; i++)
                countloc[i] = 0;
            for (int r = 0; r<dtit.Rows.Count; r++)//parcurg itinerariul
            {
                DataRow reader = dtit.Rows[r];
                //parcurg localitatile si pozele acestora si datele
                SqlCommand cmd = new SqlCommand("SELECT IDLocalitate FROM Localitati WHERE Nume = @currloc", conn);
                cmd.Parameters.AddWithValue("currloc", reader[0].ToString()); //reader[0] -> prima coloana a randului
                int idloc = Convert.ToInt32(cmd.ExecuteScalar());
                countloc[idloc]++;
                cmd.Dispose();

                cmd = new SqlCommand("SELECT COUNT(*) FROM Imagini WHERE IDLocalitate = @idloc", conn);
                cmd.Parameters.AddWithValue("idloc", idloc);
                int numimg = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

                cmd = new SqlCommand("SELECT CaleFisier FROM Imagini WHERE IDLocalitate = @idloc", conn);
                cmd.Parameters.AddWithValue("idloc", idloc);
                DataTable imag = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(imag);
                cmd.Dispose ();

                int i = 0;
                foreach(DataRow dr in imag.Rows)
                {
                    i++;
                    if (countloc[idloc]==i)
                    {
                        imagini.Add(new Imagini
                        {
                            CaleFisier = dr[0].ToString(),
                            Localitate = reader[0].ToString(),
                            Data = reader[1].ToString()
                        }); 
                    }
                }

                
            }
            conn.Close();
            //am construit tot ce e nevoie pentru slideshow
            if (imagini.Count > 0 && index == -1)
                index = 0;

            
            loadForIndex();
        }

        private void startImagini_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        public void loadForIndex()
        { 
            pictureBox1.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + @"\Imagini\" + imagini[index].CaleFisier;
            label3.Text = imagini[index].Localitate;
            label4.Text = imagini[index].Data.Split(' ')[0];
        }

    }
}
