using SquareCounter;

namespace MindBoxTests;

public class CircleTests
{
    [Fact]
    public void Test1()
    {
        try
        {
            Circle circle = new Circle(1,2,3);
        }
        catch (Exception e)
        {
            Assert.Equal(e.Message,"Передано неверное кол аргументов");
        }
    }
    
    [Fact]
    public void Test2()
    {
        try
        {
            Circle circle = new Circle(-1);
        }
        catch (Exception e)
        {
            Assert.Equal(e.Message,"Переданн отрицательный аргумент");
        }
    }
    
    [Fact]
    public void Test3()
    {

        Circle circle = new Circle(1);
        Assert.Equal(Math.PI,circle.GetSquare());
            
    }
    

}