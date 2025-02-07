namespace Day_7_lab_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point() { X = 9, Y = 4 };
            Point p2 = new Point() { X = 5, Y = 10 };
            if (p1 ==  p2)
            {
                Console.WriteLine("Ramzy  say  Equal");
            }
            else
            {
                Console.WriteLine("Ramzy say  not Equal");
            }
            Employee[] employees = new Employee[]
            {
                new Employee{Id=1,Name="Ramzy",Age=26,Salary=1234 },
                new Employee{Id=2,Name="Said",Age=25,Salary=2234 },
               new Employee{Id=3,Name="Ahmed",Age=24,Salary=3234 },
                new Employee{Id=4,Name="Aya",Age=23,Salary=4234 },
                new Employee{Id=5,Name="Ahmed",Age=22,Salary=5234 }
            };
            Console.WriteLine("Before Sorting\n=======================================");
            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString());
            }
            Array.Sort(employees);

            Console.WriteLine("After Sorting\n=======================================");
            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
