using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TıcarıOtomasyon
{
    internal class sqlBaglantı
    {
        public SqlConnection baglanti()
        {
            //sql baglantısı aldıgım yer
            SqlConnection baglan = new SqlConnection(@"Data Source=CAN;Initial Catalog=DboTicaretOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
