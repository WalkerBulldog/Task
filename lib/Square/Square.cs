using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures

{
    public class Square
    {
        public double Edge { get; }
        public Square(double Edge)
        {
            this.Edge = Edge;
        }
        public double Perimeter()
        {
            return Edge * 4;
        }
        public double Area()
        {
            return Edge * Edge;
        }
        public bool ItsRight()
        {
            if (Edge > 0)
                return true;
            return false;
        }

    }
}
