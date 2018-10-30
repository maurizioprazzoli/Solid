using System.Collections.Generic;

namespace SingleResponsabilityPrinciple
{
    class PerimeterCalculatorV2
    {
        public double CalculateTotalPerimeter(IEnumerable<IGeometricShape> shapes)
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
