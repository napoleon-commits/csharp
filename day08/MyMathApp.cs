using System;

public class MyMath
{
    public static long Add(params int[] args)
    {
        int ctr = 0;
        long answer = 0;

        for(ctr = 0; ctr < args.Length; ctr += 1)
        {
            answer += args[ctr];
        }
        return answer;
    }

    public static long Subtract(int arg1, int arg2)
    {
        return arg1 - arg2;
    }

    class MyMathApp
    {
        public static void Main()
        {
            long result = 0;
            result = MyMath.Add(1,2,3);
            Console.WriteLine("Add result is {0}", result);

            result = MyMath.Subtract(5,2);
            Console.WriteLine("Subtract result is {0}", result);
        }
    }
}