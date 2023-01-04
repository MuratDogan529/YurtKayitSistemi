using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace YurtKayitSistemi
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@" Data Source=erkhbn0096\MURAT;Initial Catalog=YurtOtomasyon;Persist Security Info=True;User ID=sa;Password=Together.1453");
            baglan.Open();
            return baglan;
        }
    }
}
