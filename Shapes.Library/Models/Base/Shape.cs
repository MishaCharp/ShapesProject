using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Library.Models.Base
{
    /// <summary>
    /// Абстрактный класс фигуры
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public abstract double Area { get; }
        /// <summary>
        /// Периметр фигуры
        /// </summary>
        public abstract double Perimeter { get; }
        /// <summary>
        /// Метод, выдающий информацию о фигуре
        /// </summary>
        /// <returns></returns>
        public abstract string WriteInfo();
        /// <summary>
        /// Метод, возравращающий копию экземлпяра фигуры
        /// </summary>
        /// <returns></returns>
        public abstract Shape Clone();
    }
}
