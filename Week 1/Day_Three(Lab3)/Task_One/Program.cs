using System;
using System.Collections.Generic;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void print(List<Student> Totalnumber)
            {
                for (int i = 0; i < Totalnumber.Count; i++)
                {
                    Console.WriteLine(Totalnumber[i].PrintAsString());
                    Console.WriteLine("===================================================");
                }
            }
            List<Student> Totalnumber = new List<Student>();
            bool flag = true;
            do
            {
                Console.WriteLine("Welcome to Our School");
                Console.WriteLine("\t1 - Entre one student data");
                Console.WriteLine("\t2 - Entre many students data");
                Console.WriteLine("\t3 - If you want out you can Entre about any thing whitout 1 and 2");
                Console.WriteLine("Entre 1 to first option");
                Console.WriteLine("Entre 2 to second option");
                Console.WriteLine("Entre anything to third option");
                Console.Write("Entre your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Student student = new Student();
                        Console.WriteLine($"Now You Entre data Student \n");
                        Console.Write("Entre Name: ");
                        student.Name = Console.ReadLine();
                        bool valid_Age = true;
                        do
                        {
                            Console.Write("Entre Age: ");
                            try
                            {
                                student.Age = int.Parse(Console.ReadLine());
                                valid_Age = true;
                            }
                            catch (Exception ex)
                            {
                                Console.Write(ex.Message);
                                valid_Age = false;
                            }
                        } while (!valid_Age);
                        Console.Write("Entre SSN: ");
                        student.Ssn = int.Parse(Console.ReadLine());
                        bool valid_Address = true;
                        do
                        {
                            Console.Write("Entre Address: ");
                            try
                            {
                                student.Address = Console.ReadLine();
                                valid_Address = true;
                            }
                            catch (Exception ex)
                            {
                                Console.Write(ex.Message);
                                valid_Address = false;
                            }
                        } while (!valid_Address);
                        Totalnumber.Add(student);
                        if (Student.counter() % 10 == 0)
                        {
                            print(Totalnumber);
                        }
                        break;
                    case 2:
                        Console.Write("Entre Number Students: ");
                        int Size_Stdudents = int.Parse(Console.ReadLine());
                        for (int i = 0; i < Size_Stdudents; i++)
                        {
                            Student student_arr = new Student();
                            Console.WriteLine($"Now You Entre data Student {i + 1}");
                            Console.Write("Entre Name: ");
                            student_arr.Name = Console.ReadLine();
                            bool valid_Age1 = true;
                            do
                            {
                                Console.Write("Entre Age: ");
                                try
                                {
                                    student_arr.Age = int.Parse(Console.ReadLine());
                                    valid_Age1 = true;
                                }
                                catch (Exception ex)
                                {
                                    Console.Write(ex.Message);
                                    valid_Age1 = false;
                                }
                            } while (!valid_Age1);
                            Console.Write("Entre SSN: ");
                            student_arr.Ssn = int.Parse(Console.ReadLine());
                            bool valid_Address1 = true;
                            do
                            {
                                Console.Write("Entre Address: ");
                                try
                                {
                                    student_arr.Address = Console.ReadLine();
                                    valid_Address1 = true;
                                }
                                catch (Exception ex)
                                {
                                    Console.Write(ex.Message);
                                    valid_Address1 = false;
                                }
                            } while (!valid_Address1);
                            Totalnumber.Add(student_arr);
                            if (Student.counter() % 10 == 0)
                            {
                                print(Totalnumber);
                            }
                        }
                        break;
                    default:
                        flag = false;
                        break;
                }
            } while (flag);
            Console.WriteLine("Thank You");
        }
    }
    class Student
    {
        private int ssn;
        private string name;
        private int age;
        private string address;
        static private int cnt;

        static Student()
        {
            cnt = 1;
        }

        static public int counter()
        {
            cnt++;
            return cnt;
        }

        public int Ssn
        {
            set { ssn = value; }
            get { return ssn; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Age
        {
            set
            {
                if (value >= 23 && value <= 45)
                {
                    age = value;
                }
                else
                {
                    throw new InvalidOperationException("Age must  between 23 to  35\n");
                }
            }
            get { return age; }
        }

        public string Address
        {
            set
            {

                if (value == "Alex" || value == "Cairo" || value == "Giza")
                {
                    address = value;
                }
                else
                {
                    throw new InvalidOperationException("This School  contian Cairo , Alex or Giza\n");
                }

            }
            get { return address; }
        }

        public void PrintOnConsole()
        {
            Console.WriteLine($"SSN: {ssn}\nName: {name}\nAge: {age}\nAddress: {address}");
        }

        public string PrintAsString()
        {
            return $"SSN: {ssn}\nName: {name}\nAge: {age}\nAddress: {address}";
        }
    }
}
