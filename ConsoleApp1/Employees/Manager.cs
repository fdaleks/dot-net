using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {
        public int StokOptions { get; set; }

        public Manager() { }

        public Manager(string name, int age, int id, double pay, string phone, int numbOfOpt) : base(name, age, id, pay, phone)
        {
            StokOptions = numbOfOpt;
        }

        public override void GiveBonus(double bonus)
        {
            base.GiveBonus(bonus);
            Random r = new Random();
            StokOptions += r.Next(500);
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Employee's number of stock options is {StokOptions}");
        }
    }
}
