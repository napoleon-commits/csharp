using System;

namespace Consts
{
    public class PI
    {
        public static double value = 3.14159;
        private PI(){}
    }

    public class Three
    {
        public static int value = 3;
        private Three() {}
    }
}

namespace MyMath
{
    public class Routine
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
    }
}

class MyMathApp
{
    public static void Main()
    {
        Console.WriteLine("Add result is {0}", MyMath.Routine.Add(1,2,3));

        Console.WriteLine("Add result is {0}", MyMath.Routine.Subtract(5,2));

        Console.WriteLine("\nThe value of PI is {0}", Consts.PI.value);
        Console.WriteLine("The value of three is {0}", Consts.Three.value);
    }
}