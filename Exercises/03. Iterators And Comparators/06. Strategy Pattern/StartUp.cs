using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        SortedSet<Person> nameSorter = new SortedSet<Person>(new NameComparator());
        SortedSet<Person> ageSorter = new SortedSet<Person>(new AgeComparator());

        var numOfLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numOfLines; i++)
        {
            var data = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var name = data[0];
            var age = int.Parse(data[1]);
            Person person = new Person(name, age);
            nameSorter.Add(person);
            ageSorter.Add(person);
        }

        foreach (var person in nameSorter)
        {
            Console.WriteLine(person);
        }

        foreach (var person in ageSorter)
        {
            Console.WriteLine(person);
        }
    }
}