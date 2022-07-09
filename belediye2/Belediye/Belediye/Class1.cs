using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Belediye
{
    public class Class1
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter DA;
        public DataSet DS;
        public SqlDataReader DR;



        public void baglanti()
        {
            con=new SqlConnection();
            con.ConnectionString = @"Data Source=IMPORTANTE\SQLEXPRESS;Initial Catalog=Belediye;Integrated Security=True";
            cmd.Connection = con;
            con.Open();
        }

        
    }
}
