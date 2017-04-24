using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Login
    {
        public int checkUsername(string tendangnhap)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_CheckUsername", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tendangnhap", SqlDbType.Char);
            cmd.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@tendangnhap"].Value = tendangnhap;
            cmd.Parameters["@check"].Value = -1;

            cmd.ExecuteNonQuery();

            cn.Close();

            return Convert.ToInt32(cmd.Parameters["@check"].Value.ToString());
        }

        public Tuple<DataTable,int> checkLogin(string tendangnhap, string matkhau)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_CheckLogin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tendangnhap", SqlDbType.Char);
            cmd.Parameters.Add("@matkhau", SqlDbType.Char);
            cmd.Parameters.Add("@check", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@tendangnhap"].Value = tendangnhap;
            cmd.Parameters["@matkhau"].Value = matkhau;
            cmd.Parameters["@check"].Value = -1;

            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Close();

            return Tuple.Create(dt, Convert.ToInt32(cmd.Parameters["@check"].Value));
        }
    }
}
