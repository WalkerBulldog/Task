using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures

{
    /// <summary>
    /// Класс квадрата
    /// </summary>
    public class Square
    {
        public double Edge { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Edge">Сторона квадрата</param>
        public Square(double Edge)
        {
            this.Edge = Edge;
        }
        /// <summary>
        /// Считает периметр
        /// </summary>
        /// <returns>Значение периметра</returns>
        public double Perimeter()
        {
            return Edge * 4;
        }
        /// <summary>
        /// Считает площадь
        /// </summary>
        /// <returns>Значение площади</returns>
        public double Area()
        {
            return Edge * Edge;
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
