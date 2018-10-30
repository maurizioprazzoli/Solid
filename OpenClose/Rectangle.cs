namespace OpenClose
{
    public class Rectangle : GeometricShapeBase
    {
        private long length;
        private long width;
        public Rectangle(long length, long width)
        {
            this.length = length;
            this.width = width;
        }
        public double GetLength()
        {
            return length;
        }
        public double GetWidth()
        {
            return width;
        }

        #region "Refactoring"
        public override double Perimeter()
        {
            return ((length * 2) + (width * 2));
        }
        #endregion
    }
}
