using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class InventoryList
    {
        public DataTable loadIngredient()
        {
            DAO.InventoryList dao = new DAO.InventoryList();
            return dao.loadIngredient();
        }

        public DataTable searchIngredient(string keyword)
        {
            DAO.InventoryList dao = new DAO.InventoryList();
            return dao.searchIngredient(keyword);
        }
    }
}