using System;

public class Person
{
    public string name;
    public Person(){}
    public Person(string nm)
    {
        name = nm;
    }
    public virtual void displayFullName()
    {
        Console.WriteLine("Person: {0}", name);
    }
}

class Employee : Person
{
    public Employee() : base() {}
    public Employee(string nm) : base(nm) {}

    public override void displayFullName()
    {
        Console.WriteLine("Employee: {0}", name);
    }
}

class Contractor : Person
{
    public Contractor() : base() {}
    public Contractor(string nm) : base(nm) {}

    public override void displayFullName()
    {
        Console.WriteLine("Contractor: {0}", name);
    }
}

class NameApp
{
    public static void Main()
    {
        Person[] myCompany = new Person[5];
        int ctr = 0;
        string buffer;
        
        do
        {
            do
            {
                Console.WriteLine("\nEnter \'c\' for Contractor, \'e\' for Employee then press ENTER: ");
                buffer = Console.ReadLine();
            } while (buffer == "");

            if(buffer[0] == 'c' || buffer[0] == 'C')
            {
                Console.Write("\nEnter the contractor\'s name: ");
                buffer = Console.ReadLine();
                Contractor contr = new Contractor(buffer);
                myCompany[ctr] = contr as Person;
            }
            else if (buffer[0] == 'e' || buffer[1] == 'E')
            {
                Console.Write("\nEnter the employee\'s name: ");
                buffer = Console.ReadLine();
                Employee emp = new Employee(buffer);
                myCompany[ctr] = emp as Person;
            }
            else
            {
                Person pers = new Person("Not an Employee or Contractor");
                myCompany[ctr] = pers;
            }

            ctr += 1;
        } while (ctr < 5);

        Console.WriteLine("\n\n\n======================================");

        for(ctr = 0; ctr < 5; ctr += 1)
        {
            if(myCompany[ctr] is Employee)
            {
                Console.WriteLine("Employee: {0}", myCompany[ctr].name);
            }
            else if (myCompany[ctr] is Contractor)
            {
                Console.WriteLine("Contractor: {0}", myCompany[ctr].name);
            }
            else
            {
                Console.WriteLine("Person: {0}", myCompany[ctr].name);
            }
        }
        Console.WriteLine("===========================================");
    }
}