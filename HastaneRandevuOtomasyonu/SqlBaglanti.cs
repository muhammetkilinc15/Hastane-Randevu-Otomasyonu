using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HastaneRandevuOtomasyonu
{
    class SqlBaglanti
    {

        public SqlConnection baglanti()
        {
            SqlConnection baglanSql = new SqlConnection("Data Source=DESKTOP-4GP61KD;Initial Catalog=HastaneRandevuSistemi;Integrated Security=True");
            baglanSql.Open();
            return baglanSql;
        }
    }
}
