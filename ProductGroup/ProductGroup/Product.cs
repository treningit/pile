using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace ProductGroup
{
    abstract class Product
    {
        private string name;
        private decimal price;
        private bool defect;
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public bool Defect
        {
            get { return defect; }
            set { defect = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
    }
}
