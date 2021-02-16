using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryObject
{
    public class Triangle : Figure
    {

        public override string Name => "Треугольник";

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA > 0 ? sideA : throw new ArgumentException("Сторона А меньше 0");
            SideB = sideB > 0 ? sideB : throw new ArgumentException("Сторона B меньше 0");
            SideC = sideC > 0 ? sideC : throw new ArgumentException("Сторона C меньше 0");
        }
        
        public bool IsRightTriangle()
        {
            return SideA > SideB && SideA > SideC ? Pefagor(SideA, SideB, SideC)
                 : SideB > SideA && SideB > SideC ? Pefagor(SideB, SideA, SideC)
                 : SideC > SideA && SideC > SideB ? Pefagor(SideC, SideA, SideB)
                 : false;
        }

        public override double GetSquare()
        {
            double halfPerimetr = HalfPerimetr();
            return Math.Pow(halfPerimetr * (halfPerimetr - SideA) * (halfPerimetr - SideB) * (halfPerimetr - SideC), 0.5);
        }

        private bool Pefagor(double a, double b, double c)
        {
            return a * a == (b * b + c * c);
        }
        private double HalfPerimetr()
        {
            return (SideA + SideB + SideC) / 2;
        }
        public override string Show()
        {
            return base.Show() + $"\n Трегольник прямоугольный:{(IsRightTriangle() ? "Да" : "Нет")}";
        }
    }
}
