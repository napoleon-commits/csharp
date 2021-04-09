class Circle
{
    public int x;
    public int y;

    public double radius;
    public double getArea()
    {
        double theArea;
        theArea = 3.14159 * radius * radius;
        return theArea;
    }

    public double circumference()
    {
        double theCirc;
        theCirc = 2 * 3.14159 * radius;
        return theCirc;
    }
}

class CircleApp
{
    public static void Main()
    {
        Circle first = new Circle();
        Circle second = new Circle();

        double area;
        double circ;
        first.x = 10;
        first.y = 14;
        first.radius = 3;

        second.x = 10;
        second.y = 11;
        second.radius = 4;

        System.Console.WriteLine("Circle 1: Center = ({0},{1})", first.x, first.y);
        System.Console.WriteLine("Radius = {0}", first.radius);
        System.Console.WriteLine("Area = {0}", first.getArea());
        System.Console.WriteLine("Circum = {0}", first.circumference());

        area = second.getArea();
        circ = second.circumference();

        System.Console.WriteLine("\nCircle 2: Center = ({0},{1})", second.x, second.y);
        System.Console.WriteLine("Radius = {0}", second.radius);
        System.Console.WriteLine("Area = {0}", area);
        System.Console.WriteLine("Circum = {0}", circ);
    }
}