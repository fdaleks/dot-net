using System;
using CustomInterface.Interfaces;

namespace CustomInterface
{
    class CircleThreeD : Circle, IDraw3D
    {
        public new string ShapeName { get; set; }

        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Circle in 3D!");
        }
    }
}
