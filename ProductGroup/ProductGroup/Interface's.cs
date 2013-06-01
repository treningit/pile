using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductGroup
{
    interface IPerishable
    {
        DateTime Start
        {
            get;
            set;
        }
        DateTime End
        {
            get;
            set;
        }
    }
    interface IDanger
    {
        string Category
        {
            get;
            set;
        }
    }
    interface ILicense
    {
        int Number
        {
            get;
            set;
        }
    }
    interface IFragile
    {
        string Terms
        {
            get;
            set;
        }
    }
}
