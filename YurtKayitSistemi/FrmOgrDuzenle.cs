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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl =new SqlBaglantim();
        public string id,ad,soyad,TC,telefon,dogum,bölüm;

        private void button1_Click(object sender, EventArgs e)
        {   //öğrenci silme
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where ogrid=@k1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", txtOgrid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.");
            FrmOgrDuzenle fr = new FrmOgrDuzenle();
            this.Hide();
            //Odanın Aktif Öğrenci sayısını azaltma
            SqlCommand komutoda = new SqlCommand("update odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda",bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        public string odano, mail, veliadsoyad, velitel, adres;
        //herkese açık erişim belirleyici ile id diye bir string değişken tanımladık.
        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            //private modifier access,only ilgili formda kullanılır.
            txtOgrid.Text = id;
            txtBoxOgrAd.Text = ad;
            txtBoxOgrSoyad.Text = soyad;
            mskdBoxTC.Text = TC;
            mskdBoxOgrTelefon.Text = telefon;
            mskdBoxDogumTarihi.Text = dogum;
            cmbOgrenciBolumu.Text = bölüm;
            cmbOdaNo.Text = odano;
            txtBoxMail.Text = mail;
            txtBoxVeliAdSoyad.Text = veliadsoyad;
            mskdBoxVeliTelefon.Text = velitel;
            rchTxtBoxAdres.Text = adres;
            

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
SqlCommand komut=new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,ogrTc=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrOdaNo=@p8,OgrMail=@p9,ogrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where Ogrid=@p1",bgl.baglanti());
            try
            {
                komut.Parameters.AddWithValue("@p1", txtOgrid.Text);
                komut.Parameters.AddWithValue("@p2", txtBoxOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", txtBoxOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskdBoxTC.Text);
                komut.Parameters.AddWithValue("@p5", mskdBoxOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", mskdBoxDogumTarihi.Text);
                komut.Parameters.AddWithValue("@p7", cmbOgrenciBolumu.Text);
                komut.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p9", txtBoxMail.Text);
                komut.Parameters.AddWithValue("@p10", txtBoxVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", mskdBoxVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", rchTxtBoxAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi.");

            }
            catch (Exception)
            {
                MessageBox.Show("Hata!! Yeniden Deneyin.");

            }
            FrmOgrDuzenle duzenle =new FrmOgrDuzenle();
            this.Hide();
            
        }
    }
}
