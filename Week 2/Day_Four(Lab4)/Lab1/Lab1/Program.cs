namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task one */
            /*this is problem*/
            ////  Base obj  = new Drived();
            //  //obj.WhoIam(); /// -----> I am  base
            //  //Base obj1 = new SubDrived();
            //  obj1.WhoIam(); /// ------ > I am  base
            //  Drived obj2 = new SubDrived();
            //  obj2.WhoIam();/// ------ > I am  Drived


            /*solve this problem*/
            //  use virtual  and override
            Base obj3 = new Drived();
            obj3.WhoIam();
            Base obj4 = new SubDrived();
            obj4.WhoIam();
            Drived obj5 = new SubDrived();
            obj5.WhoIam();
            /*Task  Two */
            Rectangle[] rectangles = new Rectangle[2]
           {
                new Rectangle(3,4),
                new Rectangle(2,5)
            };
            Square[] squares = new Square[3]
            {
                new Square(10),
                new Square(10),
                new Square(10),
            };

            Triangle[] triangles = new Triangle[3]
            {
                 new Triangle(3,4),
                 new Triangle(3,4),
                 new Triangle(3,4)
            };
            Circle[] circle = new Circle[2]
            {
                 new Circle(10),
                 new Circle(20)

            };
            Geoshape[] arr =
            {
                 new Rectangle(3,4),
                  new Square(10),
                   new Triangle(3,4),
                     new Circle(20)
            };
            Console.WriteLine(Use.sumofArea(rectangles, squares, triangles, circle));
            Console.WriteLine(Use.sumofArea1(arr));

        }
    }



}

