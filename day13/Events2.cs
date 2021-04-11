using System;

delegate void CharEventHandler(object source, CharEventArgs e);

public class CharEventArgs : EventArgs
{
    public char currChar;
    public CharEventArgs(char currChar)
    {
        this.currChar = currChar;
    }
}

class CharChecker
{
    char currChar;
    public event CharEventHandler testChar;
    public char CurrChar
    {
        get { return currChar; }
        set
        {
            if(testChar != null)
            {
                CharEventArgs args = new CharEventArgs(value);
                testChar(this, args);
                currChar = args.currChar;
            }
        }
    }
}

class Events
{
    public static void Main()
    {
        CharChecker tester = new CharChecker();

        tester.testChar += new CharEventHandler(dropA);
        tester.testChar += new CharEventHandler(changeO);

        tester.CurrChar = 'N';
        Console.WriteLine("{0}", tester.CurrChar);

        tester.CurrChar = 'a';
        Console.WriteLine("{0}", tester.CurrChar);

        tester.CurrChar = 'p';
        Console.WriteLine("{0}", tester.CurrChar);

        tester.CurrChar = 'o';
        Console.WriteLine("{0}", tester.CurrChar);

        tester.CurrChar = 'l';
        Console.WriteLine("{0}", tester.CurrChar);

        tester.CurrChar = 'e';
        Console.WriteLine("{0}", tester.CurrChar);

        tester.CurrChar = 'o';
        Console.WriteLine("{0}", tester.CurrChar);

        tester.CurrChar = 'n';
        Console.WriteLine("{0}", tester.CurrChar);
    }

    static void dropA(object source, CharEventArgs e)
    {
        if(e.currChar == 'a' || e.currChar == 'A')
        {
            Console.WriteLine("Don't like 'a'!");
            e.currChar = 'X';
        }
    }

    static void changeO(object source, CharEventArgs e)
    {
        if(e.currChar == 'o' || e.currChar == 'O')
        {
            Console.WriteLine("O's are good!");
            e.currChar = 'Z';
        }
    }
}