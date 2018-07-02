using Learn.CSharp.Language.Basic;
using Learn.CSharp.Language.Patterns;
using System;
using System.Text;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Level 0

            string name = " 123456 ";
            name.Trim();
            Console.WriteLine(name.Length);

            name = name.Trim(); // immutable always returns a new string
            Console.WriteLine(name.Length);

            #endregion

            #region Basic

            var r1 = new MutableRectangle();
            r1.Height = 10;
            r1.Length = 5;
            r1.Grow(10, 5);

            Console.WriteLine(r1.ToString());

            #endregion

            #region Patterns

            #region 1. Mutable
            var m = new Mutable();
            m.Value = 10;
            m.Value = 20;
            #endregion

            #region 2. ShallowMutable
            StringBuilder builder = new StringBuilder();
            builder.Append("foo");
            var sm = new ShallowMutable(10, builder);
            sm.Builder.Append("bar");
            Console.WriteLine(sm.Builder);
            #endregion

            #region 3. Popsicle
            var p = new Popsicle();
            p.Value = 10;
            p.Freeze();
            //p.Value = 20; //Bang!
            #endregion

            #region 4. ObservableImmutable

            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
