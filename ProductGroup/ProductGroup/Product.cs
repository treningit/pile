using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
//using System.Threading.Tasks;
>>>>>>> 9f76692f16b9e412820072526aa1f0d9b17befa3

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
<<<<<<< HEAD
            get { return Name; }
            set { Name = value; }
=======
            get { return name; }
            set { name = value; }
>>>>>>> 9f76692f16b9e412820072526aa1f0d9b17befa3
        }
        
    }
}
