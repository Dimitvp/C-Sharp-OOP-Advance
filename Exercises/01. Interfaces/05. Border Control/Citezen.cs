public class Citezen : IIdentifiable
{
    private string name;
    private int age;
    private string id;

    public Citezen(string name, int age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }
    public string Id { get; }
    public string Name { get; }
    public int Age { get; }
}
