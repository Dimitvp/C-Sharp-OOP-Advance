using System;

public class StartUp
{
    static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();

        var numLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numLines; i++)
        {
            var inputTokens = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var command = inputTokens[0];
            var number = int.Parse(inputTokens[1]);

            switch (command)
            {
                case "Add":
                    list.Add(number);
                    break;
                case "Remove":
                    list.Remove(number);
                    break;
            }
        }
        PrinntResult(list);
    }
    private static void PrinntResult(LinkedList<int> linkedList)
    {
        Console.WriteLine(linkedList.Count);
        Console.WriteLine(string.Join(" ", linkedList));
    }
}