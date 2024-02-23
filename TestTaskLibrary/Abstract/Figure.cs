namespace TestTaskLibrary.Abstract
{
    public abstract class Figure(string nameOfFigure)
    {
        public string NameOfFigure { get; } = nameOfFigure;

        public abstract double CalculateArea();

        public override string ToString()
            => $"The figure is {NameOfFigure}, it's area = {Math.Round(CalculateArea(), 2)}";
    }
}
