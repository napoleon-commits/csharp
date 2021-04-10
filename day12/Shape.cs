using System;

public interface IShape
{
    double area();
    double circumference();
    int sides();
}

public class Circle : IShape
{
    public int x;
    public int y;
    public double radius;
    private const float PI = 3.14159F;

    public double area()
    {
        return PI * radius * radius;
    }

    public double circumference()
    {
        return ((double) (2 * PI * radius));
    }

    public int sides()
    {
        return 1;
    }

    public Circle()
    {
        x = 0;
        y = 0;
        radius = 0.0;
    }
}

public class Square : IShape
{
    public int side;

    public double area()
    {
        return ((double) (side * side));
    }

    public double circumference()
    {
        return ((double) (4 * side));
    }

    public int sides()
    {
        return 4;
    }

    public Square()
    {
        side = 0;
    }
}

public class Shape
{
    public static void Main()
    {
        Circle myCircle = new Circle();
        myCircle.radius = 5;

        Square mySquare = new Square();
        mySquare.side = 4;

        Console.WriteLine("Displaying Circle information:");
        displayInfo(myCircle);

        Console.WriteLine("\nDisplaying Square information:");
        displayInfo(mySquare);
    }

    static void displayInfo(IShape myShape)
    {
        Console.WriteLine("Area: {0}", myShape.area());
        Console.WriteLine("Sides: {0}", myShape.sides());
        Console.WriteLine("Circumfurence: {0}", myShape.circumference());
    }
}