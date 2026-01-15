namespace EfeKutuphane
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtKitapAd = new TextBox();
            Kitap = new TabControl();
            tabKitap = new TabPage();
            txtKitap = new TextBox();
            btnGuncelle = new Button();
            cmbKategori = new ComboBox();
            btnSil = new Button();
            btnKitapEkle = new Button();
            txtYazar = new TextBox();
            dataGridView1 = new DataGridView();
            tabOdunc = new TabPage();
            btnIadeEt = new Button();
            dgvAktifOduncler = new DataGridView();
            btnOduncVer = new Button();
            cmbKitapSec = new ComboBox();
            cmbUyeSec = new ComboBox();
            tabKayit = new TabPage();
            btnUyeSil = new Button();
            dgvUyeler = new DataGridView();
            btnUyeEkle = new Button();
            txtUyeTel = new TextBox();
            txtUyeSoyad = new TextBox();
            txtUyeAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabAyarlar = new TabPage();
            btnTalepOnayla = new Button();
            dgvRaporlar = new DataGridView();
            btnGecikenKitaplar = new Button();
            btnEnCokOkunanlar = new Button();
            Kitap.SuspendLayout();
            tabKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabOdunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAktifOduncler).BeginInit();
            tabKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).BeginInit();
            tabAyarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRaporlar).BeginInit();
            SuspendLayout();
            // 
            // txtKitapAd
            // 
            txtKitapAd.Location = new Point(550, 20);
            txtKitapAd.Name = "txtKitapAd";
            txtKitapAd.Size = new Size(125, 27);
            txtKitapAd.TabIndex = 2;
            // 
            // Kitap
            // 
            Kitap.Controls.Add(tabKitap);
            Kitap.Controls.Add(tabOdunc);
            Kitap.Controls.Add(tabKayit);
            Kitap.Controls.Add(tabAyarlar);
            Kitap.Dock = DockStyle.Top;
            Kitap.Font = new Font("Monotype Corsiva", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            Kitap.Location = new Point(0, 0);
            Kitap.Name = "Kitap";
            Kitap.SelectedIndex = 0;
            Kitap.Size = new Size(800, 454);
            Kitap.TabIndex = 6;
            // 
            // tabKitap
            // 
            tabKitap.BackColor = Color.Transparent;
            tabKitap.BackgroundImage = (Image)resources.GetObject("tabKitap.BackgroundImage");
            tabKitap.BackgroundImageLayout = ImageLayout.Stretch;
            tabKitap.Controls.Add(txtKitap);
            tabKitap.Controls.Add(btnGuncelle);
            tabKitap.Controls.Add(cmbKategori);
            tabKitap.Controls.Add(btnSil);
            tabKitap.Controls.Add(btnKitapEkle);
            tabKitap.Controls.Add(txtYazar);
            tabKitap.Controls.Add(dataGridView1);
            tabKitap.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tabKitap.Location = new Point(4, 29);
            tabKitap.Name = "tabKitap";
            tabKitap.Padding = new Padding(3);
            tabKitap.Size = new Size(792, 421);
            tabKitap.TabIndex = 0;
            tabKitap.Text = "Kitap İşlemleri";
            // 
            // txtKitap
            // 
            txtKitap.Font = new Font("Segoe UI Light", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            txtKitap.Location = new Point(524, 266);
            txtKitap.MinimumSize = new Size(0, 30);
            txtKitap.Name = "txtKitap";
            txtKitap.Size = new Size(125, 30);
            txtKitap.TabIndex = 12;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Sienna;
            btnGuncelle.Location = new Point(682, 187);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(102, 29);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.Font = new Font("Segoe UI Light", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(509, 110);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(151, 33);
            cmbKategori.TabIndex = 10;
            cmbKategori.Text = "Tür...";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Location = new Point(682, 258);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(102, 43);
            btnSil.TabIndex = 9;
            btnSil.Text = "Kitap Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.BackColor = Color.Lime;
            btnKitapEkle.Location = new Point(682, 101);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(102, 43);
            btnKitapEkle.TabIndex = 8;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.UseVisualStyleBackColor = false;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // txtYazar
            // 
            txtYazar.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            txtYazar.Location = new Point(524, 187);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(125, 30);
            txtYazar.TabIndex = 7;
            txtYazar.Text = "Yazar İsmi...";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AntiqueWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.HighlightText;
            dataGridView1.Location = new Point(22, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(454, 352);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tabOdunc
            // 
            tabOdunc.BackgroundImage = (Image)resources.GetObject("tabOdunc.BackgroundImage");
            tabOdunc.Controls.Add(btnIadeEt);
            tabOdunc.Controls.Add(dgvAktifOduncler);
            tabOdunc.Controls.Add(btnOduncVer);
            tabOdunc.Controls.Add(cmbKitapSec);
            tabOdunc.Controls.Add(cmbUyeSec);
            tabOdunc.Location = new Point(4, 29);
            tabOdunc.Name = "tabOdunc";
            tabOdunc.Padding = new Padding(3);
            tabOdunc.Size = new Size(792, 421);
            tabOdunc.TabIndex = 1;
            tabOdunc.Text = "Ödünç İşlemleri";
            tabOdunc.UseVisualStyleBackColor = true;
            // 
            // btnIadeEt
            // 
            btnIadeEt.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnIadeEt.Location = new Point(334, 95);
            btnIadeEt.Name = "btnIadeEt";
            btnIadeEt.Size = new Size(123, 39);
            btnIadeEt.TabIndex = 4;
            btnIadeEt.Text = "İade Al";
            btnIadeEt.UseVisualStyleBackColor = true;
            btnIadeEt.Click += btnIadeEt_Click;
            // 
            // dgvAktifOduncler
            // 
            dgvAktifOduncler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAktifOduncler.Location = new Point(180, 169);
            dgvAktifOduncler.Name = "dgvAktifOduncler";
            dgvAktifOduncler.RowHeadersWidth = 51;
            dgvAktifOduncler.Size = new Size(425, 188);
            dgvAktifOduncler.TabIndex = 3;
            // 
            // btnOduncVer
            // 
            btnOduncVer.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnOduncVer.Location = new Point(334, 21);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(123, 44);
            btnOduncVer.TabIndex = 2;
            btnOduncVer.Text = "Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.Click += btnOduncVer_Click;
            // 
            // cmbKitapSec
            // 
            cmbKitapSec.FormattingEnabled = true;
            cmbKitapSec.Location = new Point(538, 73);
            cmbKitapSec.Name = "cmbKitapSec";
            cmbKitapSec.Size = new Size(191, 28);
            cmbKitapSec.TabIndex = 1;
            // 
            // cmbUyeSec
            // 
            cmbUyeSec.FormattingEnabled = true;
            cmbUyeSec.Location = new Point(68, 73);
            cmbUyeSec.Name = "cmbUyeSec";
            cmbUyeSec.Size = new Size(190, 28);
            cmbUyeSec.TabIndex = 0;
            // 
            // tabKayit
            // 
            tabKayit.BackColor = Color.Transparent;
            tabKayit.BackgroundImage = (Image)resources.GetObject("tabKayit.BackgroundImage");
            tabKayit.BackgroundImageLayout = ImageLayout.Stretch;
            tabKayit.Controls.Add(btnUyeSil);
            tabKayit.Controls.Add(dgvUyeler);
            tabKayit.Controls.Add(btnUyeEkle);
            tabKayit.Controls.Add(txtUyeTel);
            tabKayit.Controls.Add(txtUyeSoyad);
            tabKayit.Controls.Add(txtUyeAd);
            tabKayit.Controls.Add(label3);
            tabKayit.Controls.Add(label2);
            tabKayit.Controls.Add(label1);
            tabKayit.Location = new Point(4, 29);
            tabKayit.Name = "tabKayit";
            tabKayit.Padding = new Padding(3);
            tabKayit.Size = new Size(792, 421);
            tabKayit.TabIndex = 2;
            tabKayit.Text = "Kayıt ";
            // 
            // btnUyeSil
            // 
            btnUyeSil.BackColor = Color.Red;
            btnUyeSil.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUyeSil.ForeColor = SystemColors.ControlText;
            btnUyeSil.Location = new Point(487, 256);
            btnUyeSil.Name = "btnUyeSil";
            btnUyeSil.Size = new Size(152, 89);
            btnUyeSil.TabIndex = 8;
            btnUyeSil.Text = "Üye Sil";
            btnUyeSil.UseVisualStyleBackColor = false;
            btnUyeSil.Click += btnUyeSil_Click;
            // 
            // dgvUyeler
            // 
            dgvUyeler.BackgroundColor = Color.LemonChiffon;
            dgvUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUyeler.GridColor = SystemColors.ControlLightLight;
            dgvUyeler.Location = new Point(61, 146);
            dgvUyeler.Name = "dgvUyeler";
            dgvUyeler.RowHeadersWidth = 51;
            dgvUyeler.Size = new Size(406, 199);
            dgvUyeler.TabIndex = 7;
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.BackColor = Color.Aqua;
            btnUyeEkle.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUyeEkle.ForeColor = SystemColors.ControlText;
            btnUyeEkle.Location = new Point(487, 146);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(152, 89);
            btnUyeEkle.TabIndex = 6;
            btnUyeEkle.Text = "Üye Ekle";
            btnUyeEkle.UseVisualStyleBackColor = false;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // txtUyeTel
            // 
            txtUyeTel.Location = new Point(487, 78);
            txtUyeTel.Name = "txtUyeTel";
            txtUyeTel.Size = new Size(208, 27);
            txtUyeTel.TabIndex = 5;
            // 
            // txtUyeSoyad
            // 
            txtUyeSoyad.Location = new Point(267, 78);
            txtUyeSoyad.Name = "txtUyeSoyad";
            txtUyeSoyad.Size = new Size(144, 27);
            txtUyeSoyad.TabIndex = 4;
            // 
            // txtUyeAd
            // 
            txtUyeAd.Location = new Point(61, 78);
            txtUyeAd.Name = "txtUyeAd";
            txtUyeAd.Size = new Size(136, 27);
            txtUyeAd.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(510, 42);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 2;
            label3.Text = "Telefon Numarası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(309, 42);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(111, 42);
            label1.Name = "label1";
            label1.Size = new Size(33, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // tabAyarlar
            // 
            tabAyarlar.BackgroundImage = (Image)resources.GetObject("tabAyarlar.BackgroundImage");
            tabAyarlar.BackgroundImageLayout = ImageLayout.Stretch;
            tabAyarlar.Controls.Add(btnTalepOnayla);
            tabAyarlar.Controls.Add(dgvRaporlar);
            tabAyarlar.Controls.Add(btnGecikenKitaplar);
            tabAyarlar.Controls.Add(btnEnCokOkunanlar);
            tabAyarlar.Location = new Point(4, 29);
            tabAyarlar.Name = "tabAyarlar";
            tabAyarlar.Padding = new Padding(3);
            tabAyarlar.Size = new Size(792, 421);
            tabAyarlar.TabIndex = 3;
            tabAyarlar.Text = "Raporlar";
            tabAyarlar.UseVisualStyleBackColor = true;
            // 
            // btnTalepOnayla
            // 
            btnTalepOnayla.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnTalepOnayla.Location = new Point(301, 347);
            btnTalepOnayla.Name = "btnTalepOnayla";
            btnTalepOnayla.Size = new Size(202, 47);
            btnTalepOnayla.TabIndex = 3;
            btnTalepOnayla.Text = "Talebi Onayla";
            btnTalepOnayla.UseVisualStyleBackColor = true;
            btnTalepOnayla.Click += btnTalepOnayla_Click;
            // 
            // dgvRaporlar
            // 
            dgvRaporlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRaporlar.Location = new Point(224, 142);
            dgvRaporlar.Name = "dgvRaporlar";
            dgvRaporlar.RowHeadersWidth = 51;
            dgvRaporlar.Size = new Size(300, 188);
            dgvRaporlar.TabIndex = 2;
            // 
            // btnGecikenKitaplar
            // 
            btnGecikenKitaplar.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGecikenKitaplar.Location = new Point(80, 66);
            btnGecikenKitaplar.Name = "btnGecikenKitaplar";
            btnGecikenKitaplar.Size = new Size(176, 56);
            btnGecikenKitaplar.TabIndex = 1;
            btnGecikenKitaplar.Text = "Geciken Kitaplar";
            btnGecikenKitaplar.UseVisualStyleBackColor = true;
            btnGecikenKitaplar.Click += btnGecikenKitaplar_Click;
            // 
            // btnEnCokOkunanlar
            // 
            btnEnCokOkunanlar.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEnCokOkunanlar.Location = new Point(546, 66);
            btnEnCokOkunanlar.Name = "btnEnCokOkunanlar";
            btnEnCokOkunanlar.Size = new Size(166, 56);
            btnEnCokOkunanlar.TabIndex = 0;
            btnEnCokOkunanlar.Text = "En Çok Okunanlar";
            btnEnCokOkunanlar.UseVisualStyleBackColor = true;
            btnEnCokOkunanlar.Click += btnEnCokOkunanlar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Kitap);
            Controls.Add(txtKitapAd);
            Name = "Form1";
            Text = "Kütüphane";
            Load += Form1_Load;
            Kitap.ResumeLayout(false);
            tabKitap.ResumeLayout(false);
            tabKitap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabOdunc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAktifOduncler).EndInit();
            tabKayit.ResumeLayout(false);
            tabKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUyeler).EndInit();
            tabAyarlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRaporlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtKitapAd;
        private DataGridViewTextBoxColumn kitapadsutun;
        private DataGridViewTextBoxColumn yazaradsutun;
        private TabControl Kitap;
        private TabPage tabKitap;
        private TabPage tabOdunc;
        private TabPage tabKayit;
        private TabPage tabAyarlar;
        private ComboBox cmbKategori;
        private Button btnKitapEkle;
        private TextBox txtYazar;
        private DataGridView dataGridView1;
        private DataGridView dgvUyeler;
        private Button btnUyeEkle;
        private TextBox txtUyeTel;
        private TextBox txtUyeSoyad;
        private TextBox txtUyeAd;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnOduncVer;
        private ComboBox cmbKitapSec;
        private ComboBox cmbUyeSec;
        private Button btnGuncelle;
        private TextBox txtKitap;
        public Button btnUyeSil;
        public Button btnSil;
        private DataGridView dgvAktifOduncler;
        private DataGridView dgvRaporlar;
        private Button btnGecikenKitaplar;
        private Button btnEnCokOkunanlar;
        private Button btnIadeEt;
        private Button btnTalepOnayla;
    }
}
