using System;

namespace AreaofShapes
{
    public class Circle : IArea
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        double IArea.CalculateArea()
        {
            double area = 3.14 * this.radius * this.radius;
            return area;
        }
    }
}
