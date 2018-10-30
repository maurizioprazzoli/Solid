namespace SingleResponsabilityPrinciple
{
    class Square : IGeometricShape
    {
        private long side;
        public Square(long side)
        {
            this.side = side;
        }
        public double Perimeter()
        {
            return side * 4;
        }
    }
}
