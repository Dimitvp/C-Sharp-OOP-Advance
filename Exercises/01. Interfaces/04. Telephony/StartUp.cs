using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Telephony
{
    class StartUp
    {
        static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            SmartPhone phone = new SmartPhone();

            foreach (string number in phoneNumbers)
            {
                Console.WriteLine(phone.Call(number));
            }

            foreach (string url in urls)
            {
                Console.WriteLine(phone.Browse(url));
            }

        }
    }
}
