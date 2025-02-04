using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Rectangle : Geoshape
    {

        Rectangle() : base()
        { }

        public Rectangle(double _x, double _y) : base(_x, _y) { }
        public override double Area()
        {
            return d1 * d2;
        }


    }
}
