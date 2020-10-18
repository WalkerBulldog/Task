using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Класс прямоугольника
    /// </summary>
    public class Rectangle
    {
        public double Length { get; }
        public double Width { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Length">Длина</param>
        /// <param name="Width">Ширина</param>
        public Rectangle(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
        /// <summary>
        /// Считает периметр
        /// </summary>
        /// <returns>Значение периметра</returns>
        public double Perimeter()
        {
            return 2 * (Length + Width);
        }
        /// <summary>
        /// Считает площадь
        /// </summary>
        /// <returns>Значение площади</returns>
        public double Area()
        {
            return Length * Width;
        }
        /// <summary>
        /// Проверка существования фигуры с заданными параметрами
        /// </summary>
        /// <returns>true, если фигура существует и false, если не существует</returns>
        public bool ItsRight()
        {
            if (Length > 0 && Width > 0)
                return true;
            return false;

        }
    }
}
