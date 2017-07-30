using System;

public class StartUp
{
    static void Main()
    {
        Stack<int> myStack = new Stack<int>();
        var commands = string.Empty;

        while ((commands = Console.ReadLine()) != "END")
        {
            var tokens = commands.Split(new [] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            switch (tokens[0])
            {
                case "Push":
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        myStack.Push(i);
                    }
                    break;
                case "Pop":
                    try
                    {
                        myStack.Pop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
        }
        for (int i = 0; i < 2; i++)
        {
            foreach (var elemnt in myStack)
            {
                Console.WriteLine(elemnt);
            }
        }
    }
}
