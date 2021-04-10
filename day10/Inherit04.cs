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

    public virtual void displayFullName()
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

    public Employee(string fn, string ln, ushort hy): base(fn,ln)
    {
        hireYear = hy;
    }

    public override void displayFullName()
    {
        Console.WriteLine("Employee: {0} {1}", firstName, lastName);
    }
}

class Contractor : Person
{
    public string company;

    public Contractor() : base()
    {

    }

    public Contractor(string fn, string ln, string c) : base(fn, ln)
    {
        company = c;
    }

    public override void displayFullName()
    {
        Console.WriteLine("Contractor: {0} {1}", firstName, lastName);
    }
}

class NameApp
{
    public static void Main()
    {
        Person napoleon = new Person("Napoleon", "Bonaparte");
        Person me = new Employee("Napoleon", "Bonaparte", 1804);
        Person worker = new Contractor("Joseph","Bonaparte","King of Naples");

        napoleon.displayFullName();
        me.displayFullName();
        worker.displayFullName();
    }
}