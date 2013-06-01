using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peregrzka2
{
    public struct DBBool
    {
        sbyte a;
        public static readonly DBBool Null = new DBBool(-1);
        public static readonly DBBool False = new DBBool(0);
        public static readonly DBBool True = new DBBool(1);
        public DBBool(int a)
        {
            this.a = (sbyte)a;
        }
        public DBBool(DBBool b)
        {
            this.a = b.a;
        }
        public static bool operator true(DBBool b)
        {
            return b.a>0;
        }
        public static bool operator false(DBBool b)
        {
            return b.a < 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DBBool Qw = new DBBool(DBBool.False);
            if (Qw)
                Console.WriteLine("Istina");
            else { Console.WriteLine("Log"); }
        }
    }
}
