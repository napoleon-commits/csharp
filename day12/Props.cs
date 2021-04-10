using System;

public interface IShape
{
    int sides
    {
        get;
        set;
    }

    double area();
}

public class Square : IShape
{
    private int inSides;
    public int sideLength;

    public double area()
    {
        return ((double) (sideLength * sideLength));
    }

    public int sides
    {
        get {return inSides; }
        set {inSides = value; }
    }

    public Square()
    {
        sides = 4;
    }
}

public class Props
{
    public static void Main()
    {
        Square mySquare = new Square();
        mySquare.sideLength = 5;

        Console.WriteLine("\nDisplaying Square information:");
        Console.WriteLine("Area: {0}", mySquare.area());
        Console.WriteLine("Sides: {0}", mySquare.sides);
    }
}