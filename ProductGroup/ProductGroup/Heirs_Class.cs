using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace ProductGroup
{
    class Danger : Product, IDanger
    {
        private string category;
        public Danger()
        {
        }
        public Danger(string[] s)
        {
            Name = s[0];
            Price = Convert.ToDecimal(s[1]);
            Count = Convert.ToInt32(s[2]);
            category = s[3];
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }     
        public override string ToString()
        {
            return "Название " + Name + ", Цена " + Price +", Кол-во " + Count + ", Категория опасности" + category;
        }
    }
    class Perishable : Product, IPerishable
    {
        private DateTime end;
        private DateTime start;
        public Perishable()
        {}
        public Perishable(string[] s)
        {
            Name = s[0];
            Price = Convert.ToDecimal(s[1]);
            Count = Convert.ToInt32(s[2]);
            end = Convert.ToDateTime(s[3]);
            start = Convert.ToDateTime(s[4]);
        }
        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }
        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }
        public override string ToString()
        {
            return "Название " + Name + ", Цена " + Price + ", Кол-во " + Count +", Дата изготовления " + start + ", Дата истечения срока годности" + end;
        }
    }
    class License : Product, ILicense
    {
        private int number;
        public License()
        {
        }
        public License(string[] s)
        {
            Name = s[0];
            Price = Convert.ToDecimal(s[1]);
            Count = Convert.ToInt32(s[2]);
            number = Convert.ToInt32(s[3]);
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public override string ToString()
        {
            return "Название " + Name + ", Цена " + Price + ", Кол-во " + Count +", Номер лицензии " + number;
        }
    }
    class Fragile : Product, IFragile
    {
        private string terms;
        public Fragile()
        {
        }
        public Fragile(string[] s)
        {
            Name = s[0];
            Price = Convert.ToDecimal(s[1]);
            Count = Convert.ToInt32(s[2]);
            terms = s[3];
        }
        public string Terms
        {
            get { return terms; }
            set { terms = value; }
        }
        public override string ToString()
        {
            return "Название " + Name + ", Цена " + Price +", Кол-во " + Count + ", Хрупкость " + terms;
        }
    }
}
