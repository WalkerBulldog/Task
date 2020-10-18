using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Trapezoid
    {
        public double TopEdge { get; }
        public double BottomEdge { get; }
        public double Height { get; }
        public Trapezoid(double BottomEdge, double TopEdge, double Height)
        {
            this.BottomEdge = BottomEdge;
            this.TopEdge = TopEdge;
            this.Height = Height;
        }
        public double Perimeter()
        {
            double edge = Math.Sqrt(Height * Height + (BottomEdge - TopEdge) * (BottomEdge - TopEdge) / 4);
            return edge * 2 + BottomEdge + TopEdge;
        }
        public double Area()
        {
            return (BottomEdge + TopEdge) * Height / 2;
        }
        public bool ItsRight()
        {
            if (BottomEdge > 0 && TopEdge > 0 && Height > 0)
                return true;
            return false;
            
        }
    }
}
