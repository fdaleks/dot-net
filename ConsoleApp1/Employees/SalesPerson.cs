using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; set; }

        public SalesPerson() { }

        public SalesPerson(string name, int age, int id, double pay, string phone, int salesNumb) : base(name, age, id, pay, phone) 
        {
            SalesNumber = salesNumb;
        }

        public override void GiveBonus(double bonus)
        {
            int salesBonus;
            if (SalesNumber >= 0 && SalesNumber <= 100) salesBonus = 2;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200) salesBonus = 3;
                else salesBonus = 5;
            }

            base.GiveBonus(bonus * salesBonus);
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Employee's sales number is {SalesNumber}");
        }
    }
}
