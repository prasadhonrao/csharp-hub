using DAL;
using EL.Handlers;
using System;
using System.Collections.Generic;

namespace BL
{
    public class Business
    {
        public IEnumerable<Product> GetProducts()
        {
            try
            {
                throw new ApplicationException("exception in BL");
                var dal = new Database();
                return dal.GetProducts();
            }
            catch (Exception ex)
            {
                bool rethrow = false;
                rethrow = BusinessLogicExceptionHandler.HandleExcetion(ref ex);
                if (rethrow)
                {
                    throw ex;
                }
                return null;
            }
        }
    }
}
