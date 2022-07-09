namespace Belediye
{
    partial class AracBilgisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracBilgisi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAracKayıt = new System.Windows.Forms.Button();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.txtkometre = new System.Windows.Forms.TextBox();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.txtturu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model : ";
            // 
            // btnAracKayıt
            // 
            this.btnAracKayıt.Location = new System.Drawing.Point(471, 303);
            this.btnAracKayıt.Name = "btnAracKayıt";
            this.btnAracKayıt.Size = new System.Drawing.Size(75, 23);
            this.btnAracKayıt.TabIndex = 2;
            this.btnAracKayıt.Text = "Kaydet";
            this.btnAracKayıt.UseVisualStyleBackColor = true;
            this.btnAracKayıt.Click += new System.EventHandler(this.btnAracKayıt_Click);
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(471, 73);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(189, 23);
            this.txtmodel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kilometre : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plaka : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Renk : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Türü : ";
            // 
            // txtplaka
            // 
            this.txtplaka.Location = new System.Drawing.Point(471, 120);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(189, 23);
            this.txtplaka.TabIndex = 8;
            // 
            // txtkometre
            // 
            this.txtkometre.Location = new System.Drawing.Point(471, 169);
            this.txtkometre.Name = "txtkometre";
            this.txtkometre.Size = new System.Drawing.Size(189, 23);
            this.txtkometre.TabIndex = 9;
            // 
            // txtrenk
            // 
            this.txtrenk.Location = new System.Drawing.Point(471, 210);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(189, 23);
            this.txtrenk.TabIndex = 10;
            // 
            // txtturu
            // 
            this.txtturu.Location = new System.Drawing.Point(471, 256);
            this.txtturu.Name = "txtturu";
            this.txtturu.Size = new System.Drawing.Size(189, 23);
            this.txtturu.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(284, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Araç Kayıt Formuna Hoşgeldiniz";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Location = new System.Drawing.Point(585, 303);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(75, 23);
            this.btnAnasayfa.TabIndex = 13;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // AracBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 398);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtturu);
            this.Controls.Add(this.txtrenk);
            this.Controls.Add(this.txtkometre);
            this.Controls.Add(this.txtplaka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.btnAracKayıt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AracBilgisi";
            this.Text = "AracBilgisi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnAracKayıt;
        private TextBox txtmodel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtplaka;
        private TextBox txtkometre;
        private TextBox txtrenk;
        private TextBox txtturu;
        private Label label6;
        private Button btnAnasayfa;
    }
}