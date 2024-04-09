using System.Data.SqlClient;

namespace Check_DB_Connection
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\Documents\Users.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(connstr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                textBox1.Text = "Server: " + conn.ServerVersion + " Connection state: " + conn.State.ToString();

            }
            catch (Exception err)
            {
                textBox1.Text = "Error while trying to read the databse:" + err.Message;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Close();
            textBox1.Text = "Stare conexiune: " + conn.State.ToString();
        }
    }
}
