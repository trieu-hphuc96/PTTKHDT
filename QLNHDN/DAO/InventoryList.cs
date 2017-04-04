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
    }
}
