using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Triangle : Geoshape
    {
        Triangle() : base()
        { }
        public Triangle(double _x, double _y):base(_x, _y) { }
        public override double Area()
        {
            return 0.5 * d1 * d2;
        }


    }
}
