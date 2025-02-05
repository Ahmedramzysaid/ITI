namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex a =  new Complex(100,200);
            Complex b = new Complex(300, 400);
            Complex x = a + b;
            Console.WriteLine(x.ToString());
            x++;
            Console.WriteLine(x.ToString());
            x = x + 100; 
            Console.WriteLine(x.ToString());
            Console.WriteLine(a>b);
            Console.WriteLine(a < b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            int m = (int) a;
            Console.WriteLine(m);

            Duration obj = new Duration(3600);
            Console.WriteLine(obj.ToString());
            Duration obj4 = new Duration(3660);
            Console.WriteLine(obj4.ToString());

            Duration obj5 = new Duration(3605);
            Console.WriteLine(obj5.ToString());

            Duration obj1 = new Duration(1800);
            Console.WriteLine(obj1.ToString());

            Duration obj2 = new Duration(1805);
            Console.WriteLine(obj2.ToString());

            Duration obj6 = new Duration(5);
            Console.WriteLine(obj6.ToString());



        }
    }
}
