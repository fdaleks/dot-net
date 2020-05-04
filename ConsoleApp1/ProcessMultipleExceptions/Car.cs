using System;
using ProcessMultipleExceptions.Exceptions;

namespace ProcessMultipleExceptions
{
    class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool carIsDead;

        private Radio theMusicBox = new Radio();

        public Car() { }
        public Car(string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (delta < 0) throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero");
            if (carIsDead) Console.WriteLine($"{PetName} is out of order");
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    carIsDead = true;

                    CarIsDeadException ex = new CarIsDeadException($"{PetName} was overheated!", "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "http://www.Cars.com";
                    throw ex;
                }
                else
                    Console.WriteLine($"=> Current speed = {CurrentSpeed}.");
            }
        }
    }
}
