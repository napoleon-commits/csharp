using System;
using System.Text;

public class Salary
{
    private int amt;

    public Salary() {this.amount = 0;}
    public Salary(int val) {this.amount = val;}

    public int amount
    {
        get {return this.amt; }
        set {this.amt = value;}
    }

    public override bool Equals(object obj)
    {
        if((((Salary)obj).amount) == this.amount)
        {
            return true;
        }
        else return false;
    }

    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }

    static public bool operator == (Salary first, Salary second)
    {
        return first.Equals(second);
    }

    static public bool operator != (Salary first, Salary second)
    {
        return !first.Equals(second);
    }

    public override string ToString()
    {
        return this.amount.ToString();
    }
}

public class MyAppClass
{
    public static void Main()
    {
        string tmpString;

        Salary mySalary = new Salary(24000);
        Salary yourSalary = new Salary(24000);
        Salary presSalary = new Salary(200000);

        Console.WriteLine("Original values: {0}, {1}, {2}", mySalary, yourSalary, presSalary);

        if(mySalary == yourSalary) tmpString = "equals";
        else tmpString = "does not equal";

        Console.WriteLine("\nMy salary {0} your salary", tmpString);

        if(mySalary == presSalary) tmpString = "equals";
        else tmpString = "does not equal";

        Console.WriteLine("\nMy salary {0} a president\'s salary", tmpString);
    }
}