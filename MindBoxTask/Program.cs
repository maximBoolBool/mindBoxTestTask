using SquareCounter;

Console.WriteLine("Привет, я могу посчитать площадь любого треугольника или круга");
while (true)
{
    int k;
    Console.WriteLine("\n1-Выйти из программы\n2-Посчитать площадь треугольника\n3-Посчитать площадь круга \n");
    try
    { 
        k = Int32.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine("Неверный ввод");
        continue;
    }

    switch (k)
    {
        case 1 : 
            return ;
                    
        case 2 :
            CountTriangleSquare();
            break;
        case 3: 
            CountCircleSquare();
            break;
    }
}


void CountCircleSquare()
{
    double radius;
    Console.WriteLine("Введите радиус круга");
    try
    {
        radius = Double.Parse(Console.ReadLine());
        Circle circle = new Circle(radius);
        Console.WriteLine($"Площадь введеного круга: {circle.GetSquare()}");
    }
    catch (Exception e)
    {
        Console.WriteLine("При подсчете площади круга возникли ошибки");
        Console.WriteLine(e.Message);
    }
}
void CountTriangleSquare()
{
    double border1;
    double border2;
    double border3;
    Console.WriteLine("Введите стороны треугольника");
    try
    {
        border1 = Double.Parse(Console.ReadLine());
        border2 = Double.Parse(Console.ReadLine());
        border3 = Double.Parse(Console.ReadLine());
        Triangle triangle = new Triangle(border1,border2,border3);
        Console.WriteLine($"Площадь треугольника равна {triangle.GetSquare()}");
    }
    catch (Exception e)
    {
        Console.WriteLine("При подсчете площади треугольника возникли ошибки");
        Console.WriteLine(e.Message);
    }
}