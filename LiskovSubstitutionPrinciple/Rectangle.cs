namespace LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        private long length;
        private long width;
        public Rectangle()
        { }
        public void SetLength(long length)
        {
            this.length = length;
        }
        public void SetWidth(long width)
        {
            this.width = width;
        }

        public double Area()
        {
            return length * width;
        }
    }
}
