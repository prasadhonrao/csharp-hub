using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Business
    {
        public List<Product> GetProducts()
        {
            var dal = new Database();
            return dal.GetProducts();
        }
    }
}
