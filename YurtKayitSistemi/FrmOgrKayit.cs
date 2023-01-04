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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        //Data Source=erkhbn0096\MURAT;Initial Catalog=YurtOtomasyon;Persist Security Info=True;User ID=sa;Password=Together.1453

       SqlBaglantim bgl =new SqlBaglantim();
        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {  
            //Bölümleri comoboxa listeleme
           
           SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler",bgl.baglanti());
           SqlDataReader oku = komut.ExecuteReader();
           while(oku.Read())
           {
                cmbOgrenciBolumu.Items.Add(oku[0].ToString());
                
           }
           bgl.baglanti().Close();
            cmbOgrenciBolumu.SelectedIndex = 0;
            //Boş odaları comboboxa listeleme
            
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite!=OdaAktif", bgl.baglanti());
            SqlDataReader oku2 =komut2.ExecuteReader();

            while (oku2.Read())
            {
          cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
            cmbOdaNo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(OgrAd,OgrSoyad,OgrTc,OgrTelefon,OgrDogum,OgrBolum,OgrOdaNo,OgrMail,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", txtBoxOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtBoxOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", mskdBoxTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", mskdBoxOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", mskdBoxDogumTarihi.Text);
                komutkaydet.Parameters.AddWithValue("@p6", cmbOgrenciBolumu.Text);
                komutkaydet.Parameters.AddWithValue("@p7", cmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p8", txtBoxMail.Text);
                komutkaydet.Parameters.AddWithValue("@p9", txtBoxVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", mskdBoxVeliTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p11", rchTxtBoxAdres.Text);

                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı.");
                
                FrmOgrKayit kapat = new FrmOgrKayit();
                this.Hide();//kayıt işleminden sonra formu kapatır.

                //Öğrenci İd yi labele çekme
                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci",bgl.baglanti());
                SqlDataReader oku=komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti();
                //Öğrenci Borç Alanı Oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values (@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtBoxOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", txtBoxOgrSoyad.Text);

                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA!!!.Lütfen Boşlukları Doğru Şekilde Doldurun.");
            }
            //Öğrenci Oda Kontenjanı arttırma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1",bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

        }
    }
}
