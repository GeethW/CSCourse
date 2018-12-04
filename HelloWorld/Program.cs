using System;
using System.Text;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);
        }
    }
}
