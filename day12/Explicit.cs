using System;

public interface IShape
{
    double area();
    int sides {get;}
    void display();
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
        get {return inSides; }
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

    void IShape.display()
    {
        Console.WriteLine("\nDisplaying Squares Shape\'s information:");
        Console.WriteLine("Side length: {0}", this.sideLength);
        Console.WriteLine("Sides: {0}", this.sides);
        Console.WriteLine("Area: {0}", this.area());
    }

    void IShapeDisplay.display()
    {
        Console.WriteLine("\nThis method could draw the shape...");
    }
}

public class Explicit
{
    public static void Main()
    {
        Square mySquare = new Square();
        mySquare.sideLength = 7;

        IShape ish = (IShape) mySquare;
        IShapeDisplay ishd = (IShapeDisplay) mySquare;

        ish.display();
        ishd.display();
    }
}