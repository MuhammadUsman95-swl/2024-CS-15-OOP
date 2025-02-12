using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Circle c1 = new Circle();
            Circle c2 = new Circle();
            Circle c3 = new Circle();
            c2.radius = 10.0;
            c3.color = "White Gora";
            Console.WriteLine(c1.radius);
           Console.WriteLine(c1.color);
            Console.WriteLine(c2.radius);
            Console.WriteLine(c3.color);

        }
        class Circle
        {
            public Circle()
            {
                radius = 1.0;
                color = "red";
            }
            public Circle(double r)
            {
                radius = r;
            }
            public Circle(double r, string c)
            {
                radius = r;
                color = c;
            }

            public double radius;
            public string color;
        }
    }
}
