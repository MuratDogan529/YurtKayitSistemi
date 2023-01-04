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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantim mrt =new SqlBaglantim();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet10.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet10.Personel);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAdSoyad,PersonelDepartman) values(@p1,@p2)",mrt.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxPersonelGorev.Text);
           // komut.Parameters.AddWithValue("@p3", textBoxPersonelId.Text);
            komut.ExecuteNonQuery();
            mrt.baglanti().Close();
            MessageBox.Show("Kayıt Başarılı");
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet10.Personel);
            textBoxPersonelAd.Text = " ";
            textBoxPersonelGorev.Text = " ";
            textBoxPersonelId.Text = " ";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where Personelid=@p1",mrt.baglanti());
            komut.Parameters.AddWithValue("@p1",textBoxPersonelId.Text);
            komut.ExecuteNonQuery();
            mrt.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.");
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet10.Personel);
            textBoxPersonelAd.Text = " ";
            textBoxPersonelGorev.Text = " ";
            textBoxPersonelId.Text = " ";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
           ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            textBoxPersonelAd.Text = ad;
            textBoxPersonelGorev.Text = gorev;
            textBoxPersonelId.Text = id;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgun = new SqlCommand("update  Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where Personelid=@p3", mrt.baglanti());
            komutgun.Parameters.AddWithValue("@p1", textBoxPersonelAd.Text);
            komutgun.Parameters.AddWithValue("@p2", textBoxPersonelGorev.Text);
            komutgun.Parameters.AddWithValue("@p3", textBoxPersonelId.Text);
            komutgun.ExecuteNonQuery();
            mrt.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.");
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet10.Personel);
            textBoxPersonelAd.Text = " ";
            textBoxPersonelGorev.Text = " ";
            textBoxPersonelId.Text = " ";


        }
    }
}
