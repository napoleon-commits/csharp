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

    static public bool operator < (Salary first, Salary second)
    {
        if(first.amount < second.amount) return true;
        else return false;
    }

    static public bool operator <= (Salary first, Salary second)
    {
        if(first.amount <= second.amount) return true;
        else return false;
    }

    static public bool operator > (Salary first, Salary second)
    {
        if(first.amount > second.amount) return true;
        else return false;
    }

    static public bool operator >= (Salary first, Salary second)
    {
        if(first.amount >= second.amount) return true;
        else return false;
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
        Salary mySalary = new Salary(24000);
        Salary yourSalary = new Salary(24000);
        Salary presSalary = new Salary(200000);

        Console.WriteLine("Original values: ");
        Console.WriteLine("           my salary: {0}", mySalary);
        Console.WriteLine("         your salary: {0}", mySalary);
        Console.WriteLine("      a Pres' salary: {0}", mySalary);
        Console.WriteLine("\n------------------------------\n");

        if(mySalary < yourSalary) Console.WriteLine("My salary is less than your salary");
        else if(mySalary > yourSalary) Console.WriteLine("My salary is greater than your salary");
        else Console.WriteLine("Our Salaries are the same");

        if(mySalary >= presSalary) Console.WriteLine("\nI make as much or more than a president.");
        else Console.WriteLine("\nI don't make as much as a president.");
    }
}