using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Order
    {
        public int createAOrder(DTO.Order dto_PDH)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_CreateAOrder", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manv", SqlDbType.Int);
            cmd.Parameters.Add("@ngaydat", SqlDbType.DateTime);
            cmd.Parameters.Add("@ngaygiao", SqlDbType.DateTime);
            cmd.Parameters.Add("@tinhtrang", SqlDbType.Int);
            cmd.Parameters.Add("@maphieu", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@manv"].Value = dto_PDH.Manv;
            cmd.Parameters["@ngaydat"].Value = dto_PDH.Ngaydat;
            cmd.Parameters["@ngaygiao"].Value = dto_PDH.Ngaygiao;
            cmd.Parameters["@tinhtrang"].Value = dto_PDH.Tinhtrang;
            cmd.Parameters["@maphieu"].Value = -1;

            cmd.ExecuteNonQuery();

            cn.Close();
            return Convert.ToInt32(cmd.Parameters["@maphieu"].Value);
        }

        public DataTable searchOrder_byDate(DateTime tungay, DateTime denngay)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_SearchOrder_byDate", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@tungay", SqlDbType.Date);
            cmd.Parameters.Add("@denngay", SqlDbType.Date);

            cmd.Parameters["@tungay"].Value = tungay;
            cmd.Parameters["@denngay"].Value = denngay;

            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Close();

            return dt;
        }

        public DataTable searchOrder_byNumber(string ma)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_SearchOrder_byNumber", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ma", SqlDbType.NVarChar);

            cmd.Parameters["@ma"].Value = ma;

            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Close();

            return dt;
        }

        public DataTable loadOrder()
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_LoadOrder", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Close();

            return dt;
        }

        public void cancelOrder(int maphieu)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_CancelAOrder", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maphieu", SqlDbType.Int).Value = maphieu;

            cmd.ExecuteNonQuery();

            cn.Close();
        }
    }
}
