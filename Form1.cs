//using MySql.Data.MySqlClient;
using System.Data;
using EfeKutuphane.DAL;
using EfeKutuphane.Domain;
using EfeKutuphane.Services;
using MySqlConnector;


    namespace EfeKutuphane
{
    public partial class Form1 : Form
    {
        public string girisYapanRol;
        int secilenKitapId;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=26_132430069;User ID=26_132430069; Password=Ýnif123.");


            KategoriDAL katDal = new KategoriDAL();
            cmbKategori.DataSource = katDal.KategorileriGetir();
            cmbKategori.DisplayMember = "kategori_ad";
            cmbKategori.ValueMember = "id";

            UyeDAL uDal = new UyeDAL();
            DataTable uyeTablo = uDal.UyeleriGetir();
            cmbUyeSec.DisplayMember = "ad";
            cmbUyeSec.ValueMember = "id";
            cmbUyeSec.DataSource = uyeTablo;


            KitapDAL kDal = new KitapDAL();
            dataGridView1.DataSource = kDal.KitaplariGetir();
            DataTable kitapTablo = kDal.OduncIcinKitapGetir();
            cmbKitapSec.DisplayMember = "kitap_ad";
            cmbKitapSec.ValueMember = "id";
            cmbKitapSec.DataSource = kitapTablo;


            OduncDAL oDal = new OduncDAL();
            dgvAktifOduncler.DataSource = oDal.TumOduncleriGetir();

            dgvUyeler.DataSource = uDal.UyeleriGetir();

            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["kitap_ad"].HeaderText = "Kitap";
            dataGridView1.Columns["yazar"].HeaderText = "Yazar";
            dataGridView1.Columns["kategori_ad"].HeaderText = "Kategori";
            dataGridView1.Columns["durum"].HeaderText = "Durum";
            dgvAktifOduncler.Columns["kitap_id"].Visible = false;
            dgvAktifOduncler.Columns["No"].Visible = false;
            dgvUyeler.Columns["id"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUyeler.Columns["id"].DataPropertyName = "id";

            KitaplariListele();
            UyeleriListele();
            OduncleriListele();
            TalepleriListele();


            try
            {
                baglanti.Open();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Sunucu Baðlantý Hatasý: " + ex.Message);
            }

        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap yeniKitap = new Kitap
                {
                    Ad = txtKitap.Text,
                    Yazar = txtYazar.Text,
                    KategoriId = Convert.ToInt32(cmbKategori.SelectedValue)
                };

                KitapService servis = new KitapService();
                servis.Ekle(yeniKitap);

                MessageBox.Show("Kitap baþarýyla eklendi.");
                KitaplariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                KitapService servis = new KitapService();
                servis.Sil(id);

                MessageBox.Show("Kitap silindi.");
                KitaplariListele();
            }
        }
        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                EfeKutuphane.Domain.Uye yeniUye = new EfeKutuphane.Domain.Uye
                {
                    Ad = txtUyeAd.Text,
                    Soyad = txtUyeSoyad.Text,
                    Telefon = txtUyeTel.Text
                };

                EfeKutuphane.Services.UyeService servis = new EfeKutuphane.Services.UyeService();
                servis.Kaydet(yeniUye);

