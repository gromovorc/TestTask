using TestTaskLibrary.Abstract;
using TestTaskLibrary.Figures;

namespace TestTaskLibrary.Factories
{
    public class CircleFactory : FigureFactory
    {
        public override Circle CreateFigure(List<double> values)
        => new Circle(values[0]);
    }
}
