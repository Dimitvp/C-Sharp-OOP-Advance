using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var inputStones = Console.ReadLine()
            .Split(new [] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var lake = new Lake(inputStones);

        Console.WriteLine(string.Join(", ", lake));
    }
}