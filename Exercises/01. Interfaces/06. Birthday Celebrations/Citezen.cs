public class Citezen : IIdentifiable, IBirthable
{
    private string name;
    private int age;
    private string id;
    private string birthday;

    public Citezen(string name, int age, string id, string birthday)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdata = birthday;
    }
    public string Id { get; }
    public string Name { get; }
    public int Age { get; }
    public string Birthdata { get; }
}
