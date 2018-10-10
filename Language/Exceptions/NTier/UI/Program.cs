using BL;
using EL.Handlers;
using System;

namespace UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var bl = new Business();
                var products = bl.GetProducts(); // Reference to DAL added in UI project just for demo purpose

                foreach (var p in products)
                {
                    Console.WriteLine(p.ProductName);
                }
            }
            catch (Exception ex)
            {
                bool rethrow = false;
                rethrow = UserInterfaceExceptionHandler.HandleExcetion(ref ex);
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
       
    }
}
