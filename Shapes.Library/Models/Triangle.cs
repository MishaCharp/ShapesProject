using Shapes.Library.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Library.Models
{
    public class Triangle : Shape
    {
        public override double Area
        {
            get => 0.5 * a * h;
        }

        public override double Perimeter
        {
            get => Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
        }

        /// <summary>
        /// Первая сторона треугольника
        /// </summary>
        public double FirstSide { get; set; }
        /// <summary>
        /// Вторая сторона треугольника
        /// </summary>
        public double SecondSide { get; set; }
        /// <summary>
        /// Третья сторона треугольника
        /// </summary>
        public double ThirdSide { get; set; }
        /// <summary>
        /// Первый угол треугольника
        /// </summary>
        public double FirstAngle { get; set; }
        /// <summary>
        /// Второй угол треугольника
        /// </summary>
        public double SecondAngle { get; set; }
        /// <summary>
        /// Третий угол треугольника
        /// </summary>
        public double ThirdAngle { get; set; }

        /// <summary>
        /// Полупериметр треугольника
        /// </summary>
        private double p
        {
            get => (FirstSide + SecondSide + ThirdSide) * 0.5;
        }
        /// <summary>
        /// Высота треугольника
        /// </summary>
        private double h { get; set; }
        /// <summary>
        /// Основание треугольника
        /// </summary>
        private double a { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        public Triangle(double firstAngle, double secondAngle, double thirdAngle,double firstSide = 0, double secondSide = 0, double thirdSide = 0)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            FirstAngle = firstAngle;
            SecondAngle = secondAngle;
            ThirdAngle = thirdAngle;
        }
        public Triangle(Triangle other) : this(other.FirstSide, other.SecondSide, other.ThirdSide)
        {
            FirstSide = other.FirstSide;
            SecondSide = other.SecondSide;
            ThirdSide = other.ThirdSide;
        }

        /// <summary>
        /// Устанавливает высоту треугольника
        /// </summary>
        /// <param name="height"></param>
        public void SetHeight(double height) => h = height;
        /// <summary>
        /// Устанавливает основание треугольника
        /// </summary>
        /// <param name="height"></param>
        public void SetBase(double baseTriangle) => a = baseTriangle;

        public bool IsTriangleRight() => FirstAngle == 90 || SecondAngle == 90 || ThirdAngle == 90;

        public override string WriteInfo() => $"Triangle: Sides a,b,c=({FirstSide:F2},{SecondSide:F2},{ThirdSide:F2}), Area={Area:F2}, Perimeter={Perimeter:F2}";

        public override Shape Clone() => new Triangle(this);
    }
}
