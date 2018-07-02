using System.Collections.Generic;

namespace Learn.CSharp.Language
{
    class ProductComparerGeneric : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
