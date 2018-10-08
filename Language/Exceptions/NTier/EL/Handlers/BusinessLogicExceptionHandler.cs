using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using EL.Types;

namespace EL.Handlers
{
    public static class BusinessLogicExceptionHandler
   {
      public static bool HandleExcetion(ref System.Exception ex)
      {
         bool rethrow = false;
         if ((ex is DataAccessException) || (ex is DataAccessCustomException))
         {
            rethrow = ExceptionPolicy.HandleException(ex, "PassThroughPolicy");
            ex = new PassThroughException(ex.Message);
         }
         else if (ex is BusinessLogicCustomException)
         {
            rethrow = ExceptionPolicy.HandleException(ex, "BusinessLogicCustomPolicy");
         }
         else
         {
            rethrow = ExceptionPolicy.HandleException(ex, "BusinessLogicPolicy");
         }
         if (rethrow)
         {
            throw ex;
         }
         return rethrow;
      }

   }
}
