using System;

namespace CSharpFundamentals
{
class Program
{
    static void Main(string[] args)
    {
       var timeSpan = new TimeSpan(1,2,3); // take hours, minutes, seconds
       var timeSpan1 = new TimeSpan(1,0,0);
       var timeSpan2 = TimeSpan.FromHours(1);

    }
}
}