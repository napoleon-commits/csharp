using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var date1 = new System.DateTime(2021, 1, 1);
            var date2 = new System.DateTime(2022, 1, 1);
            var date3 = new System.DateTime(2021, 6, 17);
            Console.WriteLine("{0}", date1);
            Console.WriteLine("{0}", date2);
            Console.WriteLine("{0}", (date1 > date2));
            Console.WriteLine("{0}", (date1 < date2));
            Console.WriteLine("Is current date between year 2021 and 2022? {0}", (date1 < date3 && date3 < date2));
        }
    }
}
