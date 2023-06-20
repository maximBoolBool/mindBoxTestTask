using SquareCounter;

namespace MindBoxTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        try
        {
            Triangle firstTriangle = new Triangle(1,2,3);
        }
        catch (Exception e)
        {
            Assert.Equal(e.Message,"Такого треугольника не может существовать");
        }
    }

    [Fact]
    public void Test2()
    {
        try
        {
            Triangle firstTriangle = new Triangle(1,2,3,4);
        }
        catch (Exception e)
        {
            Assert.Equal(e.Message,"Неверное количестов аргументов отлично от 3");
        }
    }
    
    [Fact]
    public void Test3()
    {
        try
        {
            Triangle firstTriangle = new Triangle(1,2,-3);
        }
        catch (Exception e)
        {
            Assert.Equal(e.Message,"Аргументы содержат отрицательное значение");
        }
    }
    
    
}