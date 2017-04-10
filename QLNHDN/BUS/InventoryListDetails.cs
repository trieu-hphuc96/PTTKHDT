using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class InventoryListDetails
    {
        public void addInventoryListDetails(DTO.InventoryListDetails dto, int maphieu)
        {
            DAO.InventoryListDetails dao = new DAO.InventoryListDetails();
            dao.addInventoryListDetails(dto, maphieu);
        }

        public DataTable loadInventoryListDetails(int maphieu)
        {
            DAO.InventoryListDetails dao = new DAO.InventoryListDetails();
            return dao.loadInventoryListDetails(maphieu);
        }
    }
}
