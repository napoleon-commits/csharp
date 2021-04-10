using System;

public class Lines
{
    #line 100

    public static void Main(String[] args)
    {
        #warning In Main...
        Console.WriteLine("In Main....");
        myMethod1();
        myMethod2();
        #warning DOne with main
        Console.WriteLine("Done with Main");
    }

    #line 200

    static void myMethod1()
    {
        Console.WriteLine("In Method 1");
        #warning In Method 1...
        int x;
    }

    #line 300

    static void myMethod2()
    {
        Console.WriteLine("in Method 2");
        #warning In Method 2...
        int y;
    }
}