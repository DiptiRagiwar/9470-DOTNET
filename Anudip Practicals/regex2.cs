using System;
using System.Text.RegularExpressions;

namespace RegularExpression2
{
    class regex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string email = "diptiragiwar@gmail.com";
            var result = Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Console.Write("is valid:{0}", result);
            Console.ReadLine();
        }
    }
}
