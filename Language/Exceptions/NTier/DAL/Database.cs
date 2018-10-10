using EL.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class Database
    {
        public IEnumerable<Product> GetProducts()
        {
            try
            {
                var context = new NorthwindEntities();
                return context.Products.ToList();
            }
            catch (Exception ex)
            {
                bool rethrow = DataAccessExceptionHandler.HandleException(ref ex);
                if (rethrow)
                {
                    throw ex;
                }
                return null;
            }
        }
    }
}
