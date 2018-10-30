using System.Collections.Generic;

namespace OpenClose
{
    class PerimeterCalculatorV2
    {
        public double CalculateTotalPerimeter(IEnumerable<GeometricShapeBase> shapes)
        {
            double totalPerimeter = 0;
            foreach (var shape in shapes)
            {
                totalPerimeter += shape.Perimeter();
            }
            return totalPerimeter;
        }
    }
}
