using System;

public class Bday
{
    enum Month
    {
        Januray = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12,
    }

    struct Birthday
    {
        public Month bmonth;
        public int bday;
        public int byear;
    }

    public static void Main()
    {
        Birthday myBirthday;

        myBirthday.bmonth = Month.August;
        myBirthday.bday = 15;
        myBirthday.byear = 1769;

        System.Console.WriteLine("My birthday is {0} {1}, {2}", myBirthday.bmonth, myBirthday.bday, myBirthday.byear);
    }
}