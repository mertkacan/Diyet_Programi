﻿namespace DiyetisyenProje.PL
{
    partial class KullaniciGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.llListelerim = new System.Windows.Forms.LinkLabel();
            this.lboxListem = new System.Windows.Forms.ListBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblVKE = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblYagOrani = new System.Windows.Forms.Label();
            this.llGunSonuRaporu = new System.Windows.Forms.LinkLabel();
            this.llYemekCesidi = new System.Windows.Forms.LinkLabel();
            this.lblListeAd = new System.Windows.Forms.Label();
            this.lblTopKalori = new System.Windows.Forms.Label();
            this.btnListeBitir = new System.Windows.Forms.Button();
            this.llVucutKitleEndeksi = new System.Windows.Forms.LinkLabel();
            this.btnBilgiDuzenle = new System.Windows.Forms.Button();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(214, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "FatFitFood uygulamasına hoşgeldiniz";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdSoyad.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAdSoyad.Location = new System.Drawing.Point(-1, 244);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(245, 50);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "İSİM SOYAD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel1.Location = new System.Drawing.Point(771, 216);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(213, 35);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Yeni Besin Listesi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // llListelerim
            // 
            this.llListelerim.AutoSize = true;
            this.llListelerim.BackColor = System.Drawing.Color.Transparent;
            this.llListelerim.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llListelerim.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.llListelerim.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.llListelerim.Location = new System.Drawing.Point(771, 279);
            this.llListelerim.Name = "llListelerim";
            this.llListelerim.Size = new System.Drawing.Size(129, 35);
            this.llListelerim.TabIndex = 8;
            this.llListelerim.TabStop = true;
            this.llListelerim.Text = "Listelerim";
            this.llListelerim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llListelerim_LinkClicked);
            // 
            // lboxListem
            // 
            this.lboxListem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lboxListem.DisplayMember = "ListeAdi";
            this.lboxListem.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lboxListem.FormattingEnabled = true;
            this.lboxListem.ItemHeight = 23;
            this.lboxListem.Location = new System.Drawing.Point(342, 193);
            this.lboxListem.Name = "lboxListem";
            this.lboxListem.Size = new System.Drawing.Size(385, 326);
            this.lboxListem.TabIndex = 13;
            // 
            // lblTarih
            // 
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTarih.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTarih.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTarih.Location = new System.Drawing.Point(342, 71);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(385, 47);
            this.lblTarih.TabIndex = 14;
            this.lblTarih.Text = "Tarih";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.BackColor = System.Drawing.Color.Transparent;
            this.lblYas.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblYas.Location = new System.Drawing.Point(27, 384);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(0, 25);
            this.lblYas.TabIndex = 15;
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.BackColor = System.Drawing.Color.Transparent;
            this.lblBoy.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBoy.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBoy.Location = new System.Drawing.Point(27, 422);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(0, 25);
            this.lblBoy.TabIndex = 16;
            // 
            // lblVKE
            // 
            this.lblVKE.AutoSize = true;
            this.lblVKE.BackColor = System.Drawing.Color.Transparent;
            this.lblVKE.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVKE.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblVKE.Location = new System.Drawing.Point(27, 498);
            this.lblVKE.Name = "lblVKE";
            this.lblVKE.Size = new System.Drawing.Size(0, 25);
            this.lblVKE.TabIndex = 18;
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.BackColor = System.Drawing.Color.Transparent;
            this.lblKilo.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKilo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblKilo.Location = new System.Drawing.Point(27, 460);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(0, 25);
            this.lblKilo.TabIndex = 17;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCinsiyet.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCinsiyet.Location = new System.Drawing.Point(27, 346);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(0, 25);
            this.lblCinsiyet.TabIndex = 19;
            // 
            // lblYagOrani
            // 
            this.lblYagOrani.AutoSize = true;
            this.lblYagOrani.BackColor = System.Drawing.Color.Transparent;
            this.lblYagOrani.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYagOrani.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblYagOrani.Location = new System.Drawing.Point(27, 536);
            this.lblYagOrani.Name = "lblYagOrani";
            this.lblYagOrani.Size = new System.Drawing.Size(0, 25);
            this.lblYagOrani.TabIndex = 20;
            // 
            // llGunSonuRaporu
            // 
            this.llGunSonuRaporu.AutoSize = true;
            this.llGunSonuRaporu.BackColor = System.Drawing.Color.Transparent;
            this.llGunSonuRaporu.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llGunSonuRaporu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.llGunSonuRaporu.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.llGunSonuRaporu.Location = new System.Drawing.Point(771, 342);
            this.llGunSonuRaporu.Name = "llGunSonuRaporu";
            this.llGunSonuRaporu.Size = new System.Drawing.Size(213, 35);
            this.llGunSonuRaporu.TabIndex = 22;
            this.llGunSonuRaporu.TabStop = true;
            this.llGunSonuRaporu.Text = "Gün Sonu Raporu";
            this.llGunSonuRaporu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGunSonuRaporu_LinkClicked);
            // 
            // llYemekCesidi
            // 
            this.llYemekCesidi.AutoSize = true;
            this.llYemekCesidi.BackColor = System.Drawing.Color.Transparent;
            this.llYemekCesidi.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llYemekCesidi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.llYemekCesidi.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.llYemekCesidi.Location = new System.Drawing.Point(771, 405);
            this.llYemekCesidi.Name = "llYemekCesidi";
            this.llYemekCesidi.Size = new System.Drawing.Size(258, 35);
            this.llYemekCesidi.TabIndex = 24;
            this.llYemekCesidi.TabStop = true;
            this.llYemekCesidi.Text = "Yemek Çeşidi Raporu";
            this.llYemekCesidi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llYemekCesidi_LinkClicked);
            // 
            // lblListeAd
            // 
            this.lblListeAd.BackColor = System.Drawing.Color.Transparent;
            this.lblListeAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListeAd.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListeAd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblListeAd.Location = new System.Drawing.Point(342, 130);
            this.lblListeAd.Name = "lblListeAd";
            this.lblListeAd.Size = new System.Drawing.Size(385, 47);
            this.lblListeAd.TabIndex = 25;
            this.lblListeAd.Text = "Liste Adı";
            this.lblListeAd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopKalori
            // 
            this.lblTopKalori.AutoSize = true;
            this.lblTopKalori.BackColor = System.Drawing.Color.Transparent;
            this.lblTopKalori.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopKalori.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTopKalori.Location = new System.Drawing.Point(342, 653);
            this.lblTopKalori.Name = "lblTopKalori";
            this.lblTopKalori.Size = new System.Drawing.Size(195, 33);
            this.lblTopKalori.TabIndex = 26;
            this.lblTopKalori.Text = "Toplam Kalori : ";
            // 
            // btnListeBitir
            // 
            this.btnListeBitir.BackColor = System.Drawing.Color.Moccasin;
            this.btnListeBitir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListeBitir.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnListeBitir.Location = new System.Drawing.Point(459, 589);
            this.btnListeBitir.Name = "btnListeBitir";
            this.btnListeBitir.Size = new System.Drawing.Size(128, 41);
            this.btnListeBitir.TabIndex = 27;
            this.btnListeBitir.Text = "Listeyi Bitir";
            this.btnListeBitir.UseVisualStyleBackColor = false;
            this.btnListeBitir.Click += new System.EventHandler(this.btnListeBitir_Click);
            // 
            // llVucutKitleEndeksi
            // 
            this.llVucutKitleEndeksi.AutoSize = true;
            this.llVucutKitleEndeksi.BackColor = System.Drawing.Color.Transparent;
            this.llVucutKitleEndeksi.LinkColor = System.Drawing.Color.MidnightBlue;
            this.llVucutKitleEndeksi.Location = new System.Drawing.Point(5, 499);
            this.llVucutKitleEndeksi.Name = "llVucutKitleEndeksi";
            this.llVucutKitleEndeksi.Size = new System.Drawing.Size(16, 20);
            this.llVucutKitleEndeksi.TabIndex = 28;
            this.llVucutKitleEndeksi.TabStop = true;
            this.llVucutKitleEndeksi.Text = "?";
            this.llVucutKitleEndeksi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llVucutKitleEndeksi_LinkClicked);
            // 
            // btnBilgiDuzenle
            // 
            this.btnBilgiDuzenle.BackColor = System.Drawing.Color.Transparent;
            this.btnBilgiDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBilgiDuzenle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBilgiDuzenle.Location = new System.Drawing.Point(46, 588);
            this.btnBilgiDuzenle.Name = "btnBilgiDuzenle";
            this.btnBilgiDuzenle.Size = new System.Drawing.Size(166, 49);
            this.btnBilgiDuzenle.TabIndex = 29;
            this.btnBilgiDuzenle.Text = "Bilgilerimi Düzenle";
            this.btnBilgiDuzenle.UseVisualStyleBackColor = false;
            this.btnBilgiDuzenle.Click += new System.EventHandler(this.btnBilgiDuzenle_Click);
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(84, 303);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(20, 25);
            this.lblKullaniciAdi.TabIndex = 30;
            this.lblKullaniciAdi.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(255, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(558, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Seçili liste dışında besin aldıysanız \'Listeyi Bitir\' butonuna tıklamadan \'Listel" +
    "erim\' sayfasından silebilirsiniz.";
            // 
            // KullaniciGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1091, 702);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.btnBilgiDuzenle);
            this.Controls.Add(this.llVucutKitleEndeksi);
            this.Controls.Add(this.btnListeBitir);
            this.Controls.Add(this.lblTopKalori);
            this.Controls.Add(this.lblListeAd);
            this.Controls.Add(this.llYemekCesidi);
            this.Controls.Add(this.llGunSonuRaporu);
            this.Controls.Add(this.lblYagOrani);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblVKE);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lboxListem);
            this.Controls.Add(this.llListelerim);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label lblAdSoyad;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private LinkLabel llListelerim;
        private ListBox listBox1;
        private Label lblTarih;
        private Label lblYas;
        private Label lblBoy;
        private Label lblVKE;
        private Label lblKilo;
        private Label lblCinsiyet;
        private Label lblYagOrani;
        private LinkLabel llIstatistik;
        private LinkLabel llGunSonuRaporu;
        private LinkLabel llYemekCesidi;
        private ListBox lboxListem;
        private Label lblListeAd;
        private Label lblTopKalori;
        private Button btnListeBitir;
        private LinkLabel llVucutKitleEndeksi;
        private Button btnBilgiDuzenle;
        private Label lblKullaniciAdi;
        private Label label2;
    }
}