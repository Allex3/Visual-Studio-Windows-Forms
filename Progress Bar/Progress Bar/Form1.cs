namespace Progress_Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string res = textBox1.Text + textBox2.Text;
            int resl = res.Length;
            int incr = 100 / resl;


            if (Convert.ToInt32(progressBar1.Value) / incr >= resl)
            {
                this.progressBar1.Increment(incr);
                return;
            }

            this.progressBar1.Increment(incr);
            textBox3.Text += res[Convert.ToInt32(progressBar1.Value) / incr - 1];

            //o litera la 100/resl tick-uri
            //deci suntem la litera progress bar value / (100 / resl)

            



        }
    }
}
