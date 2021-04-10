using System;

public interface IShape
{
    int shapeShifter(int val);
    int sides {get; set;}
}

public class Shape : IShape
{
    public int inSides;
    
    public int sides
    {
        get { return inSides; }
        set { inSides = value; }
    }

    int IShape.shapeShifter(int val)
    {
        Console.WriteLine("Shifting Shape....");
        val += 1;
        return val;
    }

    public Shape()
    {
        sides = 5;
    }
}

public class Hide
{
    public static void Main()
    {
        Shape myShape = new Shape();

        Console.WriteLine("My shape has been created.");
        Console.WriteLine("Using get accessor. Sides = {0}", myShape.sides);

        IShape tmp = (IShape) myShape;
        myShape.sides = tmp.shapeShifter(myShape.sides);

        Console.WriteLine("ShapeShifter called. Sides = {0}", myShape.sides);
    }
}