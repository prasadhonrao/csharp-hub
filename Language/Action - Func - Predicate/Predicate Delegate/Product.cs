using System.Collections.Generic;

namespace Learn.CSharp.Language
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
           
        public static List<Product> GetSampleProducts()
        {
            return new List<Product> 
            {
                new Product { Id = 1, Name = "Surface" },
                new Product { Id = 2, Name = "iPad" },
                new Product { Id = 3, Name = "iPod" },
                new Product { Id = 4, Name = "Sumsung Tablet" },
                new Product { Id = 5, Name = "Digital Camera" },
                new Product { Id = 6, Name = "Kindle Reader" }
            };
        }

        public override string ToString()
        {
            return this.Id + " " + this.Name;
        }
    }

}
