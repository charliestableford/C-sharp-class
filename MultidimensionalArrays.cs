using System;

//notes - An array reps a fied number of variables in a specific type. 
// rectangular vs jagged array. With a rectangular each row has the same number of columsn. With the jagged array it is an array of arrays. It is faster to impleement useing a jagged array. The difference is tiny. Dont get stuck between the differences. All aray types are classes.

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
           {
              var numbers = new[]{3, 4, 5, 6, 7};

              // length
              Console.WriteLine("Length:" + numbers.Length);

              //IndexOf()
              var index = Array.IndexOf(numbers, 9);
              Console.WriteLine(index);

              //Clear()
              //Parameters - Array, index to clear, The numbers of elements to clear
              Array.Clear(numbers, 0, 2);
              foreach(var n in numbers)
              Console.WriteLine(n);

              //Copy
              int[] another = new int[3];
              Array.Copy(numbers, another, 3);
              Console.WriteLine("Effect of Copy()");
              foreach (var n in another)
              Console.WriteLine(n);

              //Sort
              Array.Sort(numbers);
              Console.WriteLine("Effect of Sort()");
              foreach(var n in numbers)
              Console.WriteLine(n);

              //Reverse()
              Array.Reverse(numbers); 
              Console.WriteLine("Effect of Reverse()");

           }
        }
    }
}
