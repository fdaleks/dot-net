using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
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
