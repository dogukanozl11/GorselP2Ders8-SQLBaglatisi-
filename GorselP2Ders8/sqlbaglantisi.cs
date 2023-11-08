using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselP2Ders8
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-MJGGV3B;Initial Catalog=il_ilceler;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
