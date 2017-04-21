using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GoodsReceipt
    {
        public int createGoodsReceipt(DTO.GoodsReceipt dto_PNH)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_CreateGoodsReceipt", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manv", SqlDbType.Int);
            cmd.Parameters.Add("@ngaygio", SqlDbType.DateTime);
            cmd.Parameters.Add("@maphieu", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@manv"].Value = dto_PNH.Manv;
            cmd.Parameters["@ngaygio"].Value = dto_PNH.Ngaygio;
            cmd.Parameters["@maphieu"].Value = -1;

            cmd.ExecuteNonQuery();

            cn.Close();
            return Convert.ToInt32(cmd.Parameters["@maphieu"].Value);
        }

        public DataTable searchGoodsReceipt_byDate(DateTime tungay, DateTime denngay)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_SearchGoodsReceipt_byDate", cn);
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

        public DataTable searchGoodsReceipt_byNumber(string ma)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_SearchGoodsReceipt_byNumber", cn);
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

        public DataTable loadGoodsReceipt()
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_LoadGoodsReceipt", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Close();

            return dt;
        }
    }
}
