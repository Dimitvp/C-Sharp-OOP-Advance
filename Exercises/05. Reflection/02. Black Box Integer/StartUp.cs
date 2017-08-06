using System;
using System.Linq;
using System.Reflection;

public class StartUp
{
    private const BindingFlags NonPublicFlags = BindingFlags.Instance | BindingFlags.NonPublic;
    static void Main()
    {
        Type blackBoxType = typeof(BlackBoxInt);
        BlackBoxInt myBlackBox = (BlackBoxInt) Activator.CreateInstance(blackBoxType, true);
          
        Reflector reflect = new Reflector();
        var commands = string.Empty;

        while ((commands = Console.ReadLine()) != "END")
        {
            var commandsTokens = commands.Split(new[] {'_'}, StringSplitOptions.RemoveEmptyEntries);
            var methodName = commandsTokens[0];
            var value = int.Parse(commandsTokens[1]);

            blackBoxType.GetMethod(methodName, NonPublicFlags)
                .Invoke(myBlackBox, new object[] {value});

            object innerStateValue = blackBoxType
                .GetFields(NonPublicFlags)
                .First()
                .GetValue(myBlackBox);
            Console.WriteLine(innerStateValue);
        }
    }
}