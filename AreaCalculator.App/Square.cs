using System;

namespace AreaofShapes
{
    public class Square : IArea
    {
        public double side;
        public Square(double side)
        {
            this.side = side;
        }

        double IArea.CalculateArea()
        {
            double area = this.side * this.side;
            return area;
        }
    }
}
