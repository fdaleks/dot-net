using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Car
    {
        public readonly int maxSpeed;
        private int curSpeed;

        public Car()
        {
            maxSpeed = 70;
        }

        public Car(int max)
        {
            maxSpeed = max;
        }

        public int Speed
        {
            get => curSpeed;
            set
            {
                curSpeed = value;
                if (curSpeed > maxSpeed) curSpeed = maxSpeed;
            }
        }

    }
}
