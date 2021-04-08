class Point
{
    public int x;
    public int y;
}

class Line
{
    static public Point origin = new Point();
    public Point ending = new Point();
}

class LineApp
{
    public static void Main()
    {
        Line line1 = new Line();
        Line line2 = new Line();

        Line.origin.x = 1;
        Line.origin.y = 2;

        line1.ending.x = 3;
        line1.ending.y = 4;

        line2.ending.x = 7;
        line2.ending.y = 8;

        System.Console.WriteLine("Line 1 start:     ({0},{1})", Line.origin.x, Line.origin.y);
        System.Console.WriteLine("Line 1 end:       ({0},{1})", line1.ending.x, line1.ending.y);
        System.Console.WriteLine("Line 2 start:     ({0},{1})", Line.origin.x, Line.origin.y);
        System.Console.WriteLine("Line 2 end:       ({0},{1})", line2.ending.x, line2.ending.y);

        Line.origin.x = 939;
        Line.origin.y = 747;

        System.Console.WriteLine("Line 1 start:     ({0},{1})", Line.origin.x, Line.origin.y);
        System.Console.WriteLine("Line 1 end:       ({0},{1})", line1.ending.x, line1.ending.y);
        System.Console.WriteLine("Line 2 start:     ({0},{1})", Line.origin.x, Line.origin.y);
        System.Console.WriteLine("Line 2 end:       ({0},{1})", line2.ending.x, line2.ending.y);
    }
}