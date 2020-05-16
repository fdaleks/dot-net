using System;
using CustomInterface.Interfaces;

namespace CustomInterface
{
    class Triangle : Shape, IPointy
    {
        public Triangle() { }

        public Triangle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {ShapeName} the Triangle");
        }

        public override void Paint(string color)
        {
            Console.WriteLine($"{ShapeName}'s color is {color}");
        }

        public byte Points
        {
            get { return 3; }
        }
    }
}
