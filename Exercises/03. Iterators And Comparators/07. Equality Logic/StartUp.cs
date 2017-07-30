using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        SortedSet<Person> sortedPeople = new SortedSet<Person>();
        HashSet<Person> hashedPeople = new HashSet<Person>();

        var numOfLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numOfLines; i++)
        {
            var data = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var name = data[0];
            var age = int.Parse(data[1]);
            Person person = new Person(name, age);
            sortedPeople.Add(person);
            hashedPeople.Add(person);
        }
        Console.WriteLine($"{sortedPeople.Count}{Environment.NewLine}{hashedPeople.Count}");
    }
}