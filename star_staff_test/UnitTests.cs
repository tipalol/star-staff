using System;
using NUnit.Framework;
using star_staff.src.core;
using star_staff.src.core.figures;

namespace Tests
{
    public class Tests
    {
        Triangle triangle;

        [SetUp]
        public void Setup()
        {
            try
            {
                triangle = new Triangle(4, 5, 6);
            } catch (InvalidFigureException e)
            {
                throw new AssertionException(e.Message);
            }
        }

        [Test]
        public void TestCreateNonExistsTriangle()
        {
            try
            {
                var wrongTriangle = new Triangle(10, 2, 3);
            } catch (InvalidFigureException e)
            {
                Assert.Pass(e.Message);
            }
        }

        [Test]
        public void TestTrianglePerimeter()
        {
            const int expectedPerimeter = 15;

            var perimeter = triangle.Perimeter;

            Assert.AreEqual(expectedPerimeter, perimeter);
        }

        [Test]
        public void TestTriangleHalfPerimeter()
        {
            const double expectedHalfPerimeter = 7.5;

            var halfPerimeter = triangle.HalfPerimeter;

            Assert.AreEqual(expectedHalfPerimeter, halfPerimeter);
        }

        [Test]
        public void TestTriangleSquare()
        {
            const double expectedSquare = 9.92;

            var square = Math.Round(triangle.Square, 2);

            Assert.AreEqual(expectedSquare, square);
        }

        [Test]
        public void TestTriangleIsRightFalse()
        {
            const bool expectedIsRight = false;

            var isRight = triangle.IsRight;

            Assert.AreEqual(expectedIsRight, isRight);
        }

        [Test]
        public void TestTriangleIsRightTrue()
        {
            const bool expectedIsRight = true;
            var rightTriangle = new Triangle(3, 4, 5);

            var isRight = rightTriangle.IsRight;

            Assert.AreEqual(expectedIsRight, isRight);
        }
    }
}