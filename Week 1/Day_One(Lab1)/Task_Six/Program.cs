using System;
using System.Runtime.InteropServices;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a date (dd/mm/yyyy): ");
            string date = Console.ReadLine();


            string[] datetime = date.Split('/');
            int days = Convert.ToInt32(datetime[0]);
            int month = Convert.ToInt32(datetime[1]);
            int year = Convert.ToInt32(datetime[2]);
            if (year >= 2000 && year <= 2025)
            {
                if (month >= 1 && month <= 12)
                {

                    if (days <= 31 && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12))
                    {
                        Console.WriteLine("True ");
                    }
                    else if (days <= 30 && (month == 4 || month == 6 || month == 9 || month == 11))
                    {
                        Console.WriteLine("True ");
                    }
                    else if (days <= 28 && month == 2)
                    {
                        Console.WriteLine("True ");
                    }
                    else if (days == 29 && month == 2 && (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        Console.WriteLine("True ");
                    }
                    else
                    {
                        Console.WriteLine("False ");
                    }

                }
                else
                {
                    Console.WriteLine("false ");
                }


            }
            else
            {
                System.Console.WriteLine( "Fales");
            }
                
        }

    }
}