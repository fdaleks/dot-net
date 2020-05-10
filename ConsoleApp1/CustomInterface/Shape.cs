using System;

namespace CustomInterface
{
    abstract class Shape
    {
        public string ShapeName { get; set; }

        public Shape(string name = "NoName")
        {
            ShapeName = name;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Name of the shape is {ShapeName}");
        }

        public abstract void Paint(string color);
    }
}
