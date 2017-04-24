using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Ingredients
    {
        public DataTable loadIngredients()
        {
            DAO.Ingredients dao = new DAO.Ingredients();
            return dao.loadIngredients();
        }

        public DataTable searchIngredients(string keyword)
        {
            DAO.Ingredients dao = new DAO.Ingredients();
            return dao.searchIngredients(keyword);
        }
    }
}
