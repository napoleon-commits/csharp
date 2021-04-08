class Score
{
    public static void Main()
    {
        int score = 0;
        int ctr = 0;

        System.Random rnd = new System.Random();

        Start:

        ctr++;

        if (ctr > 10)
            goto EndThis;
        else
            score = (int) rnd.Next(60,101);

        System.Console.WriteLine("{0}  .  You received a score of {1}",ctr,score);

        goto Start;

        EndThis:

        System.Console.WriteLine("Done with scores!");
    }
}