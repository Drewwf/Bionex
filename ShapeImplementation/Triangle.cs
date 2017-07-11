using System;
using System.Collections.Generic;
using System.Text;
using ShapeInterface;

namespace ShapeImplementation
{
    public class Triangle: IShape
    {
        double IShape.getArea()
        {
            return area;
        }

        double IShape.Perimeter
        {
            get
            {
                return perimeter;
            }
        }

        double IShape.Side
        {
            get
            {
                return side;
            }
        }

        string IShape.Name
        {
            get
            {
                return "Triangle";
            }
        }

        public Triangle(double sideLength)
        {
            side = sideLength;
            perimeter = 3 * Math.Abs(sideLength);
            area = Math.Pow(sideLength, 2) * Math.Sqrt(3) / 4;
        }

        private double area;
        private double perimeter;
        private double side;
    }
}
