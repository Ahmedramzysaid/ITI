using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Drived : Base
    {
        protected int z;
        public Drived()
        {
            this.z = 0;
        }
        public Drived(int _x, int _y, int _z) : base(_x, _y)
        {
            this.z = _z;
        }

        public int Z
        {
            get { return z; }
            set { z = value; }
        }
        public int sum()
        {
            return x + z + y;
        }

        public override void WhoIam()
        {
            Console.WriteLine("I am  Drived");
        }
    }
}
