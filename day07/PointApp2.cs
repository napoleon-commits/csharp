struct Point
{
    public int x;
    public int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class PointApp
{
    public static void Main()
    {
        Point point1 = new Point();
        Point point2 = new Point(8, 8);

        point1.x = 1;
        point2.y = 4;

        System.Console.WriteLine("Point 1: ({0},{1})", point1.x, point1.y);
        System.Console.WriteLine("Point 2: ({0},{1})", point2.x, point2.y);
    }
}