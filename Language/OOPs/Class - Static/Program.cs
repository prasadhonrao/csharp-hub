using System;
namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WindowsConfig.WindowsDirectoryName);
            Console.ReadLine();
        }
    }

    public static class WindowsConfig
    {
        public static string WindowsDirectoryName = "Windows";
    }
}
