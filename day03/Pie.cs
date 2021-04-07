class Pie
{
    public static void Main()
    {
        int piecesForMe = 0;
        int piecesOfPie = 0;

        piecesOfPie = 3 * 6;
        piecesForMe = piecesOfPie % 13;

        System.Console.WriteLine("Pieces of Pie = {0}", piecesOfPie);
        System.Console.WriteLine("Pieces for Me = {0}", piecesForMe);
    }
}