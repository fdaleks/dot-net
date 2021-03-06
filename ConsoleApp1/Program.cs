﻿using System;
using System.Collections;
//using Cars;
using Employees;
//using Shapes;
//using SimpleException;
//using CustomException;
//using CustomException.Exceptions;
//using ProcessMultipleExceptions;
//using ProcessMultipleExceptions.Exceptions;
using CustomInterface;
using CustomInterface.Interfaces;
using InterfaceHierarchy;
using InterfaceHierarchy.Interfaces;
using CustomEnumerator;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****\r\n");

            //WorkWithCars();
            //WorkWithEmployees();
            //WorkWithShapes();
            //WorkWithPolymporphism();
            //WorkWithExceptions();
            //WorkWithInterface();
            //WorkWithInterfaceHierarchy();
            WorkWithCustomEnumerator();

            Console.ReadLine();
        }

        private static void WorkWithCustomEnumerator()
        {
            Garage carLot = new Garage();

            foreach (Car car in carLot)
            {
                Console.WriteLine($"{car.PetName} is going {car.CurrentSpeed} MPH");
            }
        }

        private static void WorkWithInterfaceHierarchy()
        {
            Bitmaplmage myBitmap = new Bitmaplmage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();

            //if (myBitmap is IAdvancedDraw)
            //    ((IAdvancedDraw)myBitmap).DrawUpsideDown();

            if (myBitmap is IAdvancedDraw iAdvDraw)
                iAdvDraw.DrawUpsideDown();
        }

        private static void WorkWithInterface()
        {
            //Hexagon hex = new Hexagon();
            //Console.WriteLine($"Points: {hex.Points}");

            Shape[] shapes = { new Hexagon("Joe"), new Circle("Max"), new Triangle("Vladislav"), new Circle("Betty") };

            foreach(var shape in shapes)
            {
                shape.Draw();
                if (shape is IPointy ip)
                {
                    Console.WriteLine($" -> Points: {ip.Points}");
                }
                else
                {
                    Console.WriteLine($" -> {shape.ShapeName}\'s not pointy!");
                }
                //if (shape is IDraw3D)
                //{
                //    DrawIn3D((IDraw3D)shape);
                //}
                if (shape is IDraw3D shape3D)
                {
                    DrawIn3D(shape3D);
                }
            }
        }

        static void DrawIn3D(IDraw3D it3d)
        {
            Console.WriteLine(" -> Drawing IDraw3D compatible type");
            it3d.Draw3D();
        }

        /*
        private static void WorkWithExceptions()
        {
            Car myCar = new Car("BMW", 90);
            myCar.CrankTunes(true);
            try
            {
                myCar.Accelerate(-10);
            }
            catch (CarIsDeadException ex) when (ex.ErrorTimeStamp.DayOfWeek != DayOfWeek.Friday)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ErrorTimeStamp);
                Console.WriteLine(ex.CauseOfError);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myCar.CrankTunes(false);
            }
            Console.ReadLine();
        }
        */

        /*
        private static void WorkWithPolymporphism()
        {
            Shape[] shapes = { new Hexagon("Joe"), new Circle("Max"), new Hexagon("Vladislav"), new Circle("Betty")};

            foreach(var shape in shapes)
            {
                shape.Draw();
            }
        }
        */

        /*
        private static void WorkWithShapes()
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
        */

        private static void WorkWithEmployees()
        {
            SalesPerson fred = new SalesPerson("Fred", 27, 1, 684.70, "323-989-454", 50);
            fred.GiveBonus(117.9);
            fred.DisplayStatus();
            Employee.GivePromotion(fred);
            Console.WriteLine();

            Manager joe = new Manager("Joe", 36, 2, 984.5, "141-585-363", 4500);
            joe.GiveBonus(300);
            joe.DisplayStatus();
            Employee.GivePromotion(joe);
            Console.WriteLine();

            object frank = new Manager("Frank", 34, 3, 1024.8, "481-958-326", 4200);
            Employee moonUnit = new Manager("MoonUnit Zappa", 29, 4, 1173.8, "981-783-658", 4315);
            SalesPerson jill = new PTSealedPerson("Jill", 30, 5, 1301.9, "157-349-970", 4295);
        }

        /*
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
        */
    }
}
