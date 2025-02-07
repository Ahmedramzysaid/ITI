using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_lab_7_
{
    public class Student
    {
       

            public int Id { get; init; }
            public string Name { get; init; }
            public int Age { get; init; }

            public Student()
            {
                Id = 1; //  كدا كدا 
                Name = "Ramzy";
                Age = 21;
            }
            public Student(int _id, string _name, int _age)
            {
                Id = _id;
                Name = _name;
                Age = _age;
            }
            public override string ToString()
            {
                return $"{Id}:{Name}:{Age}";
            }
        }
}
