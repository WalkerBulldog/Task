using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle
    {
        public double Basis { get;  }
        public double Height { get; }
        public Triangle(double Basis, double Height)
        {
            this.Basis = Basis;
            this.Height = Height;
        }
        public double Perimeter()
        {
            double edge = Math.Sqrt(Basis * Basis / 4 + Height * Height);
            return edge * 2 + Basis;
        }
        public double Area()
        {
            return Basis * Height / 2;
        }
        public bool ItsRight()
        {
            if (Basis > 0 && Height > 0)
                return true;
            return false;
        }
    }
}
