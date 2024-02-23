using TestTaskLibrary.Abstract;
using TestTaskLibrary.Figures;

namespace TestTaskLibrary.Factories
{
    public class TriangleFactory : FigureFactory
    {
        public override Triangle CreateFigure(List<double> values)
        => new Triangle(values[0], values[1], values[2]);
    }
}
