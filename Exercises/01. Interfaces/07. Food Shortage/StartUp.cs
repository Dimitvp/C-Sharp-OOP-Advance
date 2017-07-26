using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Border_Control
{
    class StartUp
    {
        static void Main()
        {
            var numLines = int.Parse(Console.ReadLine());
            var input = string.Empty;
            //List<IBirthable> data = new List<IBirthable>();
            //List<IIdentifiable> robots = new List<IIdentifiable>();
            
            var buyers = new Dictionary<string, IBuyer>();

            for (int i = 0; i < numLines; i++)
            {
                var tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 4)
                {
                    var citezenName = tokens[0];
                    var citezenAge = int.Parse(tokens[1]);
                    var citezenId = tokens[2];
                    var citezenBDay = tokens[3];

                    Citezen citezen = new Citezen(citezenName, citezenAge, citezenId, citezenBDay);
                    buyers[citezenName] = citezen;
                }else if (tokens.Length == 3)
                {
                    var rebelName = tokens[0];
                    var rebelAge = int.Parse(tokens[1]);
                    var rebelGroup = tokens[2];
                    Rebel rebel = new Rebel(rebelName, rebelAge, rebelGroup);
                    buyers[rebelName] = rebel;
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                var name = input;
                if (buyers.ContainsKey(name))
                {
                    buyers[name].BuyFood();
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(buyers.Values.Sum(b => b.Food));
        }
    }
}