                MessageBox.Show("Üye baþarýyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUyeAd.Clear(); txtUyeSoyad.Clear(); txtUyeTel.Clear();
                UyeleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            int uyeId = Convert.ToInt32(cmbUyeSec.SelectedValue);
            int kitapId = Convert.ToInt32(cmbKitapSec.SelectedValue);

            OduncDAL odal = new OduncDAL();
            bool basariliMi = odal.KitapOduncVer(uyeId, kitapId);

            if (basariliMi)
            {
                MessageBox.Show("Kitap baþarýyla ödünç verildi.");
                KitapDAL kdal = new KitapDAL();

                dataGridView1.DataSource = kdal.KitaplariGetir();
                dgvAktifOduncler.DataSource = odal.TumOduncleriGetir();
                cmbKitapSec.DataSource = kdal.OduncIcinKitapGetir();
            }
            else
            {
                MessageBox.Show("HATA: Bu kitap þu an baþka bir üyede!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dataGridView1.Rows[e.RowIndex];
                txtKitapAd.Text = satir.Cells["kitap_ad"].Value.ToString();
                txtYazar.Text = satir.Cells["yazar"].Value.ToString();

                secilenKitapId = Convert.ToInt32(satir.Cells["id"].Value);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    Kitap guncellenecekKitap = new Kitap
                    {
                        Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value),
                        Ad = txtKitapAd.Text,
                        Yazar = txtYazar.Text,
                        KategoriId = Convert.ToInt32(cmbKategori.SelectedValue)
                    };

                    KitapService servis = new KitapService();
                    servis.Guncelle(guncellenecekKitap);

                    MessageBox.Show("Kitap baþarýyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    KitaplariListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme hatasý: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tablodan güncellenecek bir kitap seçin!");
            }
        }
        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow != null)
            {
                try
                {
                    int id = Convert.ToInt32(dgvUyeler.CurrentRow.Cells["id"].Value);

                    EfeKutuphane.Services.UyeService servis = new EfeKutuphane.Services.UyeService();
                    servis.Sil(id);

                    MessageBox.Show("Üye silindi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UyeleriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatasý: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir üye seçin.");
            }
        }

        private void btnEnCokOkunanlar_Click(object sender, EventArgs e)
        {
            KitapService servis = new KitapService();
            dgvRaporlar.DataSource = servis.EnCokOkunanlariGetir();
        }
        private void btnGecikenKitaplar_Click(object sender, EventArgs e)
        {
            KitapService servis = new KitapService();
            dgvRaporlar.DataSource = servis.GecikenleriGetir();
        }
        private void btnIadeEt_Click(object sender, EventArgs e)
        {
            if (dgvAktifOduncler.CurrentRow != null)
            {
                int oduncId = Convert.ToInt32(dgvAktifOduncler.CurrentRow.Cells["No"].Value);
                int kitapId = Convert.ToInt32(dgvAktifOduncler.CurrentRow.Cells["kitap_id"].Value);

                OduncDAL oDal = new OduncDAL();
                if (oDal.KitapIadeAl(oduncId, kitapId))
                {
                    MessageBox.Show("Kitap teslim alýndý, raf durumu güncellendi.");

                    dgvAktifOduncler.DataSource = oDal.TumOduncleriGetir();

                    KitapDAL kDal = new KitapDAL();
                    cmbKitapSec.DataSource = kDal.OduncIcinKitapGetir();
                }
            }
        }
        public void TalepleriListele()
        {
            TalepDAL tDal = new TalepDAL();
            dgvRaporlar.DataSource = tDal.TalepleriGetir();

            if (dgvRaporlar.Columns.Contains("uye_id"))
                dgvRaporlar.Columns["uye_id"].Visible = false;

            if (dgvRaporlar.Columns.Contains("kitap_id"))
                dgvRaporlar.Columns["kitap_id"].Visible = false;
        }
        private void btnTalepOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int talepId = Convert.ToInt32(dgvRaporlar.CurrentRow.Cells["Talep No"].Value);
                int uyeId = Convert.ToInt32(dgvRaporlar.CurrentRow.Cells["uye_id"].Value);
                int kitapId = Convert.ToInt32(dgvRaporlar.CurrentRow.Cells["kitap_id"].Value);

                TalepService servis = new TalepService();
                servis.Onayla(talepId, uyeId, kitapId);

                MessageBox.Show("Talep onaylandý ve kitap ödünç verildi!");

                TalepleriListele();
                KitaplariListele();
                OduncleriListele();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void UyeleriListele()
        {
            EfeKutuphane.Services.UyeService servis = new EfeKutuphane.Services.UyeService();
            dgvUyeler.DataSource = servis.Listele();

            if (dgvUyeler.Columns.Contains("id"))
                dgvUyeler.Columns["id"].Visible = false;
        }
        public void KitaplariListele()
        {
            try
            {
                EfeKutuphane.Services.KitapService servis = new EfeKutuphane.Services.KitapService();

                dataGridView1.DataSource = servis.HepsiniGetir();

                if (dataGridView1.Columns.Contains("id"))
                    dataGridView1.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatasý: " + ex.Message);
            }
        }
        public void OduncleriListele()
        {
            try
            {
                EfeKutuphane.Services.OduncService servis = new EfeKutuphane.Services.OduncService();

                dgvAktifOduncler.DataSource = servis.HepsiniGetir();

                if (dgvAktifOduncler.Columns.Contains("kitap_id"))
                    dgvAktifOduncler.Columns["kitap_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödünç listesi yüklenirken hata: " + ex.Message);
            }
        }
    }   
}      


