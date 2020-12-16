using System;
// //notes
// // for, for each - used for anything that has an array in it. While loops - as long as the condition is valid the loop with execute. Usually at the end of while loops we incrememnt. Do while - the loop is executed at least once becuase hte conditon is evalted at hte end of the loop

// namespace Iteration
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for(var i=1; i <= 10; i++)
//             {
//                 if(i%2==0)
//                 {
//                     Console.WriteLine(i);
//                 }
//             }
//             for(var i = 10; i >+1; i--)
//             {
//                 if(i%2==0)
//                 {
//                     Console.WriteLine(i);
//                 }
//             }
//         }
//     }
// }

// namespace Iteration
// {
//     class Program
//     {
//         static void Main(string[] args)
        // {
            // var name = "John Smith";

            // // for (var i=0; i < name.Length; i++)
            // // {
            // //     Console.WriteLine(name[i]);
            // // }
            // foreach(var character in name)
            // {
            //     Console.WriteLine(character);
            // }
//             var numbers = new int[] {1, 2, 3, 4};

//             foreach(var number in numbers)
//             {
//                 Console.WriteLine(numbers);
//             }
//         }
//     }
// }

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            var i=0;
            while(i<=10)
            {
                if(i % 2 == 0)
                Console.WriteLine(i);
                i++;
            }
        }
    }
}