using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Square : Geoshape
    {
        public Square() : base()
        { }

        public Square(double _x) : base(_x, _x) { }
        public  override double Area()
        {
            return d1 * d2;
        }
    }
}
