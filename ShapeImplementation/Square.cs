using System;
using System.Collections.Generic;
using System.Text;

using ShapeInterface;

namespace ShapeImplementation
{
    public class Square : IShape
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
                return "Square";
            }
        }

        public Square(double sideLength)
        {
            side = sideLength;
            perimeter = 4 * Math.Abs(sideLength);
            area = Math.Pow(sideLength, 2);
        }

        private double area;
        private double perimeter;
        private double side;
    }
}
