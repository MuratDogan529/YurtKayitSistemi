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
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl=new SqlBaglantim();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,Internet=@p4,Gida=@p5,Personel=@p6,Diger=@p7 where Odemeid=@p8 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p8", txtBoxGiderId.Text);
                komut.Parameters.AddWithValue("@p1", txtBoxElektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtBoxSu.Text);
                komut.Parameters.AddWithValue("@p3", txtBoxDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtBoxinternet.Text);
                komut.Parameters.AddWithValue("@p5", txtBoxGıda.Text);
                komut.Parameters.AddWithValue("@p6", txtBoxPersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtBoxDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıtlar Güncellendi.");
                   
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu.Tekrar Deneyin.");
            }
        }
        public string giderId,elektrik, su, dogalgaz, gida, internet, personel,diger;

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtBoxGiderId.Text = giderId;
            txtBoxElektrik.Text = elektrik;
            txtBoxSu.Text = su;
            txtBoxDogalgaz.Text = dogalgaz;
            txtBoxinternet.Text = internet;
            txtBoxGıda.Text = gida;
            txtBoxPersonel.Text = personel;
            txtBoxDiger.Text = diger;
        }
    }
}
