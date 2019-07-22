using System;
using Xunit;

namespace AreaofShapes.Test
{
    public class TestShapes
    {
        [Fact]
        public void CircleAreaTest()
        {
            double radius = 4.1;
            IArea circle = new Circle(radius);
            double expected = 52.78;

            double actual = circle.CalculateArea();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void RectangleAreaTest()
        {
            double length = 3.6;
            double breadth = 7.5;
            IArea rectangle = new Rectangle(length, breadth);
            double expected = 27;

            double actual = rectangle.CalculateArea();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void SquareAreaTest()
        {
            double side = 9.2;
            IArea square = new Square(side);
            double expected = 84.64;

            double actual = square.CalculateArea();

            Assert.Equal(expected, actual, 2);
        }

        [Fact]
        public void TriangleAreaTest()
        {
            double baseTriangle = 4.2;
            double height = 6.8;
            IArea triangle = new Triangle(baseTriangle, height);
            double expected = 14.28;

            double actual = triangle.CalculateArea();

            Assert.Equal(expected, actual, 2);
        }
    }
}
