using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    public abstract class Figure
    {
        private readonly Lazy <double> _area;
        private readonly Lazy<double> _perimeter;

        public double Area => _area.Value;
        public double Perimeter => _perimeter.Value;

        public Figure()
        {
            _area = new Lazy<double>(GetArea);
            _perimeter = new Lazy<double>(GetPerimeter);
        }

        protected abstract double GetArea();
        protected abstract double GetPerimeter();




    }
}
