using System;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            new ObsoleteClass();

            new ClasswithObsoleteMember { Name = "C#" };

            // new ObsoleteClassWithErrorMessage();
        }
    }

    [Obsolete]
    class ObsoleteClass { }

    class ClasswithObsoleteMember
    {
        [Obsolete("Name is obsolete")]
        public string Name { get; set; }
    }

    [Obsolete("You are using obsolete class", true)]
    class ObsoleteClassWithErrorMessage { }
}
