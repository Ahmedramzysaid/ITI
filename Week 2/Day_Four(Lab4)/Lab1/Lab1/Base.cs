using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Base
    {
        protected int x;
        protected int y;
        public Base()
        {
            x = y = 0;
        }
        public Base(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Base(int _x)
        {
            x = y = _x;
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int sum()
        {
            return x + y;
        }
        public virtual void WhoIam()
        {
            Console.WriteLine("I am  base");
        }
    }
}
