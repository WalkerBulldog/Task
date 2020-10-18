using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Класс шестиугольника
    /// </summary>
    public class Hexagon
    {
        public double Edge { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Edge">Сторона шестиугольника</param>
        public Hexagon(double Edge)
        {
            this.Edge = Edge;
        }
        /// <summary>
        /// Считает периметр
        /// </summary>
        /// <returns>Значение периметра</returns>
        public double Perimeter()
        {
            return Edge * 6;
        }
        /// <summary>
        /// Считает площадь
        /// </summary>
        /// <returns>Значение площади</returns>
        public double Area()
        {
            return 3 * Math.Sqrt(3) * Edge * Edge / 2;
        }
        /// <summary>
        /// Проверка существования фигуры с заданными параметрами
        /// </summary>
        /// <returns>true, если фигура существует и false, если не существует</returns>
        public bool ItsRight()
        {
            if (Edge > 0)
                return true;
            return false;
        }
    }

}
