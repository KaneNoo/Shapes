using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");

            Radius = radius;
        }


        protected sealed override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        protected sealed override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
