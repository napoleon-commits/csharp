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

    static public AChar operator+ (AChar orig, int val)
    {
        AChar result = new AChar();
        result.ch = (char)(orig.ch + val);
        return result;
    }

    static public AChar operator- (AChar orig, int val)
    {
        AChar result = new AChar();
        result.ch = (char)(orig.ch - val);
        return result;
    }
}

public class MyAppClass
{
    public static void Main(string[] args)
    {
        AChar aaa = new AChar('a');
        AChar bbb = new AChar('b');

        Console.WriteLine("Original value: {0}, {1}", aaa.ch, bbb.ch);

        aaa = aaa + 25;
        bbb = bbb - 1;

        Console.WriteLine("Finale values: {0}, {1}", aaa.ch, bbb.ch);
    }
}