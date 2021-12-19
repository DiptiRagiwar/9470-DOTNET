using System;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of celcius");
            int celcius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( "Kelvin = {0} ", celcius + 32);
            Console.WriteLine( "Fahrenhit = {0}", celcius*18 /10+32 );
        }
    }
}
