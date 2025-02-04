using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Circle : Geoshape
    {

        public Circle() : base()
        { }

        public Circle(double _x) : base(_x, _x) { }
        public override double Area()
        {
            return MathF.PI * d1 * d2;
        }


    }
}
