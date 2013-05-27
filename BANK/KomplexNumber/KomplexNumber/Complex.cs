using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexNumber
{
    class Complex
    {
        int x;
        int y;
        public Complex()
        {
        }
        public Complex(int a, int b)
        {
            x = a; y = b;
        }
        public int X
        { get { return x; }
            set { x = value; }
        }
        public int Y
        { get { return y; }
            set { y = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}+i{1}",x, y);
        }

        public static Complex operator *(int b,Complex a)
        {
            Complex c = new Complex();
            c.x = a.x * b;
            c.y = b * a.y;
            return c;
        }

        public static Complex operator *(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.x = a.x * b.x - a.y * b.y;
            c.y = a.x * b.y + b.x * a.y;
            return c;
        }

        public static Complex operator /(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.x = (a.x * b.x - a.y * b.y) / (b.x * b.x+b.y*b.y);
            c.y = (a.x * b.y + b.x * a.y) / (b.x * b.x + b.y * b.y);
            return c;
        }

        public static Complex operator -(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.x = a.x - b.x;
            c.y = a.y - b.y;
            return c;
        }

        public static Complex operator -(Complex a, int b)
        {
            Complex c = new Complex();
            c.x = a.x - b;
            c.y = a.y ;
            return c;
        }

        public static bool operator ==(Complex a, Complex b)
        {
            if(a.x == b.x && a.y == b.y)
            return true;
          return false;
        }

        public static bool operator !=(Complex a, Complex b)
        {
            if (a.x != b.x || a.y != b.y)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return x ^ y ;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Complex c = obj as Complex;
            if (c == null) return false;
            return (x == c.x && y == c.y);
        }
    }
}
