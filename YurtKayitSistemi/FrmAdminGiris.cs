using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace YurtKayitSistemi
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlBaglantim bgl =new SqlBaglantim();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Admin where YoneticiAd=@p1 and YöneticiSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtBoxKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2",txtBoxSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre");
                txtBoxKullaniciAd.Clear();
                txtBoxSifre.Clear();
                txtBoxKullaniciAd.Focus();
            }
            bgl.baglanti().Close();
        }
    }
}
