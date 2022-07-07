namespace Belediye
{
    partial class Anasayfa
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
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.datapersonel = new System.Windows.Forms.DataGridView();
            this.dataArac = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datapersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataArac)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(103, -3);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(109, 23);
            this.btnPersonelEkle.TabIndex = 0;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(230, -3);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(105, 23);
            this.btnAracEkle.TabIndex = 3;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // datapersonel
            // 
            this.datapersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datapersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datapersonel.Location = new System.Drawing.Point(3, 45);
            this.datapersonel.Name = "datapersonel";
            this.datapersonel.RowTemplate.Height = 25;
            this.datapersonel.Size = new System.Drawing.Size(601, 568);
            this.datapersonel.TabIndex = 4;
            this.datapersonel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datapersonel_CellContentClick);
            // 
            // dataArac
            // 
            this.dataArac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataArac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataArac.Location = new System.Drawing.Point(635, 45);
            this.dataArac.Name = "dataArac";
            this.dataArac.RowTemplate.Height = 25;
            this.dataArac.Size = new System.Drawing.Size(494, 568);
            this.dataArac.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Şikayet Öneri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataArac);
            this.Controls.Add(this.datapersonel);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnPersonelEkle);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datapersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataArac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPersonelEkle;
        private Button btnAracEkle;
        private DataGridView datapersonel;
        private DataGridView dataArac;
        private Button button1;
    }
}