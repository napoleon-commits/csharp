class Point
{
    public int x;
    public int y;
}

class LineApp
{
    public static void Main()
    {
        Point starting = new Point();
        Point ending = new Point();

        double line;

        starting.x = 1;
        starting.y = 4;
        ending.x = 10;
        ending.y = 11;

        line = System.Math.Sqrt(
            ((ending.x - starting.x)*(ending.x - starting.x))
            +((ending.y - starting.y)*(ending.y - starting.y))
        );

        System.Console.WriteLine("Point 1: ({0},{1})", starting.x, starting.y);
        System.Console.WriteLine("Point 2: ({0},{1})", ending.x, ending.y);

        System.Console.WriteLine("Length of line from Point 1 to Point 2: {0}", line);
    }
}