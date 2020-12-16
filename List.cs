using System;
using System.Collections.Generic;
//list type is a generic type. The parameter defines the type of the list. You can make a list of anything.
// Add(), AddRane(), Remove(), Indexf(), Contains(), Count()

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[3] {5, 6, 7});
            foreach(var number in numbers)
            Console.WriteLine(number);

            numbers.IndexOf(1);
            Console.WriteLine(numbers.IndexOf(1));

            Console.WriteLine(numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);
            numbers.Remove(1);

            for (var i=0; i <numbers.Count; i++)
            foreach(var number in numbers)
            {
                if(number ==1 )
                {
                    numbers.Remove(number);
                }
                foreach (var numner in numbers)
                Console.WriteLine(number);
            }
        }
    }
}