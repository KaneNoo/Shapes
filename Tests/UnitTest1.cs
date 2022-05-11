using NUnit.Framework;
using Shapes.Models;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        #region circleTesting
        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }
        [Test]
        public void CircleAreaCalculationTest()
        {
            var circle = new Circle(10);

            var area = circle.Area;

            Assert.AreEqual(Math.Round(area, 5), Math.Round(314.1592653589, 5));
        }

        #endregion

        #region TriangleTesting

        [Test]
        public void TriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -1, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
        }

        [Test]
        public void TriangleNegativeFormingTest()
        {
            double a = 1;
            double b = 1;
            double c = 2;

            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));           
        }

        [Test]
        public void TriangleAreaCalculationTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var area = triangle.Area;

            Assert.AreEqual(area, 6);
        }

        [Test]
        public void TrianglePerimeterCalculationTest()
        {
            var triangle = new Triangle(2, 3, 4);
            var perimeter = triangle.Perimeter;

            Assert.AreEqual(perimeter, 9);
        }

        [Test]
        public void RightAngledTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            bool isRightAngled = triangle.RightAngled;

            Assert.IsTrue(isRightAngled);
        }

        [Test]
        public void NotRightAngledTriangleTest()
        {
            var triangle = new Triangle(3, 4, 6);
            bool isRightAngled = triangle.RightAngled;

            Assert.IsFalse(isRightAngled);
        }



        #endregion
    }
}