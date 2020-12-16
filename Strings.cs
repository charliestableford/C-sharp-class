// using System;

// namespace CSharpFundamentals
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
            // var fullName = "Charlie Stableford ";
            // Console.WriteLine("Trim:'{0}'", fullName.Trim());
            // Console.WriteLine("Trim:'{0}'", fullName.Trim().ToUpper());

            // var index = fullName.IndexOf(' ');
            // var firstName = fullName.Substring(0, index);
            // var lastName = fullName.Substring(index+1);
            // Console.WriteLine("FirstName: " + firstName);

            // var names = fullName.Split(' ');
            // Console.WriteLine("FirstName: " + names[0]);

            // var replace = fullName.Replace("Charlie", "Theodore");
            // Console.WriteLine(replace); // returns new string so that the origianl string is not affected.

            // var sentence = "This is a sentence";
            // const int maxLength = 20;

//             if(sentence.Length < maxLength)
//             Console.WriteLine(sentence);
//             else{
//                 var words = sentence.Split(' ');
//                 var totalCharacters = 0;
//                 var summaryWords = new List<string>();

//                 foreach(var word in words)
//                 {
//                     summaryWords.Add(word);
//                     totalCharacters += word.Length + 1;
//                     if(totalCharacters > maxLength)
//                     break;
//                 }

//                 var summary = String.Join(' ', summaryWords) + "...";
//                 Console.WriteLine(summary);
//             }
//         }
//     }
// }