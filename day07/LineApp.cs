struct Point
{
    public int x;
    public int y;
}

struct Line
{
    public Point starting;
    public Point ending;
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
    }
}