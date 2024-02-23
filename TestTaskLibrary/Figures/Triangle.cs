using TestTaskLibrary.Abstract;

namespace TestTaskLibrary.Figures
{
    public class Triangle : Figure
    {
        private double a, b, c;
        //Предполагаю, что нет необходимости проверки на валидность ввода
        internal Triangle(double a, double b, double c) : base("Triangle")
        {
            this.a = a; this.b = b; this.c = c;
        }
        //Предполагаю, что данная проверка нужна заказчику
        public bool IsRightTriangle()
        => a * a == b * b + c * c
            || b * b == a * a + c * c
            || c * c == a * a + b * b;
        public override double CalculateArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
