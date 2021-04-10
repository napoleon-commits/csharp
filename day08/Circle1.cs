using System;

public class Circle
{
    public int x;
    public int y;
    public int radius;
    private const float PI = 3.14159F;

    public double area()
    {
        return (PI * radius * radius);
    }

    public double circumfurence()
    {
        return 2 * PI * radius;
    }

    public Circle()
    {
        x = 0;
        y = 0;
        radius = 0;
    }

    public Circle(int r)
    {
        x = 0;
        y = 0;
        radius = r;
    }

    public Circle(int newX, int newY)
    {
        x = newX;
        y = newY;
        radius = 0;
    }

    public Circle(int newX, int newY, int r)
    {
        x = newX;
        y = newY;
        radius = r;
    }

    public void printCircleInfo()
    {
        Console.WriteLine("Circle:  Center  = ({0},{1})", x, y);
        Console.WriteLine("         Radius  = {0}", radius);
        Console.WriteLine("         Area    = {0}", area());
        Console.WriteLine("         Circum  = {0}", circumfurence());
    }
}

class CircleApp
{
    public static void Main()
    {
        Circle first = new Circle();
        Circle second = new Circle(4);
        Circle third = new Circle(3,4);
        Circle fourth = new Circle(1,2,5);

        Console.WriteLine("\nFirst Circle");
        first.printCircleInfo();

        Console.WriteLine("\nSecond Circle");
        second.printCircleInfo();

        Console.WriteLine("\nThird Circle");
        third.printCircleInfo();

        Console.WriteLine("\nFourth Circle");
        fourth.printCircleInfo();
    }
}