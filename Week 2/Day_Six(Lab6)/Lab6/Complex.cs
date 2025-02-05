using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }
        public  Complex(int real, int imaginary)
        {
            Real = real;
            Img = imaginary;
        }
        public Complex(int real)
        {
            Real = real;
            Img = 0;
        }
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Img + b.Img);
        }
        public static Complex operator ++(Complex a)
        {
             
            return new Complex(++a.Real, ++a.Img);
        }
        public static Complex operator +(Complex left, int n )
        {
            return new Complex(left.Real+n, left.Img);
        }
        public static bool operator >(Complex left, Complex right)
        {
            return left.Real > right.Real && left.Img > right.Img;
        }
        public static bool operator <(Complex left, Complex right)
        {
            return left.Real < right.Real && left.Img < right.Img;
        }
        public static bool operator ==(Complex left, Complex right)
        {
            return left.Real == right.Real && left.Img == right.Img;
        }
        public static bool operator !=(Complex left, Complex right)
        {
            return !(left == right);
        }
        public static explicit operator int(Complex left)
        {
            return left.Real;
        }
        public override string ToString()
        {
            return $"{Real}+{Img}i";
        }
    }
}
