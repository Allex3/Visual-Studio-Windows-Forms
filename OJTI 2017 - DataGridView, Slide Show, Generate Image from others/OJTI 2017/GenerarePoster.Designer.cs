namespace OJTI_2017
{
    partial class GenerarePosterMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adaugaimg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listaimagini = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.titluposter = new System.Windows.Forms.TextBox();
            this.genpostbutton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(470, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(691, 378);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(343, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(55, 168);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(343, 32);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Localitate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Imagine";
            // 
            // adaugaimg
            // 
            this.adaugaimg.Location = new System.Drawing.Point(212, 246);
            this.adaugaimg.Name = "adaugaimg";
            this.adaugaimg.Size = new System.Drawing.Size(186, 67);
            this.adaugaimg.TabIndex = 5;
            this.adaugaimg.Text = "Adauga";
            this.adaugaimg.UseVisualStyleBackColor = true;
            this.adaugaimg.Click += new System.EventHandler(this.adaugaimg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista imagini";
            // 
            // listaimagini
            // 
            this.listaimagini.FormattingEnabled = true;
            this.listaimagini.ItemHeight = 24;
            this.listaimagini.Location = new System.Drawing.Point(55, 333);
            this.listaimagini.Name = "listaimagini";
            this.listaimagini.Size = new System.Drawing.Size(343, 148);
            this.listaimagini.TabIndex = 7;
            this.listaimagini.SelectedIndexChanged += new System.EventHandler(this.listaimagini_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Titlu";
            // 
            // titluposter
            // 
            this.titluposter.Location = new System.Drawing.Point(121, 527);
            this.titluposter.Name = "titluposter";
            this.titluposter.Size = new System.Drawing.Size(366, 29);
            this.titluposter.TabIndex = 9;
            // 
            // genpostbutton
            // 
            this.genpostbutton.Location = new System.Drawing.Point(638, 490);
            this.genpostbutton.Name = "genpostbutton";
            this.genpostbutton.Size = new System.Drawing.Size(364, 66);
            this.genpostbutton.TabIndex = 10;
            this.genpostbutton.Text = "Genereaza Poster";
            this.genpostbutton.UseVisualStyleBackColor = true;
            this.genpostbutton.Click += new System.EventHandler(this.genpostbutton_Click);
            // 
            // GenerarePosterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 579);
            this.Controls.Add(this.genpostbutton);
            this.Controls.Add(this.titluposter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listaimagini);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adaugaimg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GenerarePosterMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerarePoster";
            this.Load += new System.EventHandler(this.GenerarePosterMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adaugaimg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listaimagini;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titluposter;
        private System.Windows.Forms.Button genpostbutton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}