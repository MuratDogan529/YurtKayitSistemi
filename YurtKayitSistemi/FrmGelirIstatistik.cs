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
    public partial class FrmGelirIstatistik : Form
    {
        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }
        //Kasadaki Toplam Paraa
        SqlBaglantim mrt = new SqlBaglantim();
        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        {
         SqlCommand komut = new SqlCommand("Select Sum(OdemeMiktar) from Kasa",mrt.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblPara.Text = oku[0].ToString()+"TL";
            }
            mrt.baglanti().Close();

            //Tekrarsız Olarak ayları listeleme//distinct tekrarsız veri getirme
            SqlCommand komut2 = new SqlCommand("Select distinct(OdemeAy) from Kasa",mrt.baglanti());
            SqlDataReader oku2=komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbBoxAylar.Items.Add(oku2[0].ToString());
            }
            mrt.baglanti().Close();

            // this.chart1.Series["Aylık"].Points.AddY(15);
            //grafiklere database den veri çekme
            SqlCommand komut4 = new SqlCommand("select OdemeAy,sum(OdemeMiktar) from Kasa group by OdemeAy",mrt.baglanti());
            SqlDataReader oku3=komut4.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);

            }
            mrt.baglanti().Close();
        }
        
       
        private void cmbBoxAylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("select sum(OdemeMiktar) From Kasa where OdemeAy=@p1",mrt.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmbBoxAylar.Text);
            SqlDataReader oku3=komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblsecilenAy.Text = oku3[0].ToString()+"TL";
            }
        }
    }
}
