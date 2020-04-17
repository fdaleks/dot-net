using System;

namespace Employees
{
    abstract partial class Employee
    {
        public virtual void GiveBonus(double bonus) => Pay += bonus;

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Employee's name is {Name}");
            Console.WriteLine($"Employee's age is {Age} years");
            Console.WriteLine($"Employee's ID - {Id}");
            Console.WriteLine($"Employee's salary = {Pay} $");
            Console.WriteLine($"Employee's benefit: {GetBenefitCost()}");
        }

        public double GetBenefitCost()
        {
            return Benefits.ComputePayDeduction();
        }

    }
}
