namespace OJTI_2017
{
    partial class TurismMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vizexcursie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "Initializare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 108);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generare Poster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vizexcursie
            // 
            this.vizexcursie.Location = new System.Drawing.Point(403, 450);
            this.vizexcursie.Name = "vizexcursie";
            this.vizexcursie.Size = new System.Drawing.Size(183, 105);
            this.vizexcursie.TabIndex = 2;
            this.vizexcursie.Text = "Vizualizare Excursie";
            this.vizexcursie.UseVisualStyleBackColor = true;
            this.vizexcursie.Click += new System.EventHandler(this.vizexcursie_Click);
            // 
            // TurismMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 588);
            this.Controls.Add(this.vizexcursie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TurismMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turism";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button vizexcursie;
    }
}

