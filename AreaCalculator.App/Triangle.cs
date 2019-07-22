using System;

namespace AreaofShapes
{
    public class Triangle : IArea
    {
        public double baseTriangle;
        public double height;
        public Triangle(double baseTriangle, double height)
        {
            this.baseTriangle = baseTriangle;
            this.height = height;
        }

        double IArea.CalculateArea()
        {
            double area = 0.5 * this.baseTriangle * this.height;
            return area;
        }
    }
}
