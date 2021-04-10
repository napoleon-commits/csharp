using System;

class Person
{
    protected string firstName;
    protected string lastName;

    public Person()
    {

    }

    public Person(string fn, string ln)
    {
        firstName = fn;
        lastName = ln;
    }

    public void displayFullName()
    {
        Console.WriteLine("{0} {1}", firstName, lastName);
    }
}

class Employee : Person
{
    public ushort hireYear;

    public Employee() : base()
    {

    }

    public Employee(string fn, string ln): base(fn, ln)
    {

    }

    public Employee(string fn, string ln, ushort hy): base(fn, ln)
    {
        hireYear = hy;
    }

    public new void displayFullName()
    {
        Console.WriteLine("Employee: {0} {1}", firstName, lastName);
    }
}

class NameApp
{
    public static void Main()
    {
        Employee me = new Employee("Napoleon", "Bonaparte", 1804);

        Person napoleon = me;

        me.displayFullName();
        Console.WriteLine("Year hired: {0}", me.hireYear);

        napoleon.displayFullName();
    }
}