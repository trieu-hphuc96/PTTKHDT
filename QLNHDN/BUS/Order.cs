using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class Order
    {
        public int createAOrder(DTO.Order dto_PDH, DTO.OrderDetails[] dto_CT, int so_nl)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn tạo phiếu đặt hàng?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAO.Order dao_PKH = new DAO.Order();
                    int maphieu = dao_PKH.createAOrder(dto_PDH);
                    BUS.OrderDetails bus = new BUS.OrderDetails();
                    for (int i = 0; i < so_nl; i++)
                    {
                        bus.addOrderDetails(dto_CT[i], maphieu);
                    }
                    MessageBox.Show("Tạo phiếu đặt hàng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 1;
                }
                return 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm phiếu đặt thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw e;
                return 0;
            }
        }

        public DataTable searchOrder_byDate(DateTime tungay, DateTime denngay)
        {
            DAO.Order dao = new DAO.Order();
            return dao.searchOrder_byDate(tungay, denngay);
        }

        public DataTable searchOrder_byNumber(string ma)
        {
            DAO.Order dao = new DAO.Order();
            return dao.searchOrder_byNumber(ma);
        }

        public DataTable loadOrder()
        {
            DAO.Order dao = new DAO.Order();
            return dao.loadOrder();
        }

        public void cancelOrder(int maphieu)
        {
            DAO.Order dao = new DAO.Order();
            dao.cancelOrder(maphieu);
        }
    }
}
