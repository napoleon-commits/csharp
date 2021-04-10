using System;
using System.Text;

class Person
{
    private string firstName;
    private string middleName;
    private string lastName;
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

class NameApp
{
    public static void Main()
    {
        Person me = new Person("Napoleon", "di", "Bonaparte");
        Person myWife = new Person("Marie", "Lucia", "Louise", 41);

        me.displayFullName();
        me.displayAge();
        myWife.displayFullName();
        myWife.displayAge();
    }
}