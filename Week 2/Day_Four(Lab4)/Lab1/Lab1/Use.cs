using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
     class Use
    {
        static public double sumofArea(Rectangle[] rec  , Square[] squ  ,Triangle[] Tri , Circle[] cir)
        {
            double sum = 0; 
            for (int i = 0; i < rec.Length; i++)
            {
                sum += rec[i].Area();
            }
            for (int i = 0; i < squ.Length; i++)
            {
                sum += squ[i].Area();
            }
            for (int i = 0; i < Tri.Length; i++)
            {
                sum += Tri[i].Area();
            }
            for (int i = 0; i < cir.Length; i++)
            {
                sum += cir[i].Area();
            }
            return sum;
        }
        static public double sumofArea1(Geoshape[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length;i++)
            {
                sum += arr[i].Area();
            }
            return sum;
        }


    }
}
