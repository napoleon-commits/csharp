using System;

class Person
{
    protected string name;

    public Person(){}

    public Person(string n) {name = n;}

    public virtual void displayFullName()
    {
        Console.WriteLine("Name: {0}", name);
    }
}

class Employee : Person
{
    public Employee() : base () {}
    public Employee(string n) : base(n) {}
    public override void displayFullName()
    {
        Console.WriteLine("Employee: {0}", name);
    }
}

class IsApp
{
    public static void Main()
    {
        Person pers = new Person();
        Object emp = new Employee();
        string str = "String";

        if(pers is Person) Console.WriteLine("pers is a Person");
        else Console.WriteLine("pers is NOT a Person");

        if(pers is Object) Console.WriteLine("pers is an Object");
        else Console.WriteLine("pers is Not an Object");

        if(pers is Employee) Console.WriteLine("pers is an Employee");
        else Console.WriteLine("pers is NOT an Employee");

        if(emp is Person) Console.WriteLine("emp is a Person");
        else Console.WriteLine("emp is NOT a Person");

        if(str is Person) Console.WriteLine("str is a Person");
        else Console.WriteLine("str is NOT a Person");
    }
}