using TestTaskLibrary.Abstract;
using TestTaskLibrary.Factories;
using TestTaskLibrary.Figures;

namespace TestTaskLibrary.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        Figure figure = null!;
        FigureFactory factory = null!;
        List<double> values = [];

        string expected = null!;

        [TestMethod]
        public void TestCircleArea2()
        {
            factory = new CircleFactory();

            values = [2];
            figure = factory.CreateFigure(values);

            expected = $"The figure is Circle, it's area = {Math.Round(MathF.PI * 4d, 2)}";
            Assert.AreEqual(expected, figure.ToString());
        }

        [TestMethod]
        public void TestTriangleArea666()
        {
            factory = new TriangleFactory();

            values = [6d, 6d, 6d];
            figure = factory.CreateFigure(values);

            expected = $"The figure is Triangle, it's area = 15,59";
            Assert.AreEqual(expected, figure.ToString());
        }

        [TestMethod]
        public void TestTriangleIsRight543()
        {
            factory = new TriangleFactory();

            values = [5, 4, 3];
            Triangle triangle = (Triangle) factory.CreateFigure(values);

            Assert.AreEqual(true, triangle.IsRightTriangle());
        }
    }
}