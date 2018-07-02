using System;

namespace Learn.CSharp.Language
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual void PerformTricks()
        {
            Console.WriteLine("{0} is performing some tricks", this.Name);
        }
    }
}
