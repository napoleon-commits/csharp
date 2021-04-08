class Point
{
    int myX;
    int myY;

    public int x
    {
        get
        {
            return myX;
        }
        set
        {
            myX = value;
        }
    }
    public int y
    {
        get
        {
            return myY;
        }
        set
        {
            myY = value;
        }
    }
}

class PropApp
{
    public static void Main()
    {
        Point starting = new Point();
        Point ending = new Point();

        starting.x = 1;
        starting.y = 4;
        ending.x = 10;
        ending.y = 11;

        System.Console.WriteLine("Point 1: ({0},{1})",starting.x, starting.y);
        System.Console.WriteLine("Point 2: ({0},{1})",ending.x, ending.y);
    }
}