using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*task one */
            Console.WriteLine("this program  sum two numbres ");
            Console.WriteLine("Entre first  number");
            string text  = Console.ReadLine();
            Console.WriteLine("Entre second  number");
            string text1 = Console.ReadLine();
            long num1  = Convert.ToInt64(text);
            long num2 = Convert.ToInt64(text1);
            Console.WriteLine($"{num1} +  {num2} =  {num1 + num2}");
            /*****************************************************************************************/
   


        }
    }
}