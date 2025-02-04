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


            int x = Convert.ToInt32(text1);
            /* x  =5    z  ---->  11*/
            int z = (x++) + x;
           
            Console.WriteLine(z);
            /*
             x++  this is use value in exprssion   then  update 
            +x  have new value after upate then
              5 + 6 
              
             */
        }

    }
}