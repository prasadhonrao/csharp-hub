using System.Collections;

namespace Learn.CSharp.Language
{
    class ProductComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Product)x).Name.CompareTo(((Product)y).Name);
        }
    }
}
