using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Humm
{
    class ForseMajorExeption:EmployeeExeption
    {
        private string ForseMajorDescription;
        decimal ExtendOfDemage;

        public string FORSEMAJORDESCRIPTION { get { return ForseMajorDescription; } set { ForseMajorDescription = value; } }
        public decimal EXTENDOFDAMAGE { get { return ExtendOfDemage; } set { ExtendOfDemage = value; } }
        public ForseMajorExeption():base() { }
        public ForseMajorExeption(string S):base(S)
        {

        }
        public ForseMajorExeption(string S,Exception InnerExeption):base(S,InnerExeption) { }
        public ForseMajorExeption(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
