using Shapes.Library.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Library.Models
{
    public class Circle : Shape
    {
        public override double Area
        {
            get => Math.PI * (Radius * Radius);
        }

        public override double Perimeter
        {
            get => 2 * Math.PI * Radius;
        }
        
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public Circle(Circle other) : this(other.Radius)
        {
            Radius = other.Radius;
        }

        public override Shape Clone() => new Circle(this);

        public override string WriteInfo() => $"Circle: Radius={Radius:F2}, Area={Area:F2}, Perimeter={Perimeter:F2}";
    }
}
