namespace Progress_Bar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(134, 354);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(665, 40);
            progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(417, 441);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 1;
            button1.Text = "Transfera";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(402, 28);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(175, 35);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(402, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 35);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(245, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(477, 35);
            textBox3.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 543);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Loading...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
