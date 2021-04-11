using System;

public class AChar
{
    private char privateCh;

    public AChar() {this.ch = ' '; }
    public AChar(char val) {this.ch = val;}

    public char ch
    {
        get{ return this.privateCh; }
        set{this.privateCh = value; }
    }
}

public class MyAppClass
{
    public static void Main(String[] args)
    {
        AChar aaa = new AChar('a');
        AChar bbb = new AChar('b');

        Console.WriteLine("Original value: {0}, {1}", aaa.ch, bbb.ch);

        aaa.ch = (char) (aaa.ch + 3);
        bbb.ch = (char) (bbb.ch - 1);

        Console.WriteLine("Final values: {0}, {1}", aaa.ch, bbb.ch);
    }
}