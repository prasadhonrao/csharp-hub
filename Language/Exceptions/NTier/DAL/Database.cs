using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Database
    {
        public List<Product> GetProducts()
        {
            var context = new NorthwindEntities();
            return context.Products.ToList();
        }
    }
}
