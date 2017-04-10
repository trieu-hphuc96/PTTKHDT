using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class InventoryListDetails
    {
        public void addInventoryListDetails(DTO.InventoryListDetails dto, int maphieu)
        {
            try
            {
                SqlConnection cn = DBConnection.connectDB();
                SqlCommand cmd = new SqlCommand("sp_AddInventoryListDetails", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maphieu", SqlDbType.Int);
                cmd.Parameters.Add("@manl", SqlDbType.Int);
                cmd.Parameters.Add("@gia", SqlDbType.Int);
                cmd.Parameters.Add("@sltonlt", SqlDbType.Decimal);
                cmd.Parameters.Add("@sltontt", SqlDbType.Decimal);
                cmd.Parameters.Add("@slhu", SqlDbType.Decimal);

                cmd.Parameters["@maphieu"].Value = maphieu;
                cmd.Parameters["@manl"].Value = dto.Manl;
                cmd.Parameters["@gia"].Value = dto.Gia;
                cmd.Parameters["@sltonlt"].Value = dto.Sltonlt;
                cmd.Parameters["@sltontt"].Value = dto.Sltontt;
                cmd.Parameters["@slhu"].Value = dto.Slhu;

                cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch
            {
                MessageBox.Show("Thêm chi tiết phiếu kiểm thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable loadInventoryListDetails(int maphieu)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_LoadInventoryListDetails", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maphieu", SqlDbType.Int);

            cmd.Parameters["@maphieu"].Value = maphieu;

            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Close();

            return dt;
        }
    }
}
