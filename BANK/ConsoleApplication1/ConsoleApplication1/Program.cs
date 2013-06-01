using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NewChis
    {

        static public void Selection()
        {
            double a1;
            double a2;
            double b1;
            double b2;
            double c1;
            double c2;
            double x;
            double y=0;
            Console.WriteLine("Будем решать систему уравнений типа:\nA1x+B1y+C1=0\nA2x+b2*y+C2=0");

            Console.WriteLine("Введите A1");
            a1 =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Введите A2");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B1");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите B2");
            b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите C1");
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите C2");
            c2 = Convert.ToDouble(Console.ReadLine());
            try
            {
                if (a1 == 0)
                    throw new ArgumentOutOfRangeException();
                if (b2-a2*b1/a1==0)
                    throw new ArgumentOutOfRangeException();
            }
            catch (ArgumentOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            if (a1 != 0 && b2 - a2 * b1 / a1 != 0)
            {
                Console.WriteLine("y=" + (a2 * c1 / a1 - c2) / (b2 - a2 * b1 / a1));
                Console.WriteLine("x=" + (-c1 - b1 * y) / a1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NewChis.Selection();

        }
    }
}
