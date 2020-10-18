using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle
    {
        public double Length { get; }
        public double Width { get; }
        public Rectangle(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public double Perimeter()
        {
            return 2 * (Length + Width);
        }
        public double Area()
        {
            return Length * Width;
        }
        public bool ItsRight()
        {
            if (Length > 0 && Width > 0)
                return true;
            return false;

        }
    }
}
