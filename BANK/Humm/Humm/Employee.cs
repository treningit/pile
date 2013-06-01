using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humm
{
    class Employee:Humman
    {
        bool IsWorking=false;
        public Employee():base()
        {

        }
        public Employee(string N,DateTime B):base(N,B)
        {

        }
        public Employee(string N):base(N)
        {

        }
        public override void Work()
        {

            if (IsWorking == true)
                throw new EmployeeIsBusiExeption("Сотрудник занят!");
            else
            {
                if (VerificationResourse() == true)
                {
                    try
                    {
                        IsWorking = true;
                        base.Work();
                        IsWorking = false;
                    }
                    catch (Exception ex) { throw new ForseMajorExeption("Proizoshlo ForsMajor", ex); }
                }
                else { throw new KranchExeption("А Ресурсов то нет!!!!"); }
            }
        }
        bool VerificationResourse()
        {
            return true;
        }
    }
}
