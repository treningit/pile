using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using France;
using GB;
using Ukraine;

namespace Capitals
{
    class Program
    {
        static void Main(string[] args)
        {
            Ukraine.Kiyv a = new Kiyv(100000);
            GB.London b = new London(200000);
            France.Paris c = new Paris(150000);
            Sravn(a.Pop, b.Pop, c.Pop);
        }
        public static void Sravn(int a, int b, int c)
        {
            int[] popul=new int[3]{a,b,c};
            int max = popul[0];
            int i=0;
            int rez=0;
            foreach (int p in popul)
            {
                if (p > max)
                {
                    max = p;
                    rez=popul[i];
                }
                i++;
            }
            if (rez == a)
                Console.WriteLine("Максимальное население из введенных стран в Киеве");

            if (rez == b)
                Console.WriteLine("Максимальное население из введенных стран в Лондоне");

            if (rez == c)
                Console.WriteLine("Максимальное население из введенных стран в Париже");
        }
    }
}
