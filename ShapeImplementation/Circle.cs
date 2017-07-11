using System;
using System.Collections.Generic;
using System.Text;

using ShapeInterface;

namespace ShapeImplementation
{
    public class Circle : IShape
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
                return "Circle";
            }
        }

        public Circle(double radiusLength)
        {
            side = radiusLength;
            perimeter = 2 * Math.PI * Math.Abs(radiusLength);
            area = Math.Pow(radiusLength, 2) * Math.PI;
        }

        private double area;
        private double perimeter;
        private double side;
    }
}
