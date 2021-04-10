using System;

class CheckIt
{
    public static void Main()
    {
        int result;
        const int topval = 2147483647;

        for(long ctr = topval - 5L; ctr < (topval + 10L); ctr += 1)
        {
            // checked
            unchecked
            {
                result = (int) ctr;
                Console.WriteLine("{0} assigned from {1}", result, ctr);
            }
        }
    }
}