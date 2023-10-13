using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure.Figures
{
    public class Circle : IFigure
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            init
            {
                if (value >= 0) _radius = value;
                else throw new ArgumentOutOfRangeException(nameof(Radius),"Радиус не должен быть отрицательным");
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea() => Math.PI * Radius * Radius;
    }
}
