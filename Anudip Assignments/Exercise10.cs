using System;

namespace Exercise_10_if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number to check : ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
               {
                Console.WriteLine("It Is Even Number");
            }
            else
            {
                Console.WriteLine("It Is Odd Number");
            }
            Console.ReadLine();

        }
    }
}
