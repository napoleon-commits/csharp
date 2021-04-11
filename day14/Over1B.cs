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

    static public AChar add(AChar orig, int val)
    {
        AChar result = new AChar();
        result.ch = (char)(orig.ch + val);
        return result;
    }

    static public AChar Subtract(AChar orig, int val)
    {
        AChar result = new AChar();
        result.ch = (char)(orig.ch - val);
        return result;
    }
}

public class MyAppClass
{
    public static void Main(String[] args)
    {
        AChar aaa = new AChar('a');
        AChar bbb = new AChar('b');

        Console.WriteLine("Original value: {0}, {1}", aaa.ch, bbb.ch);

        aaa = AChar.add(aaa, 3);
        bbb = AChar.Subtract(bbb, 1);

        Console.WriteLine("Final values: {0}, {1}", aaa.ch, bbb.ch);
    }
}