namespace SquareCounter;

public class Triangle : IFigure
{
    public double GetSquare()
    {
        double halfPerimetr = (BigBoard + SecondSmallBoard + FirstSmallBoard) / 2;
        return Math.Sqrt(halfPerimetr*(halfPerimetr-BigBoard)*(halfPerimetr-FirstSmallBoard)*(halfPerimetr-SecondSmallBoard));
    }

    private double BigBoard;
    private double FirstSmallBoard;
    private double SecondSmallBoard;


    public Triangle(params double[] args)
    {
        if (args.Length != 3)
            throw new Exception("Неверное количестов аргументов отлично от 3");
        if (args.Any(board => board <= 0))
            throw new Exception("Аргументы содержат отрицательное значение");
        Array.Sort(args);
        Array.Reverse(args);
        BigBoard = args[0];
        FirstSmallBoard = args[1];
        SecondSmallBoard = args[2];
        IsItExsist();
    }

    private void IsItExsist()
    {
        if (FirstSmallBoard + SecondSmallBoard <= BigBoard)
            throw new Exception("Такого треугольника не может существовать");
    }

    public bool IsItRectAngular()
    {
        if (Math.Pow(BigBoard, 2) == (Math.Pow(FirstSmallBoard, 2) + Math.Pow(SecondSmallBoard, 2)))
            return true;
        return false;
    }
}