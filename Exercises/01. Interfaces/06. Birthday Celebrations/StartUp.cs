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
            List<IBirthable> data = new List<IBirthable>();
            List<IIdentifiable> robots = new List<IIdentifiable>();

            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Robot")
                {
                    var robotModel = tokens[1];
                    var robotId = tokens[2];

                    robots.Add(new Robot(robotModel, robotId));
                }else if (tokens[0] == "Citizen")
                {
                    var citezenName = tokens[1];
                    var citezenAge = int.Parse(tokens[2]);
                    var citezenId = tokens[3];
                    var citezenBDay = tokens[4];

                    data.Add(new Citezen(citezenName, citezenAge, citezenId, citezenBDay));
                }
                else if (tokens[0] == "Pet")
                {
                    var petsName = tokens[1];
                    var petsBirthday = tokens[2];

                    data.Add(new Pet(petsName, petsBirthday));
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            var lastDigit = Console.ReadLine();

            var birthdata = data
                .Where(x => x.Birthdata.EndsWith(lastDigit))
                .Select(x => x.Birthdata);
            Console.WriteLine(string.Join(Environment.NewLine, birthdata));
        }
    }
}
