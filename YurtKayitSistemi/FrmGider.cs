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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl=new SqlBaglantim();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Giderler (Elektrik,Su,Dogalgaz,Internet,Gıda,Personel,Diger) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtBoxElektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtBoxSu.Text);
                komut.Parameters.AddWithValue("@p3", txtBoxDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtBoxinternet.Text);
                komut.Parameters.AddWithValue("@p5", txtBoxGıda.Text);
                komut.Parameters.AddWithValue("@p6", txtBoxPersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtBoxDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıtlar Eklendi.");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu.Yeniden Deneyin");
            }
        }
    }
}
