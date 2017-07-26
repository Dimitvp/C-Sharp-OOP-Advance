public class Citizen : IPerson, IBirthable, IIdentifiable
{
    private string name;
    private int age;
    private string id;
    private string birthdata;

    public Citizen(string name, int age, string id, string birthdata)
    {
        this.Name = name;
        this.Age = age;
        this.Birthdata = birthdata;
        this.Id = id;
    }

    public string Name { get; }
    public int Age { get; }
    public string Birthdata { get; }
    public string Id { get; }
}