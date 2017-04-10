using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DBConnection
    {
        public static SqlConnection connectDB()
        {
            string str = @"Server=DESKTOP-3DQDBDH\SQLEXPRESS;database=NhaHangDoNuong;uid=sa;pwd=123456789;";
            SqlConnection cn = new SqlConnection(str);
            cn.Open();
            return cn;
        }
    }
}
