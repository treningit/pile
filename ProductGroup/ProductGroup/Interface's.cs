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
