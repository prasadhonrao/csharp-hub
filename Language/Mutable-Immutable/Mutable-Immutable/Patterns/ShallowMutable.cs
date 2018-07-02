using System.Text;

namespace Learn.CSharp.Language
{
    public class ShallowMutable
    {
        public int Value { get; }

        public StringBuilder Builder { get;  }
        public ShallowMutable(int value, StringBuilder builder) // StrinbBuilder is mutable
        {
            this.Value = value;
            this.Builder = builder;
        }

    }
}
