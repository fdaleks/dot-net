using System;

namespace Employees
{
    abstract partial class Employee
    {
        protected BenefitPackage empBenefits = new BenefitPackage();

        protected string empName;

        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }

        public string Name
        {
            get => empName;
            set
            {
                if (value.Length > 15) Console.WriteLine("Error! Name lenght exceeds 15 characters!");
                else empName = value;
            }
        }

        public int Age { get; set; }
        public int Id { get; set; }
        public double Pay { get; set; }
        public string Phone { get; set; }

        public Employee() { }

        public Employee(string name, int age, int id) : this(name, age, id, 0) { }

        public Employee(string name, int age, int id, double pay)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
        }

        public Employee(string name, int age, int id, double pay, string phone) : this(name, age, id, pay)
        {
            Phone = phone;
        }
    }
}
