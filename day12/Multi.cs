using System;

public interface IShape
{
    double area();
    int sides {get;}
}

public interface IShapeDisplay
{
    void display();
}

public class Square : IShape, IShapeDisplay
{
    private int inSides;
    public int sideLength;

    public int sides
    {
        get {return inSides;}
    }

    public double area()
    {
        return ((double) (sideLength * sideLength));
    }

    public double circumfurence()
    {
        return ((double) (sides * sideLength));
    }

    public Square()
    {
        inSides = 4;
    }

    public void display()
    {
        Console.WriteLine("\nDisplaying Square information:");
        Console.WriteLine("Side length: {0}", this.sideLength);
        Console.WriteLine("Sides: {0}", this.sides);
        Console.WriteLine("Area: {0}", this.area());
    }
}

public class Multi
{
    public static void Main()
    {
        Square mySquare = new Square();
        mySquare.sideLength = 7;

        mySquare.display();
    }
}