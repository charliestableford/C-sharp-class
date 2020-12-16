using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Charlie Stableford ";
            Console.WriteLine("Trim:'{0}'", fullName.Trim());
            Console.WriteLine("Trim:'{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index+1);
            Console.WriteLine("FirstName: " + firstName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
        }
    }
}