using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Hexagon
    {
        public double Edge { get; }
        public Hexagon(double Edge)
        {
            this.Edge = Edge;
        }
        public double Perimeter()
        {
            return Edge * 6;
        }
        public double Area()
        {
            return 3 * Math.Sqrt(3) * Edge * Edge / 2;
        }
        public bool ItsRight()
        {
            if (Edge > 0)
                return true;
            return false;
        }
    }

}
