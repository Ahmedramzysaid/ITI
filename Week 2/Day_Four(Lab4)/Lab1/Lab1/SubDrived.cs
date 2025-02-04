using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SubDrived : Drived
    {
        private int m;
        public SubDrived() { }
        public SubDrived(int _x, int _y, int _z, int _m) : base(_x, _y, _z)
        {
            m = _m;
        }
        public int M { get { return m; } set { m = value; } }
        public override void WhoIam()
        {
            Console.WriteLine("I am  SubDrived");
        }
    }
}
