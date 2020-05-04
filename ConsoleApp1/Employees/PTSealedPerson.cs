using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class PTSealedPerson : SalesPerson
    {
        public PTSealedPerson(string name, int age, int id, double pay, string phone, int salesNumb) : base(name, age, id, pay, phone, salesNumb)
        {

        }
    }
}
