using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhucHN3
{
    public class Shape
    {
        public virtual double CalculateArea()
        {
            Console.WriteLine("CalculateArea");
            return 0;
        }
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            Console.WriteLine("CalculateArea bi ghi de 1:");
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            Console.WriteLine("CalculateArea bi ghi de 2:");
            return Math.PI * Radius * Radius;
        }
    }
}
