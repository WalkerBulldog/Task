using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Класс равнобедренного треугольника
    /// </summary>
    public class Triangle
    {
        public double Basis { get;  }
        public double Height { get; }
        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="Basis">Основание треугольника</param>
        /// <param name="Height">Высота треугольника</param>
        public Triangle(double Basis, double Height)
        {
            this.Basis = Basis;
            this.Height = Height;
        }
        /// <summary>
        /// Считает периметр
        /// </summary>
        /// <returns>Значение периметра</returns>
        public double Perimeter()
        {
            double edge = Math.Sqrt(Basis * Basis / 4 + Height * Height);
            return edge * 2 + Basis;
        }
        /// <summary>
        /// Считает площадь
        /// </summary>
        /// <returns>Значение площади</returns>
        public double Area()
        {
            return Basis * Height / 2;
        }
        /// <summary>
        /// Проверка существования фигуры с заданными параметрами
        /// </summary>
        /// <returns>true, если фигура существует и false, если не существует</returns>
        public bool ItsRight()
        {
            if (Basis > 0 && Height > 0)
                return true;
            return false;
        }
    }
}
