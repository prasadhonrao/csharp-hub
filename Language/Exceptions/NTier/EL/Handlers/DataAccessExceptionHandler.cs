using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using EL.Types;
using System.Data.SqlClient;

namespace EL.Handlers
{
    public static class DataAccessExceptionHandler
   {
      public static bool HandleException(ref System.Exception ex)
      {
         bool rethrow = false;
         if ((ex is SqlException))
         {
            SqlException dbExp = (SqlException)ex;
            if (dbExp.Number >= 50000)
            {
               rethrow = ExceptionPolicy.HandleException(ex, "DataAccessCustomPolicy");
               ex = new DataAccessCustomException(ex.Message);
            }
            else
            {
               rethrow = ExceptionPolicy.HandleException(ex, "DataAccessPolicy");
               if (rethrow)
               {
                  throw ex;
               }
            }
         }
         else if (ex is System.Exception)
         {
            rethrow = ExceptionPolicy.HandleException(ex, "DataAccessPolicy");
            if (rethrow)
            {
               throw ex;
            }
         }
         return rethrow;
      }
   }
}
