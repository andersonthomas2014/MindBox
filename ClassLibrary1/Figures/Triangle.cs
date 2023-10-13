using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure.Figures
{
    public class Triangle : IFigure
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public double FirstSide
        {
            get => _firstSide;
            set
            {
                if (value > 0) _firstSide = value;
                else throw new ArgumentOutOfRangeException(nameof(FirstSide),"Длина стороны треугольника должна быть больше нуля");
            }
        }
        public double SecondSide
        {
            get => _secondSide;
            set
            {
                if (value > 0) _secondSide = value;
                else throw new ArgumentOutOfRangeException(nameof(SecondSide),"Длина стороны треугольника должна быть больше нуля");
            }
        }
        public double ThirdSide
        {
            get => _thirdSide;
            set
            {
                if (value > 0) _thirdSide = value;
                else throw new ArgumentOutOfRangeException(nameof(ThirdSide),"Длина стороны треугольника должна быть больше нуля");
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public bool IsRightTriangle()
        {
            List<double> sides = new() { FirstSide, SecondSide, ThirdSide };
            
            double hypotenuse = sides.Max();
            sides.Remove(hypotenuse);
            
            double sumOfSquaresOfSides = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
            return Math.Abs(Math.Pow(hypotenuse,2) - sumOfSquaresOfSides) < 0.000001;
        }

        public double GetArea()
        {
            double semPer = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(semPer * (semPer - FirstSide) * (semPer - SecondSide) * (semPer - ThirdSide));
        }
    }
}