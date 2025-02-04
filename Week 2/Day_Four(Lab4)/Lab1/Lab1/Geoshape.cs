using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Geoshape
    {
        protected double d1;
        protected double d2 ;
        public Geoshape()
        {
            d1 = d2 = 0;
        }
        public Geoshape(double x)
        {
            d1 = d2 = x;
        }
        public Geoshape(double x , double y)
        {
            d1 = x;
            d2 = y;
        }
        public double D1 { get { return d1; } set { this.d1 = value; } }
        public double D2 { get { return d2; } set { this.d2 = value; } }
        public  virtual double Area()
        { return -1; }
      

    }
    
   
    
    




}
