namespace Shapes
{
    public class Square : Rectangle
    {
        public Square(double width)
            : base(width, width)
        {

        }
        public override double CalculateSurface()
        {
            double surface = this.Wight * this.Wight;

            return surface;
        }
    }
}
