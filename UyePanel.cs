using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Data;
using EfeKutuphane.DAL;

namespace EfeKutuphane
{
    public partial class UyePanel : Form
    {
        int girisYapanID;
        public UyePanel(int id)
        {
            InitializeComponent();
            this.girisYapanID = id;
        }
        private void UyePanel_Load(object sender, EventArgs e)
        {
            KullaniciAdiniGetir();
            VerileriYenile();
        }
        public void VerileriYenile()
        {
            OduncDAL oDal = new OduncDAL();
            dgvKitaplarim.DataSource = oDal.UyeKitaplariniGetir(girisYapanID);

            KitapDAL kDal = new KitapDAL();
            cmbUyeKitapSec.DataSource = kDal.OduncIcinKitapGetir();
            cmbUyeKitapSec.DisplayMember = "kitap_ad";
            cmbUyeKitapSec.ValueMember = "id";
        }
        private void btnTalepEt_Click(object sender, EventArgs e)
        {
            if (cmbUyeKitapSec.SelectedValue != null)
            {
                int secilenKitapId = Convert.ToInt32(cmbUyeKitapSec.SelectedValue);

                TalepDAL tDal = new TalepDAL();
                if (tDal.TalepOlustur(girisYapanID, secilenKitapId))
                {
                    MessageBox.Show("Kitap talebiniz başarıyla admin paneline iletildi. Onay bekliyor.");
                }
                else
                {
                    MessageBox.Show("Talep gönderilirken bir hata oluştu!");
                }
            }
        }    
        public void KullaniciAdiniGetir()
        {
            using (MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430069;User ID=26_132430069;Password=İnif123."))
            {
                baglan.Open();
            
                string sorgu = "SELECT ad, soyad FROM uyeler WHERE id = @id";
                MySqlCommand komut = new MySqlCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@id", girisYapanID);
                MySqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    label1.Text = "Hoş Geldin, " + dr["ad"].ToString() + " " + dr["soyad"].ToString();
                }
            }
        }
    }
}
