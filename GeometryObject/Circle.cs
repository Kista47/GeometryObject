using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryObject
{
    public class Circle : Figure
    {
        public override string Name => "Окружность";

        public double Radius { get; }


        public Circle(double radius)
        {
            Radius = radius > 0 ? radius : throw new ArgumentException("Радиус меньше 0");
        }

        public override double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
