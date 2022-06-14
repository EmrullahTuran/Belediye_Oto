namespace Belediye
{
    partial class OneriTablosu
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
            this.dataOneri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataOneri)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOneri
            // 
            this.dataOneri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOneri.Location = new System.Drawing.Point(12, 82);
            this.dataOneri.Name = "dataOneri";
            this.dataOneri.RowTemplate.Height = 25;
            this.dataOneri.Size = new System.Drawing.Size(1042, 489);
            this.dataOneri.TabIndex = 0;
            // 
            // OneriTablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 583);
            this.Controls.Add(this.dataOneri);
            this.Name = "OneriTablosu";
            this.Text = "OneriTablosu";
            this.Load += new System.EventHandler(this.OneriTablosu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOneri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataOneri;
    }
}