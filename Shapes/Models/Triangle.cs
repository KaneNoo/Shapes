using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    public class Triangle : Figure
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }

        public bool RightAngled { get;}
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");

            if (!IsTriangleCanFormBySides())
            {
                throw new ArgumentException("Треугольник не может быть образован (с <= a + b)");
            }

            RightAngled = CheckIsRightAngled();
        }

        private bool CheckIsRightAngled()
        {
            var largestSide = new[] { FirstSide, SecondSide, ThirdSide }.Max();
            var maxSideSqr = largestSide * largestSide;
            return 2 * maxSideSqr == 
                FirstSide * FirstSide + 
                SecondSide * SecondSide + 
                ThirdSide * ThirdSide;
        }

        private bool IsTriangleCanFormBySides()
        {
            var largestSide = new[] { FirstSide, SecondSide, ThirdSide }.Max();
            bool canBeFormed = 2 * largestSide < GetPerimeter();
            return canBeFormed;
        }

        protected sealed override double GetArea()
        {
            double halfPerimeter = Perimeter / 2;
            double area = Math.Sqrt(
                halfPerimeter *
                (halfPerimeter - FirstSide) *
                (halfPerimeter - SecondSide) *
                (halfPerimeter - ThirdSide)
                );

            return area;
        }

        protected sealed override double GetPerimeter()
        {
            double perimeter = FirstSide + SecondSide + ThirdSide;
            return perimeter;
        }

        
    }
}
