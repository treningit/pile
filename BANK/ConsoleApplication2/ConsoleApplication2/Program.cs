using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    namespace MyName
    {
        class a { }
    }
    

          class NewChis
        {

            static public void Selection()
            {
                double a;
                double b;
                double x;
                Console.WriteLine("Введите 2 числа через , или пробел!");
                string str = Console.ReadLine();
                string[] split = str.Split(new Char[] { ' ', ',' });
                try
                {
                    if (split.Length < 2 || split.Length > 2)
                        throw new Exception("Неправельный формат ввода!!!");
                }

                catch (Exception ex) { Console.WriteLine(ex.Message); }

                if (split.Length == 2)
                {
                    a = Convert.ToDouble(split[0]);

                    b = Convert.ToDouble(split[1]);

                    try { x = -b / a; }
                    catch (DivideByZeroException di) { Console.WriteLine("На 0 никто не делит!!!"); }
                    x = -b / a;
                    Console.WriteLine("X= " + x);
                }
            }
        }

          class a
          {

          }
         // class a
         // {

          //}
        class Program
        {
            static void Main(string[] args)
            {
              //  NewChis.Selection();

            }
        }
    }
