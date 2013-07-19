using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;


namespace ProductGroup
{
    class ContractingParties
    {
        private string name;
        private string phone;
        private decimal debt;

        public ContractingParties()
        {
        }
        public ContractingParties(string[] s)
        {
            name = s[0];
            phone = s[1];
            debt = Convert.ToDecimal(s[2]);
        }

        public decimal Debt
        {
            get { return debt; }
            set { debt = value; }
        }
       
        public override string ToString()
        {
            return "Имя " + name + ", Телефон " + phone + ", Долг " + Debt;
        }
    }
}
