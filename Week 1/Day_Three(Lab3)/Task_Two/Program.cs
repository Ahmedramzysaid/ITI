using System;
using System.Collections.Generic;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Person person = new Person();
             person.DataPerson();
             person.DisplayDataperson();
             */
            /*Student student = new Student();
            student.DataStudent();
            student.DisplayDataStudent();*/
            /*
            Teacher Teacher =  new Teacher() ;
            Teacher.DataTeacher() ;
            Teacher.DisplayInfoTeacher() ;
            */
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSchool Management System");
                Console.WriteLine("1. Add Teacher");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Exit");
                int choice = int.Parse(Console.ReadLine()); ;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEntering Teacher Data:");
                        Teacher teacher = new Teacher();

                        teacher.DataTeacher();
                        Console.WriteLine("\nTeacher Information:");
                        teacher.DisplayInfoTeacher();
                        break;
                    case 2:
                        Console.WriteLine("\nEntering Student Data:");
                        Student student = new Student();

                        student.DataStudent();
                        Console.WriteLine("\nStudent Information:");
                        student.DisplayDataStudent();


                        break;
                    default:
                        flag = false;
                        Console.WriteLine("Thank you for using the School Management System!");
                        break;
                }

                


            }
        }
                
                
            }

        
    
    class Person
    {
        protected int id;
        protected string fname;
        protected string lname;
        protected string address;
        protected int age;

        public Person()
        {
            id =  0 ;
            fname = "";
            lname = "";
            address = "";
            age = 0;
        }
        public virtual void DataPerson()
        {
            Console.Write("Enter ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter First Name: ");
            fname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            lname = Console.ReadLine();

            Console.Write("Enter Address: ");
            address = Console.ReadLine();

            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());
        }

        public virtual void DisplayDataperson()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {fname} {lname}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Age: {age}");
        }


    }
    class Teacher :  Person 
    {
        protected int salary;
        protected List<string> subjects;
        public Teacher() : base()
        {
            salary = 0;
            subjects = new List<string>();
        }
        public virtual void DataTeacher()
        {
            DataPerson();
            Console.Write("Enter Salary: ");
            salary = int.Parse(Console.ReadLine());
            Console.Write("Enter number of subjects: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter subject {i + 1}: ");
                subjects.Add(Console.ReadLine());
            }
        }
        public virtual void DisplayInfoTeacher()
        {
            DisplayDataperson();
            Console.WriteLine($"Salary: {salary}");
            for (int i = 0; i <  subjects.Count; i++)
            {
                Console.WriteLine($"- {subjects[i]}");
            }
        }


    }
    class Student : Person
    {
        private int schoolYear;
        private string _class_ ;
        public Student() : base() 
        {
            schoolYear = 0;
            _class_ = null;
        }
        public virtual void DataStudent()
        {
            DataPerson();
            Console.Write("Enter School Year: ");
            schoolYear = int.Parse(Console.ReadLine());
            Console.Write("Enter Class: ");
            _class_ = (Console.ReadLine());
        }


        public virtual void DisplayDataStudent()
        {
            DisplayDataperson();
            Console.WriteLine($"SchoolYear: {schoolYear}");
            Console.WriteLine($"Class: {_class_}");
        }

    }
}
    
