using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Hexagon : Shape
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
    }
}
