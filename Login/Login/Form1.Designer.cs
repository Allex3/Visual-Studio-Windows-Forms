namespace Login
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(657, 310);
            button1.Name = "button1";
            button1.Size = new Size(86, 40);
            button1.TabIndex = 0;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(497, 310);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 1;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(497, 62);
            label1.Name = "label1";
            label1.Size = new Size(52, 30);
            label1.TabIndex = 2;
            label1.Text = "user";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(497, 170);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 3;
            label2.Text = "password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(497, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 35);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(497, 223);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(246, 35);
            textBox2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(22, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 288);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 108);
            label3.Name = "label3";
            label3.Size = new Size(283, 50);
            label3.TabIndex = 0;
            label3.Text = "Axolotls World";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(22, 383);
            button3.Name = "button3";
            button3.Size = new Size(131, 40);
            button3.TabIndex = 7;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(859, 450);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Log In Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
        private Label label3;
        private Button button3;
    }
}
