using System;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0 || num > 15)
            {
                Console.WriteLine("Wrong number");
            }
            else if(num >=0 && num < 10)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("Answer is not Correct");
            }
            Console.ReadLine();
        }
    }
}
