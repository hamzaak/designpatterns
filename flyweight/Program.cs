using System;
using System.Collections.Generic; 

namespace flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeObjectFactory sof = new ShapeObjectFactory();

            IShape shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();
            shape = sof.GetShape("Rectangle");
            shape.Print();

            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();
            shape = sof.GetShape("Circle");
            shape.Print();

            Console.WriteLine($"\nObjects count = {sof.Count}");
            Console.ReadKey();
        }
    }

    public interface IShape
    {
        void Print();
    }

    public class Rectangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Rectangle");
        }
    }

    public class Circle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Circle");
        }
    }

    class ShapeObjectFactory
    {
        Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public int Count
        {
            get { return shapes.Count; }
        }

        public IShape GetShape(string ShapeName)
        {
            if (shapes.ContainsKey(ShapeName))
            {
                return shapes[ShapeName];
            }

            IShape shape = null;
            switch (ShapeName)
            {
                case "Rectangle":
                    shape = new Rectangle();
                    break;
                case "Circle":
                    shape = new Circle();
                    break;
                default:
                    throw new Exception("Factory cannot create the object specified");
            }

            shapes.Add(ShapeName, shape);
            return shape;
        }
    }
}
