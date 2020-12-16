using System;
//notes
// for, for each - used for anything that has an array in it. While loops - as long as the condition is valid the loop with execute. Usually at the end of while loops we incrememnt. Do while - the loop is executed at least once becuase hte conditon is evalted at hte end of the loop

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i=1; i <= 10; i++)
            {
                if(i % 2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}