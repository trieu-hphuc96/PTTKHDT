using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class InventoryList
    {
        public int createInventoryList(DTO.InventoryList dto_PKH, DTO.InventoryListDetails[] dto_CT, int so_nl)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn tạo phiếu kiểm hàng?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DAO.InventoryList dao_PKH = new DAO.InventoryList();
                int maphieu = dao_PKH.createInventoryList(dto_PKH);
                BUS.InventoryListDetails bus = new BUS.InventoryListDetails();
                for (int i = 0; i < so_nl; i++)
                {
                    bus.addInventoryListDetails(dto_CT[i], maphieu);
                }
                MessageBox.Show("Tạo phiếu kiểm hàng thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 1;
            }
            return 0;
        }

        public DataTable searchInventoryList_byDate(DateTime tungay, DateTime denngay)
        {
            DAO.InventoryList dao = new DAO.InventoryList();
            return dao.searchInventoryList_byDate(tungay, denngay);
        }

        public DataTable searchInventoryList_byNumber(string ma)
        {
            DAO.InventoryList dao = new DAO.InventoryList();
            return dao.searchInventoryList_byNumber(ma);
        }

        public DataTable loadInventoryList()
        {
            DAO.InventoryList dao = new DAO.InventoryList();
            return dao.loadInventoryList();
        }
    }
}