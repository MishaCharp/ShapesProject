using Shapes.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
    public class CircleTests
    {
        /// <summary>
        /// Получение площади круга
        /// </summary>
        /// <param name="r">Радиус круга</param>
        [TestCase(0)]
        [TestCase(7.5)]
        [TestCase(5)]
        public void GetArea(double r)
        {
            Circle triangle = new Circle(r);

            double areaActual = triangle.Area;
            double areaExpected = Math.PI * Math.Pow(r, 2);

            Assert.AreEqual(areaExpected, areaActual);
        }

        /// <summary>
        /// Получение периметра треугольника
        /// </summary>
        /// <param name="r">Радиус круга</param>
        [TestCase(1)]
        [TestCase(0)]
        [TestCase(5555)]
        public void GetPerimeter(int r)
        {
            Circle circle = new Circle(r);

            double perimeterActual = circle.Perimeter;

            double perimeterExpected = 2 * Math.PI * r;

            Assert.AreEqual(perimeterExpected, perimeterActual);
        }
    }
}
