using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using EL.Types;

namespace EL.Handlers
{
    public static class UserInterfaceExceptionHandler
   {

      public static bool HandleExcetion(ref System.Exception ex)
      {
         bool rethrow = false;
         try
         {
            if (ex is BaseException)
            {
               // do nothing as Data Access or Business Logic exception has already been logged / handled
            }
            else
            {
               rethrow = ExceptionPolicy.HandleException(ex, "UserInterfacePolicy");
            }
         }
         catch (System.Exception exp)
         {
            ex = exp;
         }
         return rethrow;
      }
   }
}
