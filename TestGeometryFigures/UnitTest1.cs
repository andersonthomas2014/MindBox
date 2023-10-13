using System;
using NUnit.Framework;
using GeometricFigure.Figures;

namespace GeometricFigure.Tests
{
    public class Tests
    {
        [Test]
        public void CircleZeroRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [Test]
        public void FigureAreaTest()
        {
            IFigure figure = new Circle(5);
            Assert.AreEqual(Math.PI * 25, figure.GetArea(), "Площадь круга вычислена неверно");
            
            figure = new Triangle(9, 12, 15);
            Assert.AreEqual(9 * 12 / 2, figure.GetArea(), "Площадь треугольника вычислена неверно");
        }

        [Test]
        public void TriangleZeroSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, 0));
        }

        [Test]
        public void TriangleIsRightAngled()
        {
            var triangle = new Triangle(2,4,6);
            Assert.IsFalse(triangle.IsRightTriangle(), "Треугольник не является прямоугольным");
            
            triangle = new Triangle(9,12,15);
            Assert.IsTrue(triangle.IsRightTriangle(), "Треугольник является прямоугольным");
        }
    }
}