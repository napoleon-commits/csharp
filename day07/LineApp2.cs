struct Point
{
    public int x;
    public int y;
}

struct Line
{
    public Point starting;
    public Point ending;

    public double length()
    {
        double len = 0;
        len = System.Math.Sqrt(
            (ending.x - starting.x)
            *(ending.x - starting.x)
            +(ending.y - starting.y)
            *(ending.y - starting.y)
        );
        return len;
    }
}

class LineApp
{
    public static void Main()
    {
        Line myLine;

        myLine.starting.x = 1;
        myLine.starting.y = 4;
        myLine.ending.x = 10;
        myLine.ending.y = 11;

        System.Console.WriteLine("Point 1: ({0},{1})", myLine.starting.x, myLine.starting.y);
        System.Console.WriteLine("Point 2: ({0},{1})", myLine.ending.x, myLine.ending.y);
        System.Console.WriteLine("Length of line Point 1 to Point 2: {0}", myLine.length());
    }
}