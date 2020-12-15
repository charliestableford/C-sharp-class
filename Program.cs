using System;
//notes

//starting with
// namespace Course
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

//conditionals
//if and else or switch and conditional operators
namespace Conditionals
{
    class Program
    {
        // putting each Console.WriteLine inside its own curly braces is best practice.
        static void Main(string[] args){
            // int hour = 10;
            // if(hour > 0 && hour < 12)
            // {
            //      Console.WriteLine("It's morning");
            // }
            // else if (hour >= 12 && hour <18)
            // {
            //      Console.WriteLine("Its afternoon");
            // }
            // else
            // {
            //     Console.WriteLine("It's evening");
            // }
            // }
            // bool isGoldCustomer = true;
            // float price;
            // if(isGoldCustomer)
            //     price - 19.95f;
            // else
            //     price = 29.95f;
            
            // float price = (isGoldCustomer) ? 19.95f : 29.95f;
            // Console.WriteLine(price);

            // 
            var season = Season.Autumn;
            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autmmn and a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perefec to go to the beach");
                    break;

                default:
                    Console.WriteLine("I don't get it");
                    break;
            }

        }

    }
}

