using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsabilityPrinciple
{
    class PerimeterCalculator
    {
        public void CalculateTotalPerimeter(IEnumerable<IGeometricShape> shapes)
        {

            double totalPerimeter = 0;

            foreach(var shape in shapes)
            {
                totalPerimeter += shape.Perimeter();
            }

            Console.WriteLine($"Il perimetro totale degli oggetti è: {totalPerimeter}");
        }
    }
}
