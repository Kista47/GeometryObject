using System;
using GeometryObject;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure1 = new Circle(10);
            Console.WriteLine(figure1.Show());

            Figure figure2 = new Triangle(3,4,5);
            Console.WriteLine(figure2.Show());

            Figure figure3 = new Triangle(4, 4, 5);
            Console.WriteLine(figure3.Show());

        }
    }
}
