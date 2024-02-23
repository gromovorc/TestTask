using TestTaskLibrary.Abstract;

namespace TestTaskLibrary.Figures
{
    public class Circle : Figure
    {
        private double r;

        internal Circle(double r) : base("Circle")
        {
            this.r = r;
        }

        public override double CalculateArea()
            => MathF.PI * r * r;
    }
}
