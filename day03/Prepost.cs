class Prepost
{
    public static void Main()
    {
        int val1 = 0;
        int val2 = 0;

        System.Console.WriteLine("val1          = {0} val2 = {1}", val1, val2);
        System.Console.WriteLine("val1 (Pre)    = {0} val2 = (Post) {1}", ++val1, val2++);
        System.Console.WriteLine("val1 (Pre)    = {0} val2 = (Post) {1}", ++val1, val2++);
        System.Console.WriteLine("val1 (Pre)    = {0} val2 = (Post) {1}", ++val1, val2++);
    }
}