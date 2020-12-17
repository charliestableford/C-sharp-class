using System;
using System.Text;
//notes


namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);
            
        }
    }
}