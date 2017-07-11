using System;
using System.Collections.Generic;
using System.Text;

using ShapeImplementation;

namespace ShapeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeInterface.IShape shape1 = new ShapeImplementation.Circle(1);
            ShapeInterface.IShape shape2 = new ShapeImplementation.Square(2);
            ShapeInterface.IShape shape3 = new ShapeImplementation.Triangle(3);

            ShapeInterface.IShape shape4 = new ShapeImplementation.Circle(6);
            ShapeInterface.IShape shape5 = new ShapeImplementation.Square(5);
            ShapeInterface.IShape shape6 = new ShapeImplementation.Triangle(4);
            
            ShapeInterface.IShape shape7 = new ShapeImplementation.Circle(1.7);
            ShapeInterface.IShape shape8 = new ShapeImplementation.Square(2.4);
            ShapeInterface.IShape shape9 = new ShapeImplementation.Triangle(3.9);

            ShapeInterface.IShape [] shapes = 
                { shape1, shape2, shape3, shape4, shape5, shape6, shape7, shape8, shape9 };
            foreach (ShapeInterface.IShape obj in shapes)
            {
                Console.Write("Object Type:" + obj.Name + "\n");
                Console.Write("Size:" + obj.Side + "\n");
                Console.Write("Perimeter:" + obj.Perimeter + "\n");
                Console.Write("Area:" + obj.getArea() + "\n\n");
            }

            Console.ReadKey();
        }
    }
}
