using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7_lab_7_
{
    public  class Point
    {
        private int x;
        private int y;
        public Point(int _x, int _y)
        {
            x =  _x;
            y = _y;
        }
        public Point()
        {
            x = 0;
            y = 0;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object? obj)
        {
            
            Point right = obj as Point;
            return this.X == right.X && this.Y == right.Y;
        }
    }
}
