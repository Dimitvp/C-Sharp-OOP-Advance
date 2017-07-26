using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Generics
{
    class StartUp
    {
        static void Main()
        {
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InstalledUICulture;

            var numOfLines = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < numOfLines; i++)
            {
                var input = double.Parse(Console.ReadLine());
                box.Add(input);
            }
            //var indexes = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            //var firstIndex = int.Parse(indexes[0]);
            //var secondIndex = int.Parse(indexes[1]);
            //box.Swap(firstIndex, secondIndex);
            var elementToCompe = double.Parse(Console.ReadLine());
           
            Console.WriteLine(box.Compar(elementToCompe));
            //Console.WriteLine(box.ToString());
        }
    }
}
