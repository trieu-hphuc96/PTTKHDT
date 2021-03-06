﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class GoodsReceiptDetails
    {
        public void addGoodsReceiptDetails(DTO.GoodsReceiptDetails dto, int maphieu)
        {
            try
            {
                SqlConnection cn = DBConnection.connectDB();
                SqlCommand cmd = new SqlCommand("sp_AddGoodsReceiptDetails", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maphieu", SqlDbType.Int);
                cmd.Parameters.Add("@manl", SqlDbType.Int);
                cmd.Parameters.Add("@nhacc", SqlDbType.NVarChar);
                cmd.Parameters.Add("@gianhap", SqlDbType.Int);
                cmd.Parameters.Add("@soluongnhap", SqlDbType.Decimal);
                cmd.Parameters.Add("@soluongtra", SqlDbType.Decimal);
                cmd.Parameters.Add("@lydo", SqlDbType.NVarChar);

                cmd.Parameters["@maphieu"].Value = maphieu;
                cmd.Parameters["@manl"].Value = dto.Manl;
                cmd.Parameters["@nhacc"].Value = dto.Nhacc;
                cmd.Parameters["@gianhap"].Value = dto.Gianhap;
                cmd.Parameters["@soluongnhap"].Value = dto.Soluongnhap;
                cmd.Parameters["@soluongtra"].Value = dto.Soluongtra;
                cmd.Parameters["@lydo"].Value = dto.Lydo;

                cmd.ExecuteNonQuery();

                cn.Close();
            }
            catch
            {
                MessageBox.Show("Thêm chi tiết phiếu nhập thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public DataTable loadGoodsReceiptDetails(int maphieu)
        {
            SqlConnection cn = DBConnection.connectDB();
            SqlCommand cmd = new SqlCommand("sp_LoadGoodsReceiptDetails", cn);
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
