using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyName
{
    class incrementr
    {
        int count;
        public incrementr(int a)
        {
            count = a;
        }
        public int Multiinkrement()
        {
            count += 5;
            return count;
        }
    }
}
namespace Namiki
{
    class incrementr
    {
        int count;
        public incrementr(int a)
        {
            count = a;
        }
        public int SuperMultiinkrement()
        {
            count += 100;
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            incrementr a = new incrementr(6);
            Console.WriteLine(a.SuperMultiinkrement());
            MyName.incrementr d = new MyName.incrementr(5);
            Console.WriteLine(d.Multiinkrement());
        }
    }
}
