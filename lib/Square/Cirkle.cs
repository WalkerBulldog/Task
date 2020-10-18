using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Класс окружности
    /// </summary>
    public class Cirkle
    {
        public double Radius { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Radius">Радиус окружности</param>
        public Cirkle(double Radius)
        {
            this.Radius = Radius;
        }
        /// <summary>
        /// Считает периметр
        /// </summary>
        /// <returns>Значение периметра</returns>
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        /// <summary>
        /// Считает площадь
        /// </summary>
        /// <returns>Значение площади</returns>
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        /// <summary>
        /// Проверка существования фигуры с заданными параметрами
        /// </summary>
        /// <returns>true, если фигура существует и false, если не существует</returns>
        public bool ItsRight()
        {
            if (Radius > 0)
                return true;
            return false;

        }
    }
}
