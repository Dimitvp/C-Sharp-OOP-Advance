using System;
using System.Collections.Generic;

public class StartUp
{
    private static Card biggest;
    private static string winner;
    static void Main()
    {
        //Game();
        //PrintDeck();
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
    //Problem #7
    public static void PrintDeck()
    {
        var input = Console.ReadLine();
        var deck = GenerateDeck();
        foreach (var card in deck)
        {
            Console.WriteLine(card.Name);
        }
        //Array cardRank = Enum.GetValues(typeof(Rank));
        //Array cardSuits = Enum.GetValues(typeof(Suit));

        //foreach (var suit in cardSuits)
        //{
        //    foreach (var rank in cardRank)
        //    {
        //        Console.WriteLine($"{rank} of {suit}");
        //    }
        //}
    }

    public static List<Card> GenerateDeck()
    {
        List<Card> deck = new List<Card>();

        foreach (var suit in Enum.GetNames(typeof(Suit)))
        {
            foreach (var rank in Enum.GetNames(typeof(Rank)))
            {
                deck.Add(new Card(rank, suit));
            }
        }
        return deck;
    }
    //Problem #8
    public static void Game()
    {
        var firstPlayer = Console.ReadLine();
        var secondPlayer = Console.ReadLine();

        List<Card> deck = GenerateDeck();
        List<Card> firstDeck = new List<Card>();
        List<Card> secondDeck = new List<Card>();

        while (firstDeck.Count < 5 || secondDeck.Count < 5 )
        {
            var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var card = new Card(input[0], input[input.Length - 1]);
                if (deck.Contains(card))
                {
                    deck.Remove(card);
                    if (firstDeck.Count < 5)
                    {
                        firstDeck.Add(card);
                        WinnerCheck(card, firstPlayer);
                    }
                    else
                    {
                        secondDeck.Add(card);
                        WinnerCheck(card, secondPlayer);
                    }
                }
                else
                {
                    Console.WriteLine("Card is not in the deck.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No such card exists.");

            }
        }
        Console.WriteLine($"{winner} wins with {biggest.Name}.");
    }

    public static void WinnerCheck(Card card, string player)
    {
        if (card.CompareTo(biggest) > 0)
        {
            biggest = card;
            winner = player;
        }   
    }
}