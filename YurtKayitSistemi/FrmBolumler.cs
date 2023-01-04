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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl =new SqlBaglantim();//nesne oluşturduk.Oluşturduğumuz nesneyi çağırdık
        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet1.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet1.Bolumler);
        }
        private void pctrBoxAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ekleme Başarılı.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet1.Bolumler);//bilgileri anlık tabloya yazdırmak için
            }
            catch 
            {
                MessageBox.Show("Hata Oluştu.Yeniden Deneyin.");
            }
        }
        private void pctrBoxDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtBolumId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Silindi.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet1.Bolumler);
            }
            catch
            {
                MessageBox.Show("Hata Oluştu.Yeniden Deneyin.");
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBolumId.Text = id;
            txtBolumAd.Text = bolumad;
        }
        private void pctrBoxEdit_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut3 = new SqlCommand("update Bolumler set Bolumad=@p1 where Bolumid=@p2", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p2", txtBolumId.Text);
                komut3.Parameters.AddWithValue("p1", txtBolumAd.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet1.Bolumler);
                MessageBox.Show("Güncelleme Başarılı.");
            }
            catch 
            {
                MessageBox.Show("Hata oluştu.Yeniden Deneyin.");
            }
        }
    }
}
