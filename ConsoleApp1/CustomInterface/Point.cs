using System;

namespace CustomInterface
{
    enum PointColor
    {
        LightBlue, BloodRed, Gold
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointColor Color { get; set; }

        public Point(): this(PointColor.BloodRed) { }

        public Point(PointColor ptColor)
        {
            Color = ptColor;
        }

        public Point (int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Color = PointColor.Gold;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
            Console.WriteLine($"Point is {Color}");
        }
    }
}
