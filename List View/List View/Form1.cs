using System.Data;
using System.Data.SqlClient;

namespace List_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.SmallImageList = imageList1;
            listView1.LargeImageList = imageList2; 

            listView1.BeginUpdate();

            listView1.Alignment = ListViewAlignment.Left;
            listView1.AutoArrange = true;

            listView1.Columns.Add("Manga", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Author", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Running from", 150, HorizontalAlignment.Left);

            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\Documents\Mangas.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connstr);

            string query = "SELECT * FROM Manga";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            //number of mangas in table is dt.Rows.Count\
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem it = new ListViewItem();

                it.ImageIndex = i;
                it.Text = dt.Rows[i][0].ToString();
                it.SubItems.Add(dt.Rows[i][1].ToString());
                it.SubItems.Add(dt.Rows[i][2].ToString());
                listView1.Items.Add(it);
            }
            

            listView1.EndUpdate();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listView1.GridLines = true;
            }
            else
            {
                listView1.GridLines = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
            checkBox1.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
            checkBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
            checkBox1.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
            checkBox1.Enabled = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            checkBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
