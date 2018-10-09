using BL;
using System;

namespace UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bl = new Business();
            var products = bl.GetProducts(); // Reference to DAL added in UI project just for demo purpose

            foreach (var p in products)
            {
                Console.WriteLine(p.ProductName);
            }

            Console.ReadLine();
        }
       
    }
}
