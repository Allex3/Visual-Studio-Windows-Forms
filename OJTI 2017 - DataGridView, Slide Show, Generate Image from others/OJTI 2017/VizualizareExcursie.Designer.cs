namespace OJTI_2017
{
    partial class VizualizareExcursieMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.genexc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.paginaPlanificari = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paginaPerioade = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.paginaItinerariu = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.paginaImagini = new System.Windows.Forms.TabPage();
            this.startImagini = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.turismDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turismDataSet1 = new OJTI_2017.TurismDataSet();
            this.planificariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planificariTableAdapter = new OJTI_2017.TurismDataSetTableAdapters.PlanificariTableAdapter();
            this.localitatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localitatiTableAdapter = new OJTI_2017.TurismDataSetTableAdapters.LocalitatiTableAdapter();
            this.planificariTableAdapter1 = new OJTI_2017.TurismDataSetTableAdapters.PlanificariTableAdapter();
            this.localitatiTableAdapter1 = new OJTI_2017.TurismDataSetTableAdapters.LocalitatiTableAdapter();
            this.planificariTableAdapter2 = new OJTI_2017.TurismDataSetTableAdapters.PlanificariTableAdapter();
            this.imaginiTableAdapter1 = new OJTI_2017.TurismDataSetTableAdapters.ImaginiTableAdapter();
            this.turismDataSet2 = new OJTI_2017.TurismDataSet();
            this.turismDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.paginaPlanificari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.paginaPerioade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.paginaItinerariu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.paginaImagini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turismDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turismDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planificariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turismDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turismDataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // genexc
            // 
            this.genexc.Location = new System.Drawing.Point(737, 29);
            this.genexc.Name = "genexc";
            this.genexc.Size = new System.Drawing.Size(243, 68);
            this.genexc.TabIndex = 0;
            this.genexc.Text = "Genereaza Excursie";
            this.genexc.UseVisualStyleBackColor = true;
            this.genexc.Click += new System.EventHandler(this.genexc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inceput excursie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Finalizare Excursie";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 29);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd MM yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(390, 79);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(229, 29);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.paginaPlanificari);
            this.tabControl1.Controls.Add(this.paginaPerioade);
            this.tabControl1.Controls.Add(this.paginaItinerariu);
            this.tabControl1.Controls.Add(this.paginaImagini);
            this.tabControl1.Location = new System.Drawing.Point(59, 141);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1268, 604);
            this.tabControl1.TabIndex = 5;
            // 
            // paginaPlanificari
            // 
            this.paginaPlanificari.Controls.Add(this.dataGridView1);
            this.paginaPlanificari.Location = new System.Drawing.Point(4, 33);
            this.paginaPlanificari.Name = "paginaPlanificari";
            this.paginaPlanificari.Padding = new System.Windows.Forms.Padding(3);
            this.paginaPlanificari.Size = new System.Drawing.Size(1260, 567);
            this.paginaPlanificari.TabIndex = 1;
            this.paginaPlanificari.Text = "Planificari";
            this.paginaPlanificari.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 571);
            this.dataGridView1.TabIndex = 0;
            // 
            // paginaPerioade
            // 
            this.paginaPerioade.Controls.Add(this.dataGridView2);
            this.paginaPerioade.Location = new System.Drawing.Point(4, 33);
            this.paginaPerioade.Name = "paginaPerioade";
            this.paginaPerioade.Size = new System.Drawing.Size(1260, 567);
            this.paginaPerioade.TabIndex = 2;
            this.paginaPerioade.Text = "Perioade de vizitare";
            this.paginaPerioade.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.RowTemplate.Height = 31;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(1264, 567);
            this.dataGridView2.TabIndex = 0;
            // 
            // paginaItinerariu
            // 
            this.paginaItinerariu.Controls.Add(this.dataGridView3);
            this.paginaItinerariu.Location = new System.Drawing.Point(4, 33);
            this.paginaItinerariu.Name = "paginaItinerariu";
            this.paginaItinerariu.Size = new System.Drawing.Size(1260, 567);
            this.paginaItinerariu.TabIndex = 3;
            this.paginaItinerariu.Text = "Vizualizare Itinerariu";
            this.paginaItinerariu.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 72;
            this.dataGridView3.RowTemplate.Height = 31;
            this.dataGridView3.Size = new System.Drawing.Size(1264, 567);
            this.dataGridView3.TabIndex = 0;
            // 
            // paginaImagini
            // 
            this.paginaImagini.Controls.Add(this.startImagini);
            this.paginaImagini.Controls.Add(this.progressBar1);
            this.paginaImagini.Controls.Add(this.pictureBox1);
            this.paginaImagini.Controls.Add(this.label4);
            this.paginaImagini.Controls.Add(this.label3);
            this.paginaImagini.Location = new System.Drawing.Point(4, 33);
            this.paginaImagini.Name = "paginaImagini";
            this.paginaImagini.Size = new System.Drawing.Size(1260, 567);
            this.paginaImagini.TabIndex = 4;
            this.paginaImagini.Text = "Vizualizare imagini";
            this.paginaImagini.UseVisualStyleBackColor = true;
            // 
            // startImagini
            // 
            this.startImagini.Location = new System.Drawing.Point(903, 212);
            this.startImagini.Name = "startImagini";
            this.startImagini.Size = new System.Drawing.Size(235, 77);
            this.startImagini.TabIndex = 4;
            this.startImagini.Text = "Start";
            this.startImagini.UseVisualStyleBackColor = true;
            this.startImagini.Click += new System.EventHandler(this.startImagini_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(843, 87);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(357, 61);
            this.progressBar1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 447);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // turismDataSet1BindingSource
            // 
            this.turismDataSet1BindingSource.DataSource = this.turismDataSet1;
            this.turismDataSet1BindingSource.Position = 0;
            // 
            // turismDataSet1
            // 
            this.turismDataSet1.DataSetName = "TurismDataSet";
            this.turismDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planificariBindingSource
            // 
            this.planificariBindingSource.DataMember = "Planificari";
            this.planificariBindingSource.DataSource = this.turismDataSet1;
            // 
            // planificariTableAdapter
            // 
            this.planificariTableAdapter.ClearBeforeFill = true;
            // 
            // localitatiBindingSource
            // 
            this.localitatiBindingSource.DataMember = "Localitati";
            this.localitatiBindingSource.DataSource = this.turismDataSet1;
            // 
            // localitatiTableAdapter
            // 
            this.localitatiTableAdapter.ClearBeforeFill = true;
            // 
            // planificariTableAdapter1
            // 
            this.planificariTableAdapter1.ClearBeforeFill = true;
            // 
            // localitatiTableAdapter1
            // 
            this.localitatiTableAdapter1.ClearBeforeFill = true;
            // 
            // planificariTableAdapter2
            // 
            this.planificariTableAdapter2.ClearBeforeFill = true;
            // 
            // imaginiTableAdapter1
            // 
            this.imaginiTableAdapter1.ClearBeforeFill = true;
            // 
            // turismDataSet2
            // 
            this.turismDataSet2.DataSetName = "TurismDataSet";
            this.turismDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turismDataSet1BindingSource1
            // 
            this.turismDataSet1BindingSource1.DataSource = this.turismDataSet1;
            this.turismDataSet1BindingSource1.Position = 0;
            // 
            // VizualizareExcursieMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 757);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genexc);
            this.Name = "VizualizareExcursieMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VizualizareExcursie";
            this.Load += new System.EventHandler(this.VizualizareExcursieMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.paginaPlanificari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.paginaPerioade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.paginaItinerariu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.paginaImagini.ResumeLayout(false);
            this.paginaImagini.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turismDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turismDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planificariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localitatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turismDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turismDataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button genexc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage paginaPlanificari;
        private System.Windows.Forms.TabPage paginaPerioade;
        private System.Windows.Forms.TabPage paginaItinerariu;
        private System.Windows.Forms.TabPage paginaImagini;
        private TurismDataSet turismDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource planificariBindingSource;
        private TurismDataSetTableAdapters.PlanificariTableAdapter planificariTableAdapter;
        private System.Windows.Forms.BindingSource localitatiBindingSource;
        private TurismDataSetTableAdapters.LocalitatiTableAdapter localitatiTableAdapter;
        private System.Windows.Forms.BindingSource turismDataSet1BindingSource;
        private TurismDataSetTableAdapters.PlanificariTableAdapter planificariTableAdapter1;
        private TurismDataSetTableAdapters.LocalitatiTableAdapter localitatiTableAdapter1;
        private TurismDataSetTableAdapters.PlanificariTableAdapter planificariTableAdapter2;
        private TurismDataSetTableAdapters.ImaginiTableAdapter imaginiTableAdapter1;
        private TurismDataSet turismDataSet2;
        private System.Windows.Forms.BindingSource turismDataSet1BindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button startImagini;
    }
}