using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Border_Control
{
    class StartUp
    {
        static void Main()
        {
            var input = string.Empty;
            List<IIdentifiable> data = new List<IIdentifiable>();
           
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 2)
                {
                    var robotModel = tokens[0];
                    var robotId = tokens[1];

                    data.Add(new Robot(robotModel, robotId));
                }else if (tokens.Length == 3)
                {
                    var citezenName = tokens[0];
                    var citezenAge = int.Parse(tokens[1]);
                    var citezenId = tokens[2];

                    data.Add(new Citezen(citezenName, citezenAge, citezenId));
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            var lastDigit = Console.ReadLine();

            var rebellions = data
                .Where(x => x.Id.EndsWith(lastDigit))
                .Select(x => x.Id);
            Console.WriteLine(string.Join(Environment.NewLine, rebellions));
        }
    }
}
