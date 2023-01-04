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
    public partial class FrmYöneticiDüzenle : Form
    {
        public FrmYöneticiDüzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim mrt =new SqlBaglantim();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet9.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet9.Admin);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Admin (YoneticiAd,YöneticiSifre) values (@p1,@p2)",mrt.baglanti());
            komut.Parameters.AddWithValue("@p1",textBoxKullanıcıAd.Text);
            komut.Parameters.AddWithValue("@p2",textBoxYoneticiSifre.Text);
            komut.ExecuteNonQuery();
            mrt.baglanti().Close();
            textBoxKullanıcıAd.Text = " ";
            textBoxYoneticiId.Text = " ";
            textBoxYoneticiSifre.Text = " ";
            MessageBox.Show("Yönetici Eklendi");
            this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet9.Admin);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre,id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad=dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre=dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            textBoxKullanıcıAd.Text = ad;
            textBoxYoneticiSifre.Text = sifre;
            textBoxYoneticiId.Text=id;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Admin where Yoneticiid=@p1",mrt.baglanti());
            komut.Parameters.AddWithValue("@p1",textBoxYoneticiId.Text);
            komut.ExecuteNonQuery();
            mrt.baglanti().Close();
            textBoxKullanıcıAd.Text = " ";
            textBoxYoneticiId.Text = " ";
            textBoxYoneticiSifre.Text = " ";
            MessageBox.Show("Silme İşlemi Gerçekleşti.");
            this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet9.Admin);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update admin set YoneticiAd=@p1,YöneticiSifre=@p2 where Yoneticiid=@p3",mrt.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxKullanıcıAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxYoneticiSifre.Text);
            komut.Parameters.AddWithValue("@p3", textBoxYoneticiId.Text);
            komut.ExecuteNonQuery();
            mrt.baglanti().Close();
            MessageBox.Show("Güncelleme gerçekleşti.");
            this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet9.Admin);

        }
    }
}
