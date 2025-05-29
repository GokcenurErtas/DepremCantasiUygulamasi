namespace DepremCantasiUygulamasi
{
    partial class Form1
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lstMalzemeler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.btnHatirlat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(219, 63);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 22);
            this.txtIsim.TabIndex = 0;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(219, 95);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 22);
            this.txtAdet.TabIndex = 1;
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(49, 63);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(92, 16);
            this.lblIsim.TabIndex = 2;
            this.lblIsim.Text = "Malzeme İsmi:";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(49, 95);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(38, 16);
            this.lblAdet.TabIndex = 3;
            this.lblAdet.Text = "Adet:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(49, 127);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(129, 16);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "Son Kullanma Tarihi:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(422, 273);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(76, 16);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "labelDurum";
            this.lblDurum.Click += new System.EventHandler(this.lblDurum_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lstMalzemeler
            // 
            this.lstMalzemeler.FormattingEnabled = true;
            this.lstMalzemeler.ItemHeight = 16;
            this.lstMalzemeler.Location = new System.Drawing.Point(52, 273);
            this.lstMalzemeler.Name = "lstMalzemeler";
            this.lstMalzemeler.Size = new System.Drawing.Size(308, 164);
            this.lstMalzemeler.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(52, 191);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(141, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Malzeme Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(219, 191);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(141, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Malzeme Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(389, 191);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(141, 23);
            this.btnKontrol.TabIndex = 10;
            this.btnKontrol.Text = "Eksik/Tarih Kontrol";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click_1);
            // 
            // btnHatirlat
            // 
            this.btnHatirlat.Location = new System.Drawing.Point(575, 191);
            this.btnHatirlat.Name = "btnHatirlat";
            this.btnHatirlat.Size = new System.Drawing.Size(148, 23);
            this.btnHatirlat.TabIndex = 11;
            this.btnHatirlat.Text = "Son Kullanma Uyarısı";
            this.btnHatirlat.UseVisualStyleBackColor = true;
            this.btnHatirlat.Click += new System.EventHandler(this.btnHatirlat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHatirlat);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstMalzemeler);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtIsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lstMalzemeler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Button btnHatirlat;
    }
}

