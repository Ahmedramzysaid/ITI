using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre first  number");
            string text1 = Console.ReadLine();
            Console.WriteLine("Entre second  number");
            string text2 = Console.ReadLine();
            Console.WriteLine("Entre third  number");
            string text3 = Console.ReadLine();

            long num1 = Convert.ToInt64(text1);
            long num2 = Convert.ToInt64(text2);
            long num3 = Convert.ToInt64(text3);
            /*-n1 + n2 * n3*/
            Console.WriteLine($"{num1 * -1} * {num2} * {num3} = {num1 * -1 * num2 * num3}");
            /*(35 + 5) % 7*/
            Console.WriteLine("Entre first  number");
            text1 = Console.ReadLine();
            Console.WriteLine("Entre second  number");
            text2 = Console.ReadLine();
            Console.WriteLine("Entre third  number");
            text3 = Console.ReadLine();

            num1 = Convert.ToInt64(text1);
            num2 = Convert.ToInt64(text2);
            num3 = Convert.ToInt64(text3);
            Console.WriteLine($"({num1} + {num2}) % {num3} = {(num1 + num2) % num3}");
            /*14 + -4 * 6 / 11*/
            Console.WriteLine("Entre first  number");
            text1 = Console.ReadLine();
            Console.WriteLine("Entre second  number");
            text2 = Console.ReadLine();
            Console.WriteLine("Entre third  number");
            text3 = Console.ReadLine();
            Console.WriteLine("Entre four  number");
            string text4 = Console.ReadLine();
            num1 = Convert.ToInt64(text1);
            num2 = Convert.ToInt64(text2);
            num3 = Convert.ToInt64(text3);
            long num4 = Convert.ToInt64(text4);
            Console.WriteLine($"{num1} + {num2 * -1} * {num3} /  {num4} = {(num1 + num2 * -1) * num3 / num4}");
            /*2 + 15 / 6 * 1 - 7 % 2*/
            Console.WriteLine("Entre first  number");
            text1 = Console.ReadLine();
            Console.WriteLine("Entre second  number");
            text2 = Console.ReadLine();
            Console.WriteLine("Entre third  number");
            text3 = Console.ReadLine();
            Console.WriteLine("Entre four  number");
            text4 = Console.ReadLine();
            Console.WriteLine("Entre five  number");
            string text5 = Console.ReadLine();
            Console.WriteLine("Entre six  number");
            string text6 = Console.ReadLine();
            num1 = Convert.ToInt64(text1);
            num2 = Convert.ToInt64(text2);
            num3 = Convert.ToInt64(text3);
            num4 = Convert.ToInt64(text4);
            long num5 = Convert.ToInt64(text5);
            long num6 = Convert.ToInt64(text6);
            Console.WriteLine($"{num1} + {num2} / {num3} * {num4} - {num5} % {num6} = { num1 + num2 / num3 * num4 - num5 % num6}" );

        }
    }
}