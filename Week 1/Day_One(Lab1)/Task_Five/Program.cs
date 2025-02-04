using System;
using System.Runtime.InteropServices;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre number");
            string text1 = Console.ReadLine();
            int num1 = Convert.ToInt32(text1);
            Console.WriteLine($"binary  number  to  {num1} = {Convert.ToString(num1, 2)}");
        }

    }
}