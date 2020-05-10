using System;

namespace CustomInterface
{
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"Name of the circle is {ShapeName}");
        }

        public override void Paint(string color)
        {
            Console.WriteLine($"Color of the {ShapeName} is {color}");
        }
    }
}
