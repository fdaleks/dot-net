using System;
using CustomInterface.Interfaces;

namespace CustomInterface
{
    class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"Hexagon's name is {ShapeName}");
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Hexagon in 3D!");
        }

        public override void Paint(string color)
        {
            Console.WriteLine($"{ShapeName}'s color is {color}");
        }

        public byte Points
        {
            get { return 6; }
        }
    }
}
