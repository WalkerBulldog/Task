using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Cirkle
    {
        public double Radius { get; }
        public Cirkle(double Radius)
        {
            this.Radius = Radius;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public bool ItsRight()
        {
            if (Radius > 0)
                return true;
            return false;

        }
    }
}
