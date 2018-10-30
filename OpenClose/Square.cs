namespace OpenClose
{
    class Square : GeometricShapeBase
    {
        private long side;
        public Square(long side)
        {
            this.side = side;
        }
        public double GetSide()
        {
            return side;
        }

        #region "Refactoring"
        public override double Perimeter()
        {
            return side * 4;
        }
        #endregion
    }
}
