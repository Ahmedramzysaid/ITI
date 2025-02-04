using System;
using System.Runtime.InteropServices;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre first  number");
            string text1 = Console.ReadLine();
            int num1 = Convert.ToInt32(text1);
            Console.WriteLine("Entre second  number");
            text1 = Console.ReadLine();
            int num2 = Convert.ToInt32(text1);
            Console.WriteLine("Entre third  number");
            text1 = Console.ReadLine();
            int num3 = Convert.ToInt32(text1);
            int num4 = (num1 > num2 ? num1 : num2);
            Console.WriteLine($"max =  {(num4 > num3 ? num4 : num3)}");
             num4 = (num1 < num2 ? num1 : num2);
            Console.WriteLine($"min =  {(num4 < num3 ? num4 : num3)}");

        }

    }
}