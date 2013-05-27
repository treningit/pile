using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Humm
{
    class KranchExeption:EmployeeExeption
    {
        public KranchExeption():base() { }
        public KranchExeption(string S):base(S)
        {

        }
        public KranchExeption(string S,Exception InnerExeption):base(S,InnerExeption) { }
        public KranchExeption(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
