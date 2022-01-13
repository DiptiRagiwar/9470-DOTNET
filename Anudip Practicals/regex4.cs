using System.Text.RegularExpressions;
using System;
namespace RegularExpressionsSample
{
    class regex4
    {
        static void Main(string[] args)
        {
            string regularExpression = @"^(?=.?[A - Z])(?=.?[a - z])(?=.?[0 - 9])(?=.?[#?!@$%^&*-]).{8,}$";
            Console.WriteLine("Please input password for check:");
            string inputString = Console.ReadLine();
            if (Regex.IsMatch(inputString, regularExpression))
            {
                Console.WriteLine("It's correct security password");
            }
            else
            {
                Console.WriteLine("It's incorrect Security Password.");
            }
            Console.Read();
        }
    }
}