using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    internal class SalaryEmployee
    {
        protected string name;
        protected decimal basepay;

        public SalaryEmployee(string name, decimal basepay) 
        {
            this.name = name;
            this.basepay = basepay; 
        }
        public virtual decimal CalPay()
        {
            return basepay;
        }
    }
    internal class SalaryEmployee2 : SalaryEmployee
    {
        protected decimal bonuspay;
        public SalaryEmployee2(string name, decimal basepay, decimal bonuspay) : base(name, basepay)
        {
            this.bonuspay = bonuspay;
        }
        public override decimal CalPay()
        {
            return basepay+bonuspay;
        }
    }
}
