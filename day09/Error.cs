using System;

class Error
{
    public static void Main()
    {
        int[] myArray = new int[5];

        for(int ctr = 0; ctr < 10; ctr +=1 )
        {
            myArray[ctr] = ctr;
        }
    }
}