using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ferrari
{
    class StartUp
    {
        static void Main()
        {
            var driversName = Console.ReadLine();
            ICar ferrari = new MyFerrari(driversName);
            Console.WriteLine(ferrari.ToString());

            string ferrariName = typeof(MyFerrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }

        }
    }
}