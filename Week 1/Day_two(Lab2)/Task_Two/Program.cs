using System;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Welcome to Our School");
                Console.WriteLine("\t 1 - Entre one student data ");
                Console.WriteLine("\t 2 - Entre many students data ");
                Console.WriteLine("\t 3 - If you want out you  can Entre about any thing whitout 1 and 2 ");
                Console.WriteLine(" Entre 1 to first option ");
                Console.WriteLine(" Entre 2 to second option ");
                Console.WriteLine(" Entre anything to third option ");
                Console.Write("Entre your choice : ");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Student one = new Student();
                        Console.Write("Entre  student data \n");
                        Console.Write("Entre First name : ");
                        one.SetFname(Console.ReadLine());
                        Console.Write("Entre Last name : ");
                        one.SetLname(Console.ReadLine());
                        bool flag_Age = false;
                        do
                        {
                            Console.Write("Entre Age : ");
                            flag_Age = one.SetAge(int.Parse(Console.ReadLine()));
                            if (!(flag_Age))
                            {
                                Console.WriteLine("This age is not valid sou should Entre age 23 to 45");
                            }

                        } while(!(flag_Age));
                        
                        Console.Write("Entre SSN : ");
                        one.SetSSN(int.Parse(Console.ReadLine()));
                        bool flag_Address = false;
                        do
                        {
                            Console.Write("Entre Address : ");
                             flag_Address = one.SetAddress(Console.ReadLine());
                            if (!(flag_Address))
                            {
                                Console.WriteLine("This Address is not valid you should from Address is cairo, Alex or giza");
                            }

                        } while (!(flag_Address));
                        Console.WriteLine("This is data Entre to  your Student");
                        one.PrintOnConsole();
    
                        break;
                        case 2:
                        Console.Write("Entre Number Students : ");
                        int Size_Stdudents =  int.Parse(Console.ReadLine());
                        Student[] arr; 
                        arr = new Student[Size_Stdudents];
                        for (int i = 0; i  < Size_Stdudents; i++)
                        {
                            Console.WriteLine($"Now You Entre data Student {i+1}");
                            
                            Console.Write("Entre First name : ");
                            arr[i].SetFname(Console.ReadLine());
                            Console.Write("Entre Last name : ");
                            arr[i].SetLname(Console.ReadLine());
                            bool flag_Age2 = false;
                            do
                            {
                                Console.Write("Entre Age : ");
                                flag_Age2= arr[i].SetAge(int.Parse(Console.ReadLine()));
                                if (!(flag_Age2))
                                {
                                    Console.WriteLine("This age is not valid sou should Entre age 23 to 45");
                                }

                            } while (!(flag_Age2));

                            Console.Write("Entre SSN : ");
                            arr[i].SetSSN(int.Parse(Console.ReadLine()));
                            bool flag_Address2 = false;
                            do
                            {
                                Console.Write("Entre Address : ");
                                flag_Address2 = arr[i].SetAddress(Console.ReadLine());
                                if (!(flag_Address2))
                                {
                                    Console.WriteLine("This Address is not valid you should from Address is cairo, Alex or giza");
                                }
                                Console.WriteLine($"This is data Entre to  your Student {i + 1}");
                                Console.WriteLine(arr[i].PrintAsString());

                            } while (!(flag_Address2));
                            
                        }
                        break;
                        default:
                                  flag = false;
                                  break;


                }



            } while (flag);
            Console.WriteLine("Thank  You");


        }

    }
    struct Student {
        private int SSN;
        private string FName; 
        private string LName;
        private int Age;
        private string Address ;
       
        public  void SetFname(string _FName) {

            FName = _FName;
        }
        public string GetFname()
        {

            return FName;
        }
        public void SetLname(string _LName)
        {

            LName = _LName;
        }
        public string GetLname()
        {

            return LName;
        }
        public void SetSSN(int _SSN)
        {

            SSN = _SSN;
        }
        public int GetSNN()
        {

            return SSN;
        }
        public bool SetAddress(string _Address)
        {
            if ((_Address == "Cairo") ||  (_Address == "Alex") || (_Address == "Giza"))
            {
            Address = _Address;
                return true;

            }
            else
            {
                Console.WriteLine("Address is not valid in school");
                return false;
            }

        }
        public string GetAddress()
        {

            return Address;
        }
        public bool SetAge(int _Age)
        {
            if (_Age >=23  && _Age <= 45)
            {
            Age = _Age;
                return true;
            }
            else
            {
               Console.WriteLine("this age in not not valid");
                return false;
            }
        }
        public int GetAge()
        {

            return Age;
        }
        public void PrintOnConsole()
        {
            Console.WriteLine($"SSN  : {SSN}\nFirst name : {FName}\nLast name : {LName}\nAge: {Age}\nAddress : {Address}");
        }
        public string  PrintAsString()
        {
            return ($"SSN  : {SSN}\nFirst name : {FName}\nLast name : {LName}\nAge: {Age}\nAddress : {Address}");
        }
    };


} 