using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryObject
{
    public abstract class  Figure
    {
        public abstract string Name { get; }
        public abstract double GetSquare();
        public virtual string Show()
        {
            return ($"Фигура называется:{Name}.У нее площадь:{GetSquare()}");
        }
    }
}
