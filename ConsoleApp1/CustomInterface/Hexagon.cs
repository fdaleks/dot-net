using System;

namespace CustomInterface
{
    class Hexagon : Shape, IPointy
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"Hexagon's name is {ShapeName}");
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
