namespace SquareCounter;

public class Circle : IFigure
{
    private double radius;

    public Circle(params double[] args)
    {
        if (args.Length != 1)
            throw new Exception("Передано неверное кол аргументов");

        if (args[0] <= 0)
            throw new Exception("Переданн отрицательный аргумент");
        
        
        radius = args[0];
    }
    
    
    public double GetSquare()
    {
        return Math.PI * radius;
    }
    
}