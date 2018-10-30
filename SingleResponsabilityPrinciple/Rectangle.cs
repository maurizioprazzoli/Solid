using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsabilityPrinciple
{
    class Rectangle : IGeometricShape
    {
        private long length;
        private long width;
        public Rectangle(long length, long width)
        {
            this.length = length;
            this.width = width;
        }
        public double Perimeter()
        {
            return ((length * 2) + (width * 2));
        }
    }
}
