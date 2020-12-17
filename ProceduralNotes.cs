// using System;
// // notes: You should always separete the code form the console from the logic code. 
// //Console is only useful in Console applications


// namespace CSharpFundamentals
// {
//     internal class Program
//     {
//         public static void Main(string[] args)
//         {
//             var name = Console.ReadLine();
//             var reversed = ReverseName(name);
           
//             Console.Write("What's your name?");
//             Console.WriteLine("Reversed name: " + reversed);

//         }

//         public static string ReverseName(string name)
//         {
            
//             var array = new char[name.Length];
//             for (var i = name.Length; i>0;i--)
//             array[name.Length - i] = name[i-1];

//             var reversed = new string(array);
//             return reversed;
//         }
//     }
// }