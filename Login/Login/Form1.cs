using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login
            string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\Documents\NewUsers.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Users WHERE Username = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'";
            SqlConnection conn = new SqlConnection(connstr); 
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();
            }
            else
                MessageBox.Show("Credentials are wrong");
            


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sign up
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //exit
            this.Close();
        }
    }
}
