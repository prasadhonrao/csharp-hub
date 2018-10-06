using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string x = null;
                int a = 10;

                Console.WriteLine(int.Parse(x) + a);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(ex);
            }
        }
       
    }
}
