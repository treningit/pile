using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Humm
{
    class EmployeeIsBusiExeption:EmployeeExeption
    {
        private string WorkDescription;
        private DateTime RemainingDate;
        public string WORKDESCRIPTION { get { return WorkDescription; } set { WorkDescription = value; } }
        public DateTime REMAININGDATE { get { return RemainingDate; } set { RemainingDate = value; } }

        public EmployeeIsBusiExeption():base() { }
        public EmployeeIsBusiExeption(string S):base(S)
        {

        }
        public EmployeeIsBusiExeption(string S,Exception InnerExeption):base(S,InnerExeption) { }
        public EmployeeIsBusiExeption(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
