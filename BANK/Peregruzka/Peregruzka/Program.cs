using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peregruzka
{
    class CPoint
    {
        int x;
        int y;
    public CPoint(int q=1,int w=2)
    {
        x = q;
        y = w;
    }
    public static CPoint operator ++(CPoint a)
    {
        a.x++;
        a.y++;
        return a;
    }
    public static CPoint operator --(CPoint a)
    {
        a.x--;
        a.y--;
        return a;
    }
        //перегрузка ToStringa
    public override string ToString()
    {
        return string.Format("X={0},Y={1}",x,y);
    }
        
        //Операторы преобразования
        public static explicit operator int (CPoint p)
        {
            return (int) Math.Sqrt(p.x * p.x + p.y * p.y);

        }
        public static implicit operator double(CPoint p)
        {
            return Math.Sqrt(p.x * p.x + p.y * p.y);

        }

        public static implicit operator CPoint(int e)
        {
            return new CPoint(e,e);
        }
        public static explicit operator CPoint(double e)
        {
            return new CPoint((int)e,(int)e);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CPoint s = new CPoint(1,2);
            /*Console.WriteLine(s);
            s--;
            Console.WriteLine(s);
            s++;
            Console.WriteLine(s);*/
            int Toch =(int) s;
            Console.WriteLine(Toch);
            double tOCH2 = s;
            Console.WriteLine(tOCH2);
            s = 31;
            Console.WriteLine(s.ToString());
            s = (CPoint)34.7;
            Console.WriteLine(s.ToString());
        }
    }
}
