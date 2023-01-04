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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet4.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonDataSet4.Borclar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int odenen, kalan,yeniborc;
            odenen = Convert.ToInt16(txtBoxOdenen.Text);
            kalan = Convert.ToInt16(txtBoxKalan.Text);
            yeniborc = kalan - odenen;
            txtBoxKalan.Text = yeniborc.ToString();

            //yeni tutarı veri tabanına kaydetme
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where Ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtBxOgrid.Text);
            komut.Parameters.AddWithValue("@p1", txtBoxKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(String.Format(odenen+" TL Borç Ödemesi Başarılı"));
            this.borclarTableAdapter.Fill(this.yurtOtomasyonDataSet4.Borclar);

            //Kasa tablosuna ekleme yapma
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) values (@k1,@k2)",bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1",txtBoxOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", txtBoxOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti();
            FrmOdemeler kapat = new FrmOdemeler();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id,ad, soyad, kalan;
            secilen=dataGridView1.SelectedCells[0].RowIndex;//seçilen değeri secilen degiskeniyle hafızaya aldık
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan=dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtBxOgrid.Text = id;
            txtBoxAd.Text = ad;
            txtBoxSoyad.Text = soyad;
            txtBoxKalan.Text = kalan;
        }
    }
}
