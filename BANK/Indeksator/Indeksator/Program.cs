using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Indeksator
{
    class Shop : IEnumerable
    {
        private Laptop[] lap;
        public Shop(int size)
        {
            lap = new Laptop[size];
        }
        public int Length
        { get { return lap.Length; } }

        

        public Laptop this[int pos]
        {
            get
            {
                if (pos < 0 || pos >= this.lap.Length) throw new IndexOutOfRangeException();
                else
                    return this.lap[pos];
            }
            set { this.lap[pos] = value; }

        }

        #region IEnumerable Members 
        IEnumerator IEnumerable.GetEnumerator() { return lap.GetEnumerator(); }
        #endregion
    }


    class Laptop
    {
        string vendor;
        double price;
        public string Vendor
        {
            get { return this.vendor; }
            set { this.vendor = value; }
        }
        public double Price { get { return this.price; } set { this.price = value; } }
        public Laptop(double p = 1000, string v = "HP")
        {
            vendor = v;
            price = p;
        }
        public override string ToString()
        {
            return string.Format("Производитель={0},Цена={1}", vendor, price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shop l = new Shop(3);
            l[0] = new Laptop(9.345, "Dell");
            l[1] = new Laptop(9.3345, "HP");
            l[2] = new Laptop(9.342, "ASUS");
          
            try
            {
                /*for (int i = 0; i < l.Length; i++)
                {
                    Console.WriteLine(l[i].ToString());
                }*/
                foreach (Laptop i in l)
                {
                    Console.WriteLine(l[i].ToString());
                }
                Console.WriteLine();
                Console.WriteLine(l[6].ToString()); 
            }
            catch (IndexOutOfRangeException ex) { Console.WriteLine("Ошибка!!!!!"); }
            //Console.WriteLine(l.Vendor);
        }
    }
}
