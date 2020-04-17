using System;
using Cars;
using Employees;
using Shapes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****\r\n");

            //WorkWithCars();
            //WorkWithEmployees();
            //WotkWithShapes();
            WorkWithPolymporphism();

            Console.ReadLine();
        }

        private static void WorkWithPolymporphism()
        {
            Shape[] shapes = { new Hexagon("Joe"), new Circle("Max"), new Hexagon("Vladislav"), new Circle("Betty")};

            foreach(var shape in shapes)
            {
                shape.Draw();
            }
        }

        private static void WotkWithShapes()
        {
            Hexagon hex = new Hexagon("John");
            hex.Draw();
            hex.Paint("blue");
            Console.WriteLine();

            Circle cir = new Circle("Linda");
            cir.Draw();
            cir.Paint("green");
            Console.WriteLine();
        }

        private static void WorkWithEmployees()
        {
            SalesPerson fred = new SalesPerson("Fred", 27, 1653, 684.70, "323-989-454", 50);
            fred.GiveBonus(117.9);
            fred.DisplayStatus();
            Console.WriteLine();

            Manager joe = new Manager("Joe", 36, 1348, 984.5, "141-585-363", 4500);
            joe.GiveBonus(300);
            joe.DisplayStatus();
            Console.WriteLine();
        }


        private static void WorkWithCars()
        {
            Car myCar = new Car(85)
            {
                Speed = 75
            };
            Console.WriteLine($"Max speed of my car is {myCar.maxSpeed}");
            Console.WriteLine($"Current speed of my car is {myCar.Speed}");

            MiniVan myVan = new MiniVan() { Speed = 60 };
            Console.WriteLine($"Max speed of my minivan is {myVan.maxSpeed}");
            Console.WriteLine($"Current speed of my minivan is {myVan.Speed}");
            
        }
    }
}
