using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class InventoryList
    {
        public DataTable loadIngredient()
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_LoadIngredient", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable searchIngredient(string keyword)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_SearchIngredient", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@keyword", SqlDbType.NVarChar);

            cmd.Parameters["@keyword"].Value = keyword;

            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        public int createInventoryList(DTO.InventoryList dto_PKH)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_CreateInventoryList", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manv", SqlDbType.Int);
            cmd.Parameters.Add("@ngaygio", SqlDbType.DateTime);
            cmd.Parameters.Add("@maphieu", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.Parameters["@manv"].Value = dto_PKH.Manv;
            cmd.Parameters["@ngaygio"].Value = dto_PKH.Ngaygio;
            cmd.Parameters["@maphieu"].Value = -1;

            cmd.ExecuteNonQuery();

            cn.Close();
            return Convert.ToInt32(cmd.Parameters["@maphieu"].Value);
        }

        public DataTable searchInventoryList_byDate(DateTime tungay, DateTime denngay)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_SearchInventoryList_byDate", cn);
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

        public DataTable searchInventoryList_byNumber(string ma)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_SearchInventoryList_byNumber", cn);
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

        public DataTable loadInventoryList()
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_LoadInventoryList", cn);
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
