using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroBb
{
    class Fraction
    {
        double chis;
        double znam;

        public Fraction(double a, double b)
        {
            chis = a;
            znam = b;
        }

        public Fraction()
        {
        }

        public static Fraction operator *(Fraction a,int b)
        {
            Fraction c = new Fraction();
            c.chis = a.chis* b;
            c.znam = a.znam;
            return c;
        }
        public static Fraction operator *(int b,Fraction a )
        {
            Fraction c = new Fraction();
            c.chis = a.chis * b;
            c.znam = a.znam;
            return c;
        }
        public static Fraction operator +(Fraction a, double b)
        {
            Fraction c = new Fraction();
            c.chis = a.chis +a.znam* b;
            c.znam = a.znam;
            return c;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            c.chis = a.chis * b.chis;
            c.znam = a.znam*b.znam;
            return c;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            c.chis = a.chis * b.znam;
            c.znam = a.znam * b.chis;
            return c;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            c.chis = a.chis * b.znam + a.znam * b.chis;
            c.znam = a.znam * b.znam;
            return c;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            c.chis = a.chis * b.znam - a.znam * b.chis;
            c.znam = a.znam * b.znam;
            return c;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            if (a.chis == b.znam && a.znam == b.chis)
                return true;
            return false;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            if (a.chis != b.znam || a.znam != b.chis)
                return true;
            return false;
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            if (a.chis/a.znam -b.chis/b.znam >0 )
                return true;
            return false;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            if (a.chis / a.znam - b.chis / b.znam < 0)
                return true;
            return false;
        }

        public static bool operator true(Fraction b)
        {
            return b.chis/b.znam> 0;
        }
        public static bool operator false(Fraction b)
        {
            return b.chis / b.znam < 0;
        }
    }
}
