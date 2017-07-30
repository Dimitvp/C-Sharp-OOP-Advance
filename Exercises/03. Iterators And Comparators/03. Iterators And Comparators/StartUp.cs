using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Iterators_And_Comparators
{
    class StartUp
    {
        static void Main()
        {
            var createCmt = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var data = new ListyIterator<string>(createCmt.Skip(1).ToArray());

            var commands = string.Empty;
            while ((commands = Console.ReadLine()) != "END")
            {
                try
                {
                    switch (commands)
                    {
                        case "Move":
                            Console.WriteLine(data.Move());
                            break;
                        case "HasNext":
                            Console.WriteLine(data.HasNext());
                            break;
                        case "Print":
                            data.Print();
                            break;
                        case "PrintAll":
                            data.PrintAll();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
