using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Threeuple
{
    class StartUp
    {
        static void Main()
        {
            var firstLine = Console.ReadLine().Split();
            var name = $"{firstLine[0]} {firstLine[1]}";
            var adress = firstLine[2];
            var town = firstLine[3];
            var firstTuple = new Threeuple<string, string, string>(name, adress, town);
            Console.WriteLine(firstTuple);

            var secondLine = Console.ReadLine().Split();
            name = secondLine[0];
            var litersOfBeer = int.Parse(secondLine[1]);
            bool drunkOrNot;
            drunkOrNot = secondLine[2] == "drunk";
            var secondTuple = new Threeuple<string, int, bool>(name, litersOfBeer, drunkOrNot);
            Console.WriteLine(secondTuple);

            var thirdLine = Console.ReadLine().Split();
            name = thirdLine[0];
            var accountBalance = double.Parse(thirdLine[1]);
            var bankName = thirdLine[2];
            var thirdTuple = new Threeuple<string, double, string>(name, accountBalance, bankName);
            Console.WriteLine(thirdTuple);
        }
    }
}
