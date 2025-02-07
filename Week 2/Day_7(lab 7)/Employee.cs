using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_lab_7_
{
    public class Employee : IComparable<Employee>, ICloneable
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
       

        public object Clone()
        {
            return new Employee()
            {
                Id = this.Id,
                Name = this.Name,
                Age = this.Age,
                Salary = this.Salary,
               
            };
        }
     
        public int CompareTo(Employee? obj)
        {
            return this.Age.CompareTo(obj.Age);
        }
        public override string ToString()
        {
            
        
            return $"{Id}:{Name}:{Age}:{Salary}";
        
    }

    }
}
