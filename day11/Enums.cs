using System;

class Enums
{
    enum Pet
    {
        Cat, Dog, Fish, Snake, Rat, Hamster, Bird,
    }

    public static void Main()
    {
        Pet myPet = Pet.Fish;
        Pet yourPet = Pet.Hamster;

        Console.WriteLine("Using myPet: ");
        Console.WriteLine("d: {0:d}", myPet);
        Console.WriteLine("D: {0:D}", myPet);
        Console.WriteLine("g: {0:g}", myPet);
        Console.WriteLine("G: {0:G}", myPet);
        Console.WriteLine("x: {0:x}", myPet);
        Console.WriteLine("X: {0:X}", myPet);

        Console.WriteLine("\nUsing yourPet: ");
        Console.WriteLine("d: {0:d}", yourPet);
        Console.WriteLine("D: {0:D}", yourPet);
        Console.WriteLine("g: {0:g}", yourPet);
        Console.WriteLine("G: {0:G}", yourPet);
        Console.WriteLine("x: {0:x}", yourPet);
        Console.WriteLine("X: {0:X}", yourPet);

    }
}