using System;
using System.Text;

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

    static public AChar operator+ (AChar orig)
    {
        AChar result = new AChar();
        if(orig.ch >= 'a' && orig.ch <= 'z') result.ch = (char) (orig.ch - 32);
        else result.ch = orig.ch;

        return result;
    }

    static public AChar operator- (AChar orig)
    {
        AChar result = new AChar();
        if(orig.ch >= 'A' && orig.ch <= 'Z') result.ch = (char) (orig.ch + 32);
        else result.ch = orig.ch;

        return result;
    }
}

public class MyAppClass
{
    public static void Main(String[] args)
    {
        AChar aaa = new AChar('g');
        AChar bbb = new AChar('g');
        AChar ccc = new AChar('G');
        AChar ddd = new AChar('G');

        Console.WriteLine("ORIGINAL:");
        Console.WriteLine("aaa value: {0}", aaa.ch);
        Console.WriteLine("bbb value: {0}", bbb.ch);
        Console.WriteLine("ccc value: {0}", ccc.ch);
        Console.WriteLine("ddd value: {0}", ddd.ch);

        aaa = +aaa;
        bbb = -bbb;
        ccc = +ccc;
        ddd = -ddd;

        Console.WriteLine("\n\nFINAL:");
        Console.WriteLine("aaa value: {0}", aaa.ch);
        Console.WriteLine("bbb value: {0}", bbb.ch);
        Console.WriteLine("ccc value: {0}", ccc.ch);
        Console.WriteLine("ddd value: {0}", ddd.ch);
    }
}