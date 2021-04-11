using System;

public class SpellingList
{
    protected string[] words = new string[size];
    static public int size = 10;

    public SpellingList()
    {
        for(int x = 0; x < size; x += 1)
        {
            words[x] = String.Format("Word{0}", x);
        }
    }

    public string this[int index]
    {
        get
        {
            string tmp;

            if(index >= 0 && index <= size-1)
            {
                tmp = words[index];
            }
            else
            {
                tmp = "";
            }
            return tmp;
        }
        set
        {
            if(index >= 0 && index <= size-1)
            {
                words[index] = value;
            }
        }
    }
}

public class Indexer
{
    public static void Main()
    {
        SpellingList myList = new SpellingList();

        myList[3] = "=====";
        myList[4] = "Napoleon";
        myList[5] = "was";
        myList[6] = "here!";
        myList[7] = "=====";


        for(int x = 0; x < SpellingList.size; x += 1)
        {
            Console.WriteLine(myList[x]);
        }
    }
}