using System;

public class StartUp
{
    static void Main()
    {

        //PrintAttribute();
        //CompareCards();
        //PrintCardInfo();
        //PrintEnumSuit();
        //PrintEnumRank();
    }
    public static Card ReadCard()
    {
        var rank = Console.ReadLine();
        var suit = Console.ReadLine();
        Card card = new Card(rank, suit);

        return card;
    }
    //Problem #1
    public static void PrintEnumSuit()
    {
        var input = Console.ReadLine();

        Array cardSuits = Enum.GetValues(typeof(Suit));

        Console.WriteLine("Card Suits:");
        foreach (var suit in cardSuits) // Solution 2# instet of cardSuits -> Enum.GetValues(typeof(CardSuits)
        {
            Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
        }
    }
    //Problem #2
    public static void PrintEnumRank()
    {
        var input = Console.ReadLine();

        Array cardTypes = Enum.GetValues(typeof(Rank));

        Console.WriteLine("Card Ranks:");
        foreach (var type in cardTypes) // Solution 2# instet of cardTypes -> Enum.GetValues(typeof(Type)
        {
            Console.WriteLine($"Ordinal value: {(int)type}; Name value: {type}");
        }
    }
    //Problem #3
    public static void PrintCardInfo()
    {
        Card card = ReadCard();
        Console.WriteLine(card);
    }
    //Problem #5
    public static void CompareCards()
    {
        Card first = ReadCard();
        Card second = ReadCard();

        if (first.CompareTo(second) > 0)
        {
            Console.WriteLine(first);
        }
        else
        {
            Console.WriteLine(second);
        }
    }
    //Problem #6
    public static void PrintAttribute()
    {
        var input = Console.ReadLine();
        if (input == "Rank")
        {
            PrintAttribute(typeof(Rank));
        }
        else
        {
            PrintAttribute(typeof(Suit));
        }
    }

    public static void PrintAttribute(Type type)
    {
        var attribute = type.GetCustomAttributes(false);
        Console.WriteLine(attribute[0]);
    }
}