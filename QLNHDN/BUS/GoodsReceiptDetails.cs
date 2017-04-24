using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GoodsReceiptDetails
    {
        public void addGoodsReceiptDetails(DTO.GoodsReceiptDetails dto, int maphieu)
        {
            DAO.GoodsReceiptDetails dao = new DAO.GoodsReceiptDetails();
            dao.addGoodsReceiptDetails(dto, maphieu);
        }

        public DataTable loadGoodsReceiptDetails(int maphieu)
        {
            DAO.GoodsReceiptDetails dao = new DAO.GoodsReceiptDetails();
            return dao.loadGoodsReceiptDetails(maphieu);
        }
    }
}
