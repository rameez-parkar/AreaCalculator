using System;

namespace AreaofShapes
{
    public class Rectangle : IArea
    {
        public double length;
        public double breadth;
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        double IArea.CalculateArea()
        {
            double area = this.length * this.breadth;
            return area;
        }
    }
}
