using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Custom_List
{
    class StartUp
    {
        static void Main()
        {
            var interpretator = new CommandInterpretator();

            var input = Console.ReadLine();
            while (input != "END")
            {
                interpretator.ParseCommand(input);
                input = Console.ReadLine();
            }
        }
    }
}
