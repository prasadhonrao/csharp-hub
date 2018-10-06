using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class ExceptionHandler
    {
        #region Static Variables  

        private static LogWriter logWriter;
        private static readonly ExceptionPolicyFactory _exceptionPolicyFactory;
        private static readonly ExceptionManager _exceptionManager;

        #endregion

        #region Constructor  

        static ExceptionHandler()
        {
            logWriter = new LogWriterFactory().Create();
            Logger.SetLogWriter(logWriter, false);

            _exceptionPolicyFactory = new ExceptionPolicyFactory();
            _exceptionManager = _exceptionPolicyFactory.CreateManager();
        }

        #endregion

        #region Static Methods  

        /// <summary>  
        /// Performs the handling of an application towards the configured policy.         
        /// <param name="ex">Exception to handle.</param>  
        public static void HandleException(Exception ex)
        {
            Exception exceptionToThrow = null;

            //The HandleException method will return true if the exception should be (re-)thrown.  
            if (_exceptionManager.HandleException(ex, "Policy", out exceptionToThrow))
            {
                if (exceptionToThrow == null)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(exceptionToThrow.Message);
                    Console.ReadKey();
                }
            }
        }

        #endregion
    }
}
