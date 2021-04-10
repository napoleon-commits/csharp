using System;

public class Circle
{
    public int x;
    public int y;
    public double radius;
    private const float PI = 3.14159F;

    public double Area()
    {
        return Area(radius);
    }

    public double Area(double rad)
    {
        double theArea;
        theArea = PI * rad * rad;
        Console.WriteLine("The area for radius ({0}) is {1}", rad, theArea);
        return theArea;
    }

    public double Area(int x1, int y1, double rad)
    {
        return Area(rad);
    }

    public double Area(int x1, int y1, int x2, int y2)
    {
        int xDiff;
        int yDiff;
        double rad;

        xDiff = x2 - x1;
        yDiff = y2 - y1;

        rad = (double) Math.Sqrt((xDiff * xDiff)+(yDiff*yDiff));

        return Area(rad);
    }

    public Circle()
    {
        x = 0;
        y = 0;
        radius = 0.0;
    }
}

class CircleApp
{
    public static void Main()
    {
        Circle myCircle = new Circle();

        Console.WriteLine("Passing nothing...");
        myCircle.Area();

        Console.WriteLine("\nPadding a radius of 3...");
        myCircle.Area(3);

        Console.WriteLine("\nPassing a center of (2,4) and a radius of 3...");
        myCircle.Area(2,4,3);

        Console.WriteLine("\nPassing center of (2,3) and a point of (4,5)...");
        myCircle.Area(2,3,4,5);
    }
}