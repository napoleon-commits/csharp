using System;

public class SortClass
{
    static public int val1;
    static public int val2;

    public delegate void Sort(ref int a, ref int b);

    public void DoSort(Sort ar)
    {
        ar(ref val1, ref val2);
    }
}

public class SortProgram
{
    public static void ascending(ref int first, ref int second)
    {
        if(first > second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }
    }

    public static void descending(ref int first, ref int second)
    {
        if(first < second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }
    }

    public static void Main()
    {
        SortClass.Sort up = new SortClass.Sort(ascending);
        SortClass.Sort down = new SortClass.Sort(descending);

        SortClass doIT = new SortClass();

        SortClass.val1 = 310;
        SortClass.val2 = 220;

        Console.WriteLine("Before Sort: val1 = {0}, val2 = {1}", SortClass.val1, SortClass.val2);

        doIT.DoSort(up);
        Console.WriteLine("After Sort: val1 = {0}, val2 = {1}", SortClass.val1, SortClass.val2);

        Console.WriteLine("Before Sort: val1 = {0}, val2 = {1}", SortClass.val1, SortClass.val2);

        doIT.DoSort(down);
        Console.WriteLine("After Sort: val1 = {0}, val2 = {1}", SortClass.val1, SortClass.val2);
    }
}