using System;

public class AChar
{
    private char privateCh;

    public AChar() {this.ch = ' '; }
    public AChar(char val) {this.ch = val;}

    public char ch
    {
        get {return this.privateCh; }
        set {this.privateCh = value;}
    }

    static public AChar operator++ (AChar orig)
    {
        AChar result = new AChar();
        result.ch = (char)(orig.ch + 1);
        return result;
    }

    static public AChar operator-- (AChar orig)
    {
        AChar result = new AChar();
        result.ch = (char)(orig.ch - 1);
        return result;
    }
}

public class MyAppClass
{
    public static void Main(String[] args)
    {
        AChar aaa = new AChar('g');
        AChar bbb = new AChar('g');

        Console.WriteLine("Original value: {0}, {1}", aaa.ch, bbb.ch);

        aaa = ++aaa;
        bbb = --bbb;

        Console.WriteLine("Current values: {0}, {1}", aaa.ch, bbb.ch);

        aaa = ++aaa;
        bbb = --bbb;

        Console.WriteLine("Final values: {0}, {1}", aaa.ch, bbb.ch);
    }
}