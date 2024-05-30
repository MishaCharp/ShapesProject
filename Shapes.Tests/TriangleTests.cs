using Shapes.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
    public class TriangleTests
    {
        /// <summary>
        /// Проверка на прямой угол
        /// </summary>
        /// <param name="x">1 угол треугольника</param>
        /// <param name="y">2 угол треугольника</param>
        /// <param name="z">3 угол треугольника</param>
        [TestCase(60, 60, 60)]
        [TestCase(90, 45, 45)]
        [TestCase(50, 50, 80)]
        public void IsTriangleRight(int x, int y, int z)
        {
            Triangle triangle = new Triangle(firstAngle: x, secondAngle: y, thirdAngle: z);
            bool isAngleRightActual = triangle.IsTriangleRight();
            bool isAngleRightExpected = x == 90 || y == 90 || z == 90;
            Assert.AreEqual(isAngleRightExpected, isAngleRightActual);
        }

        /// <summary>
        /// Получение площади треугольника
        /// </summary>
        /// <param name="a">Основание треугольника</param>
        /// <param name="h">Высота треугольника</param>
        [TestCase(1, 10)]
        [TestCase(10, 1)]
        [TestCase(5, 5)]
        public void GetArea(int a, int h)
        {
            Triangle triangle = new Triangle(1,2,3);
            triangle.SetHeight(h);
            triangle.SetBase(a);

            double areaActual = triangle.Area;
            double areaExpected = 0.5 * a * h;

            Assert.AreEqual(areaExpected, areaActual);
        }

        /// <summary>
        /// Получение периметра треугольника
        /// </summary>
        /// <param name="x">1 сторона треугольника</param>
        /// <param name="y">2 сторона треугольника</param>
        /// <param name="z">3 сторона треугольника</param>
        [TestCase(1, 2, 3)]
        [TestCase(10, 20, 30)]
        [TestCase(0, 0, 0)]
        public void GetPerimeter(int x, int y, int z)
        {
            Triangle triangle = new Triangle(x, y, z);

            double perimeterActual = triangle.Perimeter;

            double p = (x + y+ z) * 0.5;
            double perimeterExpected = Math.Sqrt(p * (p - x) * (p - y) * (p - z));

            Assert.AreEqual(perimeterExpected, perimeterActual);
        }
    }
}
