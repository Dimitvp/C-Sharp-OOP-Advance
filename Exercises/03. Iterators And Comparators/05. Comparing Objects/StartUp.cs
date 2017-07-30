using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var people = new List<Person>();

        var input = string.Empty;

        while ((input = Console.ReadLine()) != "END")
        {
            var personInfo = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var personName = personInfo[0];
            var personAge = personInfo[1];
            var personTown = personInfo[2];

            people.Add(new Person(personName, personAge, personTown));
        }
        var personToCompear = int.Parse(Console.ReadLine());
        //people.Remove(personToCompear);
        var equelPeople = 0;
        for (int i = 0; i < people.Count; i++)
        {
            if ( i != personToCompear - 1)
            {
                if (people[i].CompareTo(people[personToCompear - 1]) == 0)
                {
                    equelPeople++;
                }
            }  
        }
        if(equelPeople > 0)
        {
            var notEquelPeople = people.Count - equelPeople - 1;
            Console.WriteLine($"{equelPeople + 1} {notEquelPeople} {people.Count}");
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}