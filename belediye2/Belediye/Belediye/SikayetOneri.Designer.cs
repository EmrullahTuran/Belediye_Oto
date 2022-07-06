namespace Belediye
{
    partial class SikayetOneri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SikayetOneri));
            this.btngonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsikayetad = new System.Windows.Forms.TextBox();
            this.txtsikayetsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsikayet = new System.Windows.Forms.Button();
            this.btnanasayfa = new System.Windows.Forms.Button();
            this.txtoneri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngonder
            // 
            this.btngonder.Location = new System.Drawing.Point(423, 290);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(75, 23);
            this.btngonder.TabIndex = 0;
            this.btngonder.Text = "Gönder";
            this.btngonder.UseVisualStyleBackColor = true;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı : ";
            // 
            // txtsikayetad
            // 
            this.txtsikayetad.Location = new System.Drawing.Point(423, 134);
            this.txtsikayetad.Name = "txtsikayetad";
            this.txtsikayetad.Size = new System.Drawing.Size(225, 23);
            this.txtsikayetad.TabIndex = 2;
            // 
            // txtsikayetsoyad
            // 
            this.txtsikayetsoyad.Location = new System.Drawing.Point(423, 186);
            this.txtsikayetsoyad.Name = "txtsikayetsoyad";
            this.txtsikayetsoyad.Size = new System.Drawing.Size(225, 23);
            this.txtsikayetsoyad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyadı : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnsikayet
            // 
            this.btnsikayet.Location = new System.Drawing.Point(535, 290);
            this.btnsikayet.Name = "btnsikayet";
            this.btnsikayet.Size = new System.Drawing.Size(75, 23);
            this.btnsikayet.TabIndex = 7;
            this.btnsikayet.Text = "Öneri";
            this.btnsikayet.UseVisualStyleBackColor = true;
            this.btnsikayet.Click += new System.EventHandler(this.btnsikayet_Click);
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.Location = new System.Drawing.Point(642, 290);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(75, 23);
            this.btnanasayfa.TabIndex = 8;
            this.btnanasayfa.Text = "Anasayfa";
            this.btnanasayfa.UseVisualStyleBackColor = true;
            this.btnanasayfa.Click += new System.EventHandler(this.btnanasayfa_Click);
            // 
            // txtoneri
            // 
            this.txtoneri.Location = new System.Drawing.Point(423, 246);
            this.txtoneri.Name = "txtoneri";
            this.txtoneri.Size = new System.Drawing.Size(344, 23);
            this.txtoneri.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şikayetiniz : ";
            // 
            // SikayetOneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtoneri);
            this.Controls.Add(this.btnanasayfa);
            this.Controls.Add(this.btnsikayet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtsikayetsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsikayetad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngonder);
            this.Name = "SikayetOneri";
            this.Text = "SikayetOneri";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btngonder;
        private Label label1;
        private TextBox txtsikayetad;
        private TextBox txtsikayetsoyad;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnsikayet;
        private Button btnanasayfa;
        private TextBox txtoneri;
        private Label label3;
    }
}