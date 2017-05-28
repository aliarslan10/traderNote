namespace TradeNote
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli designer değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        ///Designer desteği için gerekli metottur; bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbSiteniz = new System.Windows.Forms.ListBox();
            this.lbSite = new System.Windows.Forms.ListBox();
            this.lbTarih1 = new System.Windows.Forms.ListBox();
            this.lbTarih2 = new System.Windows.Forms.ListBox();
            this.lbAnlasmaTuru = new System.Windows.Forms.ListBox();
            this.gbAnlasmaDetaylari = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUcret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTarih1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAnlasmaTuru = new System.Windows.Forms.TextBox();
            this.lbUcret = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTarih2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSiteniz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbIslemButonlari = new System.Windows.Forms.GroupBox();
            this.bKaydet = new System.Windows.Forms.Button();
            this.bGoruntule = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.bDuzenle = new System.Windows.Forms.Button();
            this.bEkle = new System.Windows.Forms.Button();
            this.gbAnlasmaDetayEkrani = new System.Windows.Forms.GroupBox();
            this.bGuncelle = new System.Windows.Forms.Button();
            this.bAnlasmaDetayi = new System.Windows.Forms.Button();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblEkBilgi = new System.Windows.Forms.Label();
            this.lblIletisim = new System.Windows.Forms.Label();
            this.lblAnlasmaYeri = new System.Windows.Forms.Label();
            this.lblTarih1 = new System.Windows.Forms.Label();
            this.lblTarih2 = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.lblAnlasmaTuru = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblSiteniz = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbDetay = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbEkBilgi = new System.Windows.Forms.TextBox();
            this.lbEkBilgi = new System.Windows.Forms.ListBox();
            this.gbAnlasmaIletisimBilgileri = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbIletisim = new System.Windows.Forms.TextBox();
            this.tbAnlasmaYeri = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbAnlasmaYeri = new System.Windows.Forms.ListBox();
            this.lbIletisim = new System.Windows.Forms.ListBox();
            this.gbAnlasmaDetaylari.SuspendLayout();
            this.gbIslemButonlari.SuspendLayout();
            this.gbAnlasmaDetayEkrani.SuspendLayout();
            this.gbDetay.SuspendLayout();
            this.gbAnlasmaIletisimBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSiteniz
            // 
            this.lbSiteniz.FormattingEnabled = true;
            this.lbSiteniz.Location = new System.Drawing.Point(6, 33);
            this.lbSiteniz.Name = "lbSiteniz";
            this.lbSiteniz.Size = new System.Drawing.Size(100, 238);
            this.lbSiteniz.TabIndex = 0;
            this.lbSiteniz.SelectedIndexChanged += new System.EventHandler(this.lbSiteniz_SelectedIndexChanged);
            // 
            // lbSite
            // 
            this.lbSite.FormattingEnabled = true;
            this.lbSite.Location = new System.Drawing.Point(111, 33);
            this.lbSite.Name = "lbSite";
            this.lbSite.Size = new System.Drawing.Size(100, 238);
            this.lbSite.TabIndex = 1;
            this.lbSite.SelectedIndexChanged += new System.EventHandler(this.lbSite_SelectedIndexChanged);
            // 
            // lbTarih1
            // 
            this.lbTarih1.FormattingEnabled = true;
            this.lbTarih1.Location = new System.Drawing.Point(217, 33);
            this.lbTarih1.Name = "lbTarih1";
            this.lbTarih1.Size = new System.Drawing.Size(100, 238);
            this.lbTarih1.TabIndex = 2;
            this.lbTarih1.SelectedIndexChanged += new System.EventHandler(this.lbTarih1_SelectedIndexChanged);
            // 
            // lbTarih2
            // 
            this.lbTarih2.FormattingEnabled = true;
            this.lbTarih2.Location = new System.Drawing.Point(323, 33);
            this.lbTarih2.Name = "lbTarih2";
            this.lbTarih2.Size = new System.Drawing.Size(100, 238);
            this.lbTarih2.TabIndex = 3;
            this.lbTarih2.SelectedIndexChanged += new System.EventHandler(this.lbTarih2_SelectedIndexChanged);
            // 
            // lbAnlasmaTuru
            // 
            this.lbAnlasmaTuru.FormattingEnabled = true;
            this.lbAnlasmaTuru.Location = new System.Drawing.Point(429, 32);
            this.lbAnlasmaTuru.Name = "lbAnlasmaTuru";
            this.lbAnlasmaTuru.Size = new System.Drawing.Size(100, 238);
            this.lbAnlasmaTuru.TabIndex = 4;
            this.lbAnlasmaTuru.SelectedIndexChanged += new System.EventHandler(this.lbAnlasmaTuru_SelectedIndexChanged);
            // 
            // gbAnlasmaDetaylari
            // 
            this.gbAnlasmaDetaylari.Controls.Add(this.label10);
            this.gbAnlasmaDetaylari.Controls.Add(this.tbUcret);
            this.gbAnlasmaDetaylari.Controls.Add(this.label9);
            this.gbAnlasmaDetaylari.Controls.Add(this.label7);
            this.gbAnlasmaDetaylari.Controls.Add(this.label12);
            this.gbAnlasmaDetaylari.Controls.Add(this.tbTarih1);
            this.gbAnlasmaDetaylari.Controls.Add(this.label8);
            this.gbAnlasmaDetaylari.Controls.Add(this.label6);
            this.gbAnlasmaDetaylari.Controls.Add(this.label11);
            this.gbAnlasmaDetaylari.Controls.Add(this.tbAnlasmaTuru);
            this.gbAnlasmaDetaylari.Controls.Add(this.lbUcret);
            this.gbAnlasmaDetaylari.Controls.Add(this.label5);
            this.gbAnlasmaDetaylari.Controls.Add(this.tbTarih2);
            this.gbAnlasmaDetaylari.Controls.Add(this.label4);
            this.gbAnlasmaDetaylari.Controls.Add(this.tbSite);
            this.gbAnlasmaDetaylari.Controls.Add(this.label3);
            this.gbAnlasmaDetaylari.Controls.Add(this.tbSiteniz);
            this.gbAnlasmaDetaylari.Controls.Add(this.label2);
            this.gbAnlasmaDetaylari.Controls.Add(this.lbSiteniz);
            this.gbAnlasmaDetaylari.Controls.Add(this.label1);
            this.gbAnlasmaDetaylari.Controls.Add(this.lbAnlasmaTuru);
            this.gbAnlasmaDetaylari.Controls.Add(this.lbSite);
            this.gbAnlasmaDetaylari.Controls.Add(this.lbTarih2);
            this.gbAnlasmaDetaylari.Controls.Add(this.lbTarih1);
            this.gbAnlasmaDetaylari.Location = new System.Drawing.Point(12, 12);
            this.gbAnlasmaDetaylari.Name = "gbAnlasmaDetaylari";
            this.gbAnlasmaDetaylari.Size = new System.Drawing.Size(648, 329);
            this.gbAnlasmaDetaylari.TabIndex = 5;
            this.gbAnlasmaDetaylari.TabStop = false;
            this.gbAnlasmaDetaylari.Text = "Anlaşma Detayları";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Anlaşma Türü : ";
            // 
            // tbUcret
            // 
            this.tbUcret.Location = new System.Drawing.Point(535, 297);
            this.tbUcret.Name = "tbUcret";
            this.tbUcret.Size = new System.Drawing.Size(100, 20);
            this.tbUcret.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(320, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Anlaşma Bitiş Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Anlaşma Yapılan Site:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(535, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Anlaşılan Ücret : ";
            // 
            // tbTarih1
            // 
            this.tbTarih1.Location = new System.Drawing.Point(217, 297);
            this.tbTarih1.Name = "tbTarih1";
            this.tbTarih1.Size = new System.Drawing.Size(102, 20);
            this.tbTarih1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Anlaşma Tarihi : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Sitenizin Adı : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(544, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Anlaşılan Ücret";
            // 
            // tbAnlasmaTuru
            // 
            this.tbAnlasmaTuru.Location = new System.Drawing.Point(429, 297);
            this.tbAnlasmaTuru.Name = "tbAnlasmaTuru";
            this.tbAnlasmaTuru.Size = new System.Drawing.Size(100, 20);
            this.tbAnlasmaTuru.TabIndex = 9;
            // 
            // lbUcret
            // 
            this.lbUcret.FormattingEnabled = true;
            this.lbUcret.Location = new System.Drawing.Point(535, 32);
            this.lbUcret.Name = "lbUcret";
            this.lbUcret.Size = new System.Drawing.Size(100, 238);
            this.lbUcret.TabIndex = 28;
            this.lbUcret.SelectedIndexChanged += new System.EventHandler(this.lbUcret_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Anlaşma Türü";
            // 
            // tbTarih2
            // 
            this.tbTarih2.Location = new System.Drawing.Point(323, 297);
            this.tbTarih2.Name = "tbTarih2";
            this.tbTarih2.Size = new System.Drawing.Size(101, 20);
            this.tbTarih2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Anlaşma Bitiş Tarihi";
            // 
            // tbSite
            // 
            this.tbSite.Location = new System.Drawing.Point(111, 297);
            this.tbSite.Name = "tbSite";
            this.tbSite.Size = new System.Drawing.Size(100, 20);
            this.tbSite.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Anlaşma Tarihi";
            // 
            // tbSiteniz
            // 
            this.tbSiteniz.Location = new System.Drawing.Point(6, 297);
            this.tbSiteniz.Name = "tbSiteniz";
            this.tbSiteniz.Size = new System.Drawing.Size(100, 20);
            this.tbSiteniz.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Anlaşma Yapılan Site";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sizin Siteniz";
            // 
            // gbIslemButonlari
            // 
            this.gbIslemButonlari.Controls.Add(this.bKaydet);
            this.gbIslemButonlari.Controls.Add(this.bGoruntule);
            this.gbIslemButonlari.Controls.Add(this.bSil);
            this.gbIslemButonlari.Controls.Add(this.bDuzenle);
            this.gbIslemButonlari.Controls.Add(this.bEkle);
            this.gbIslemButonlari.Location = new System.Drawing.Point(346, 347);
            this.gbIslemButonlari.Name = "gbIslemButonlari";
            this.gbIslemButonlari.Size = new System.Drawing.Size(612, 69);
            this.gbIslemButonlari.TabIndex = 28;
            this.gbIslemButonlari.TabStop = false;
            this.gbIslemButonlari.Text = "İşlem Butonları";
            // 
            // bKaydet
            // 
            this.bKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKaydet.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKaydet.ForeColor = System.Drawing.Color.Indigo;
            this.bKaydet.Location = new System.Drawing.Point(324, 19);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(100, 40);
            this.bKaydet.TabIndex = 3;
            this.bKaydet.Text = "KAYDET";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // bGoruntule
            // 
            this.bGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGoruntule.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGoruntule.ForeColor = System.Drawing.Color.Olive;
            this.bGoruntule.Location = new System.Drawing.Point(430, 19);
            this.bGoruntule.Name = "bGoruntule";
            this.bGoruntule.Size = new System.Drawing.Size(176, 40);
            this.bGoruntule.TabIndex = 2;
            this.bGoruntule.Text = "DETAYLARI GÖSTER";
            this.bGoruntule.UseVisualStyleBackColor = true;
            this.bGoruntule.Click += new System.EventHandler(this.bGoruntule_Click);
            // 
            // bSil
            // 
            this.bSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSil.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.ForeColor = System.Drawing.Color.Brown;
            this.bSil.Location = new System.Drawing.Point(112, 19);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(100, 40);
            this.bSil.TabIndex = 0;
            this.bSil.Text = "SİL";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bDuzenle
            // 
            this.bDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDuzenle.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDuzenle.ForeColor = System.Drawing.Color.ForestGreen;
            this.bDuzenle.Location = new System.Drawing.Point(218, 19);
            this.bDuzenle.Name = "bDuzenle";
            this.bDuzenle.Size = new System.Drawing.Size(100, 40);
            this.bDuzenle.TabIndex = 1;
            this.bDuzenle.Text = "DÜZENLE";
            this.bDuzenle.UseVisualStyleBackColor = true;
            this.bDuzenle.Click += new System.EventHandler(this.bDuzenle_Click);
            // 
            // bEkle
            // 
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEkle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bEkle.Location = new System.Drawing.Point(6, 19);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(100, 40);
            this.bEkle.TabIndex = 0;
            this.bEkle.Text = "EKLE";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // gbAnlasmaDetayEkrani
            // 
            this.gbAnlasmaDetayEkrani.Controls.Add(this.bGuncelle);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.bAnlasmaDetayi);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.lblSite);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.lblEkBilgi);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.lblIletisim);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.lblAnlasmaYeri);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.lblTarih1);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.lblTarih2);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.lblUcret);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.lblAnlasmaTuru);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.label19);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.label27);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.label26);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.label25);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.label24);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.label23);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.label22);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.label21);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.label20);
            this.gbAnlasmaDetayEkrani.Controls.Add(this.lblSiteniz);
            this.gbAnlasmaDetayEkrani.Location = new System.Drawing.Point(346, 422);
            this.gbAnlasmaDetayEkrani.Name = "gbAnlasmaDetayEkrani";
            this.gbAnlasmaDetayEkrani.Size = new System.Drawing.Size(616, 250);
            this.gbAnlasmaDetayEkrani.TabIndex = 29;
            this.gbAnlasmaDetayEkrani.TabStop = false;
            this.gbAnlasmaDetayEkrani.Text = "Detay Görüntüleme Ekranı";
            // 
            // bGuncelle
            // 
            this.bGuncelle.BackColor = System.Drawing.Color.Gray;
            this.bGuncelle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGuncelle.ForeColor = System.Drawing.Color.White;
            this.bGuncelle.Location = new System.Drawing.Point(430, 219);
            this.bGuncelle.Name = "bGuncelle";
            this.bGuncelle.Size = new System.Drawing.Size(180, 25);
            this.bGuncelle.TabIndex = 22;
            this.bGuncelle.Text = "Güncellemeleri Kontrol Et";
            this.bGuncelle.UseVisualStyleBackColor = false;
            this.bGuncelle.Click += new System.EventHandler(this.bGuncelle_Click);
            // 
            // bAnlasmaDetayi
            // 
            this.bAnlasmaDetayi.BackColor = System.Drawing.Color.Gray;
            this.bAnlasmaDetayi.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAnlasmaDetayi.ForeColor = System.Drawing.Color.White;
            this.bAnlasmaDetayi.Location = new System.Drawing.Point(244, 219);
            this.bAnlasmaDetayi.Name = "bAnlasmaDetayi";
            this.bAnlasmaDetayi.Size = new System.Drawing.Size(180, 25);
            this.bAnlasmaDetayi.TabIndex = 4;
            this.bAnlasmaDetayi.Text = "Anlaşmaya Ait Detayları Göster";
            this.bAnlasmaDetayi.UseVisualStyleBackColor = false;
            this.bAnlasmaDetayi.Click += new System.EventHandler(this.bAnlasmaDetayi_Click);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(156, 40);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(22, 13);
            this.lblSite.TabIndex = 21;
            this.lblSite.Text = "-----";
            // 
            // lblEkBilgi
            // 
            this.lblEkBilgi.AutoSize = true;
            this.lblEkBilgi.Location = new System.Drawing.Point(156, 180);
            this.lblEkBilgi.Name = "lblEkBilgi";
            this.lblEkBilgi.Size = new System.Drawing.Size(22, 13);
            this.lblEkBilgi.TabIndex = 20;
            this.lblEkBilgi.Text = "-----";
            // 
            // lblIletisim
            // 
            this.lblIletisim.AutoSize = true;
            this.lblIletisim.Location = new System.Drawing.Point(156, 160);
            this.lblIletisim.Name = "lblIletisim";
            this.lblIletisim.Size = new System.Drawing.Size(22, 13);
            this.lblIletisim.TabIndex = 19;
            this.lblIletisim.Text = "-----";
            // 
            // lblAnlasmaYeri
            // 
            this.lblAnlasmaYeri.AutoSize = true;
            this.lblAnlasmaYeri.Location = new System.Drawing.Point(156, 140);
            this.lblAnlasmaYeri.Name = "lblAnlasmaYeri";
            this.lblAnlasmaYeri.Size = new System.Drawing.Size(22, 13);
            this.lblAnlasmaYeri.TabIndex = 18;
            this.lblAnlasmaYeri.Text = "-----";
            // 
            // lblTarih1
            // 
            this.lblTarih1.AutoSize = true;
            this.lblTarih1.Location = new System.Drawing.Point(156, 60);
            this.lblTarih1.Name = "lblTarih1";
            this.lblTarih1.Size = new System.Drawing.Size(22, 13);
            this.lblTarih1.TabIndex = 17;
            this.lblTarih1.Text = "-----";
            // 
            // lblTarih2
            // 
            this.lblTarih2.AutoSize = true;
            this.lblTarih2.Location = new System.Drawing.Point(156, 80);
            this.lblTarih2.Name = "lblTarih2";
            this.lblTarih2.Size = new System.Drawing.Size(22, 13);
            this.lblTarih2.TabIndex = 16;
            this.lblTarih2.Text = "-----";
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(156, 120);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(22, 13);
            this.lblUcret.TabIndex = 15;
            this.lblUcret.Text = "-----";
            // 
            // lblAnlasmaTuru
            // 
            this.lblAnlasmaTuru.AutoSize = true;
            this.lblAnlasmaTuru.Location = new System.Drawing.Point(156, 100);
            this.lblAnlasmaTuru.Name = "lblAnlasmaTuru";
            this.lblAnlasmaTuru.Size = new System.Drawing.Size(22, 13);
            this.lblAnlasmaTuru.TabIndex = 14;
            this.lblAnlasmaTuru.Text = "-----";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(2, 180);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Anlaşmaya Ait Detaylar :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(2, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(144, 13);
            this.label27.TabIndex = 12;
            this.label27.Text = "Sizin Siteniz                :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(2, 40);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(146, 13);
            this.label26.TabIndex = 11;
            this.label26.Text = "Anlaşma Yapılan Site    :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(2, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(146, 13);
            this.label25.TabIndex = 10;
            this.label25.Text = "Anlaşma Tarihi             :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(2, 80);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(146, 13);
            this.label24.TabIndex = 9;
            this.label24.Text = "Anlaşma Bitiş Tarihi      :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(2, 100);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(145, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Anlaşm Türü                :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(2, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(146, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Ücret                          :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(2, 140);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(148, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Anlaşma Yeri                :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(2, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "İletişim (mail veya nick) :";
            // 
            // lblSiteniz
            // 
            this.lblSiteniz.AutoSize = true;
            this.lblSiteniz.Location = new System.Drawing.Point(156, 20);
            this.lblSiteniz.Name = "lblSiteniz";
            this.lblSiteniz.Size = new System.Drawing.Size(22, 13);
            this.lblSiteniz.TabIndex = 3;
            this.lblSiteniz.Text = "-----";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInfo.Location = new System.Drawing.Point(501, 675);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(452, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "[ traderNote V2.0 ]     [ Made by Ali Arslan ]    [ Mail : blogkafem@gmail.com ] " +
    "  [ r10 : pcmania ]";
            // 
            // gbDetay
            // 
            this.gbDetay.Controls.Add(this.label16);
            this.gbDetay.Controls.Add(this.tbEkBilgi);
            this.gbDetay.Controls.Add(this.lbEkBilgi);
            this.gbDetay.Location = new System.Drawing.Point(12, 347);
            this.gbDetay.Name = "gbDetay";
            this.gbDetay.Size = new System.Drawing.Size(328, 341);
            this.gbDetay.TabIndex = 39;
            this.gbDetay.TabStop = false;
            this.gbDetay.Text = "Anlaşmaya Ait Ekbilgiler ve Detaylar (Notlar)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Yok ise \"YOK\" yazın :";
            // 
            // tbEkBilgi
            // 
            this.tbEkBilgi.Location = new System.Drawing.Point(4, 238);
            this.tbEkBilgi.Multiline = true;
            this.tbEkBilgi.Name = "tbEkBilgi";
            this.tbEkBilgi.Size = new System.Drawing.Size(315, 97);
            this.tbEkBilgi.TabIndex = 39;
            // 
            // lbEkBilgi
            // 
            this.lbEkBilgi.FormattingEnabled = true;
            this.lbEkBilgi.Location = new System.Drawing.Point(5, 19);
            this.lbEkBilgi.Name = "lbEkBilgi";
            this.lbEkBilgi.Size = new System.Drawing.Size(314, 199);
            this.lbEkBilgi.TabIndex = 37;
            this.lbEkBilgi.SelectedIndexChanged += new System.EventHandler(this.lbEkBilgi_SelectedIndexChanged_1);
            // 
            // gbAnlasmaIletisimBilgileri
            // 
            this.gbAnlasmaIletisimBilgileri.Controls.Add(this.label18);
            this.gbAnlasmaIletisimBilgileri.Controls.Add(this.label17);
            this.gbAnlasmaIletisimBilgileri.Controls.Add(this.tbIletisim);
            this.gbAnlasmaIletisimBilgileri.Controls.Add(this.tbAnlasmaYeri);
            this.gbAnlasmaIletisimBilgileri.Controls.Add(this.label14);
            this.gbAnlasmaIletisimBilgileri.Controls.Add(this.label13);
            this.gbAnlasmaIletisimBilgileri.Controls.Add(this.lbAnlasmaYeri);
            this.gbAnlasmaIletisimBilgileri.Controls.Add(this.lbIletisim);
            this.gbAnlasmaIletisimBilgileri.Location = new System.Drawing.Point(666, 12);
            this.gbAnlasmaIletisimBilgileri.Name = "gbAnlasmaIletisimBilgileri";
            this.gbAnlasmaIletisimBilgileri.Size = new System.Drawing.Size(296, 329);
            this.gbAnlasmaIletisimBilgileri.TabIndex = 40;
            this.gbAnlasmaIletisimBilgileri.TabStop = false;
            this.gbAnlasmaIletisimBilgileri.Text = "Anlaşma İle İlgili İletişim Bilgileri";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(148, 281);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Mail Adresi, Forum Nicki vb.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1, 281);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Mail, Telefon, Forum Adı vs.";
            // 
            // tbIletisim
            // 
            this.tbIletisim.Location = new System.Drawing.Point(148, 297);
            this.tbIletisim.Name = "tbIletisim";
            this.tbIletisim.Size = new System.Drawing.Size(133, 20);
            this.tbIletisim.TabIndex = 34;
            // 
            // tbAnlasmaYeri
            // 
            this.tbAnlasmaYeri.Location = new System.Drawing.Point(4, 297);
            this.tbAnlasmaYeri.Name = "tbAnlasmaYeri";
            this.tbAnlasmaYeri.Size = new System.Drawing.Size(136, 20);
            this.tbAnlasmaYeri.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(155, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Kişinin İletişim Bilgileri : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Anlaşma Yapılan Yer";
            // 
            // lbAnlasmaYeri
            // 
            this.lbAnlasmaYeri.FormattingEnabled = true;
            this.lbAnlasmaYeri.Location = new System.Drawing.Point(4, 33);
            this.lbAnlasmaYeri.Name = "lbAnlasmaYeri";
            this.lbAnlasmaYeri.Size = new System.Drawing.Size(133, 238);
            this.lbAnlasmaYeri.TabIndex = 29;
            this.lbAnlasmaYeri.SelectedIndexChanged += new System.EventHandler(this.lbAnlasmaYeri_SelectedIndexChanged_1);
            // 
            // lbIletisim
            // 
            this.lbIletisim.FormattingEnabled = true;
            this.lbIletisim.Location = new System.Drawing.Point(148, 33);
            this.lbIletisim.Name = "lbIletisim";
            this.lbIletisim.Size = new System.Drawing.Size(133, 238);
            this.lbIletisim.TabIndex = 30;
            this.lbIletisim.SelectedIndexChanged += new System.EventHandler(this.lbIletisim_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 690);
            this.Controls.Add(this.gbAnlasmaIletisimBilgileri);
            this.Controls.Add(this.gbDetay);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbAnlasmaDetayEkrani);
            this.Controls.Add(this.gbIslemButonlari);
            this.Controls.Add(this.gbAnlasmaDetaylari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "traderNote - Tüm anlaşmalarınız tek ekranda!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.gbAnlasmaDetaylari.ResumeLayout(false);
            this.gbAnlasmaDetaylari.PerformLayout();
            this.gbIslemButonlari.ResumeLayout(false);
            this.gbAnlasmaDetayEkrani.ResumeLayout(false);
            this.gbAnlasmaDetayEkrani.PerformLayout();
            this.gbDetay.ResumeLayout(false);
            this.gbDetay.PerformLayout();
            this.gbAnlasmaIletisimBilgileri.ResumeLayout(false);
            this.gbAnlasmaIletisimBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSiteniz;
        private System.Windows.Forms.ListBox lbSite;
        private System.Windows.Forms.ListBox lbTarih1;
        private System.Windows.Forms.ListBox lbTarih2;
        private System.Windows.Forms.ListBox lbAnlasmaTuru;
        private System.Windows.Forms.GroupBox gbAnlasmaDetaylari;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTarih1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAnlasmaTuru;
        private System.Windows.Forms.ListBox lbUcret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTarih2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSiteniz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbIslemButonlari;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.Button bDuzenle;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.Button bGoruntule;
        private System.Windows.Forms.GroupBox gbAnlasmaDetayEkrani;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSiteniz;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblEkBilgi;
        private System.Windows.Forms.Label lblIletisim;
        private System.Windows.Forms.Label lblAnlasmaYeri;
        private System.Windows.Forms.Label lblTarih1;
        private System.Windows.Forms.Label lblTarih2;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblAnlasmaTuru;
        private System.Windows.Forms.Button bAnlasmaDetayi;
        private System.Windows.Forms.GroupBox gbDetay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbEkBilgi;
        private System.Windows.Forms.ListBox lbEkBilgi;
        private System.Windows.Forms.GroupBox gbAnlasmaIletisimBilgileri;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbIletisim;
        private System.Windows.Forms.TextBox tbAnlasmaYeri;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbAnlasmaYeri;
        private System.Windows.Forms.ListBox lbIletisim;
        private System.Windows.Forms.Button bGuncelle;
    }
}

