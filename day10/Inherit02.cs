using System;
using System.Text;

class Person
{
    protected string firstName;
    protected string middleName;
    protected string lastName;
    private int age;

    public Person()
    {

    }

    public Person(string fn, string ln)
    {
        firstName = fn;
        lastName = ln;
    }

    public Person(string fn, string mn, string ln)
    {
        firstName = fn;
        middleName = mn;
        lastName = ln;
    }

    public Person(string fn, string mn, string ln, int a)
    {
        firstName = fn;
        middleName = mn;
        lastName = ln;
        age = a;
    }

    public void displayAge()
    {
        Console.WriteLine("Age {0}", age);
    }

    public void displayFullName()
    {
        StringBuilder fullName = new StringBuilder();

        fullName.Append(firstName);
        fullName.Append(" ");
        if(middleName != "")
        {
            fullName.Append(middleName[0]);
            fullName.Append(". ");
        }
        fullName.Append(lastName);

        Console.WriteLine(fullName);
    }
}

class Employee : Person
{
    private ushort hYear;

    public ushort hireYear
    {
        get{return (hYear);}
        set {hYear = value;}
    }

    public Employee() : base()
    {

    }

    public Employee(string fn, string ln) : base (fn, ln)
    {

    }

    public Employee(string fn, string mn, string ln, int a) : base(fn, mn, ln, a)
    {

    }

    public Employee(string fn, string ln, ushort hy) : base(fn, ln)
    {
        hireYear = hy;
    }

    public new void displayFullName()
    {
        Console.WriteLine("Employee: {0} {1} {2}", firstName, middleName, lastName);
    }
}

class NameApp
{
    public static void Main()
    {
        
        Person myWife = new Person("Marie", "Lucia", "Louise", 41);
        Employee me = new Employee("Napoleon", "di", "Bonaparte", 35);
        Employee you = new Employee("Satoshi", "Nakamoto", 2009);

        myWife.displayFullName();
        myWife.displayAge();

        me.displayFullName();
        Console.WriteLine("Year hired: {0}", me.hireYear);
        me.displayAge();

        you.displayFullName();
        Console.WriteLine("Year hired of him: {0}", you.hireYear);
        you.displayAge();
    }
}