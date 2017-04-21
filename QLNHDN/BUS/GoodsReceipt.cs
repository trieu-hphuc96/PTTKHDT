using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class GoodsReceipt
    {
        public int createGoodsReceipt(DTO.GoodsReceipt dto_PNH, DTO.GoodsReceiptDetails[] dto_CT, int so_nl)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn tạo phiếu nhập hàng?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAO.GoodsReceipt dao_PKH = new DAO.GoodsReceipt();
                int maphieu = dao_PKH.createGoodsReceipt(dto_PNH);
                BUS.GoodsReceiptDetails bus = new BUS.GoodsReceiptDetails();
                for (int i = 0; i < so_nl; i++)
                {
                    bus.addGoodsReceiptDetails(dto_CT[i], maphieu);
                }
                MessageBox.Show("Tạo phiếu kiểm hàng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
            return 0;
        }

        public DataTable searchGoodsReceipt_byDate(DateTime tungay, DateTime denngay)
        {
            DAO.GoodsReceipt dao = new DAO.GoodsReceipt();
            return dao.searchGoodsReceipt_byDate(tungay, denngay);
        }

        public DataTable searchGoodsReceipt_byNumber(string ma)
        {
            DAO.GoodsReceipt dao = new DAO.GoodsReceipt();
            return dao.searchGoodsReceipt_byNumber(ma);
        }

        public DataTable loadGoodsReceipt()
        {
            DAO.GoodsReceipt dao = new DAO.GoodsReceipt();
            return dao.loadGoodsReceipt();
        }
    }
}
