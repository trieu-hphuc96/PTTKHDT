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
    public class OrderDetails
    {
        public void addOrderDetails(DTO.OrderDetails dto, int maphieu)
        {
            try
            {
                SqlConnection cn = DBConnection.connectDB();
                SqlCommand cmd = new SqlCommand("sp_AddOrderDetails", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maphieu", SqlDbType.Int);
                cmd.Parameters.Add("@manl", SqlDbType.Int);
                cmd.Parameters.Add("@soluongdat", SqlDbType.Decimal);

                cmd.Parameters["@maphieu"].Value = maphieu;
                cmd.Parameters["@manl"].Value = dto.Manl;
                cmd.Parameters["@soluongdat"].Value = dto.Soluongdat;

                cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public DataTable loadOrderDetails(int maphieu)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_LoadOrderDetails", cn);
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
