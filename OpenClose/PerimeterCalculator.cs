using System;
using System.Collections.Generic;

namespace OpenClose
{
    class PerimeterCalculator
    {
        public double CalculateTotalPerimeter(IEnumerable<GeometricShapeBase> shapes)
        {

            double totalPerimeter = 0;

            foreach(var shape in shapes)
            {
                if (shape.GetType() == typeof(Square))
                {
                    Square square = (Square)shape;
                    totalPerimeter += (square.GetSide() * 4);
                }
                else if (shape.GetType() == typeof(Rectangle))
                {
                    Rectangle rectangle = (Rectangle)shape;
                    totalPerimeter += (rectangle.GetLength() + rectangle.GetWidth()) * 2;
                }
                else
                {
                    throw new Exception($"Unsupported shape type: {shape.GetType()}");
                }


            }

            return totalPerimeter;
        }
    }
}
