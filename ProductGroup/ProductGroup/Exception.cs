using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace ProductGroup
{
    class ENone : Exception // net v nalichii
    {
        public override string Message
        {
            get
            {
                return "Данного товара нет в наличии";
            }
        }
    }

    class EDate : Exception //istek srok godnosti
    {
        public override string Message
        {
            get
            {
                return "У данного товара истек срок годности";
            }
        }
    }

    class EFake : Exception //brak
    {
        public override string Message
        {
            get
            {
                return "Бракованный товар";
            }
        }
    }
}
