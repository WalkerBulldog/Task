using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Класс равнобедренной трапеции
    /// </summary>
    public class Trapezoid
    {
        public double TopEdge { get; }
        public double BottomEdge { get; }
        public double Height { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="BottomEdge">Нижнее основание трапеции</param>
        /// <param name="TopEdge">Верхнее основание трапеции</param>
        /// <param name="Height">Высота трапеции</param>
        public Trapezoid(double BottomEdge, double TopEdge, double Height)
        {
            this.BottomEdge = BottomEdge;
            this.TopEdge = TopEdge;
            this.Height = Height;
        }
        /// <summary>
        /// Считает периметр
        /// </summary>
        /// <returns>Значение периметра</returns>
        public double Perimeter()
        {
            double edge = Math.Sqrt(Height * Height + (BottomEdge - TopEdge) * (BottomEdge - TopEdge) / 4);
            return edge * 2 + BottomEdge + TopEdge;
        }
        /// <summary>
        /// Считает площадь
        /// </summary>
        /// <returns>Значение площади</returns>
        public double Area()
        {
            return (BottomEdge + TopEdge) * Height / 2;
        }
        /// <summary>
        /// Проверка существования фигуры с заданными параметрами
        /// </summary>
        /// <returns>true, если фигура существует и false, если не существует</returns>
        public bool ItsRight()
        {
            if (BottomEdge > 0 && TopEdge > 0 && Height > 0)
                return true;
            return false;
            
        }
    }
}
