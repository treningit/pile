using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Humm
{
    class EmployeeExeption:ApplicationException
    {
        public EmployeeExeption():base() { }
        public EmployeeExeption(string S):base(S)
        {

        }
        public EmployeeExeption(string S,Exception InnerExeption):base(S,InnerExeption) { }
        public EmployeeExeption(SerializationInfo info,StreamingContext context):base(info,context) { }
    }
}
