using System;
public class Person : IComparable<Person>
{
    private const string ExceptionMessage = "No matches";
    //private string name;
    //private string age;
    //private string town;

    public Person(string name, string age, string town)
    {
        this.Name = name;
        this.Age = age;
        this.Town = town;
    }

    public string Name { get; set; }
    public string Age { get; set; }
    public string Town { get; set; }
    public int CompareTo(Person other)
    {
        var compareName = this.Name.CompareTo(other.Name);
        var compareAge = this.Age.CompareTo(other.Age);
        var compareTown = this.Town.CompareTo(other.Town);
        if (compareName == 0 && compareAge == 0 && compareTown == 0)
        {
            return 0;
        }
        return 1;
    }
}