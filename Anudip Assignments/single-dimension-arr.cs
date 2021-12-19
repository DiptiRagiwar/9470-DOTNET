using System;

namespace Array_single_dimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 15, 20, 100 };
            int len = arr.Length;
            Console.WriteLine("Length of Array " + len);
            Console.WriteLine(arr[0] + " " + arr[4]);
        }
    }
}
