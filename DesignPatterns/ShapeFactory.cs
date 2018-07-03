using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface Shape
    {
        void Draw();
    }

    //Either Interface or Base Class, this is wonky but only for example purpose.
    public class GeometricShape : Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Inside the parent shape.");
        }
    }

    public class Triangle : GeometricShape
    {
        public override void Draw()
        {
            Console.WriteLine("Inside Triangle draw() method.");
        }
    }

    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square draw() method.");
        }
    }

    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square draw() method.");
        }
    }

    public class ShapeFactory
    {
        //use getShape method to get object of type shape
        public Shape getShape(string shapeType)
        {
            if (shapeType == null) { return null; }
            else if (shapeType.ToUpper() == "TRIANGLE") { return new Triangle(); }
            else if (shapeType.ToUpper() == "CIRCLE") { return new Circle(); }
            else if (shapeType.ToUpper() == "SQUARE") { return new Square(); }
            return null;
        }
    }

}
