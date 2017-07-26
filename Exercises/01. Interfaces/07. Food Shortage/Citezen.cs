public class Citezen : IIdentifiable, IBirthable, IBuyer
{
    private string name;
    private int age;
    private string id;
    private string birthday;
    private int food;//food +10

    public Citezen(string name, int age, string id, string birthday)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdata = birthday;
        this.Food = 0;
    }
    public string Id { get; }
    public string Name { get; }
    public int Age { get; }
    public string Birthdata { get; }
    public int Food { get; protected set; }
    public void BuyFood()//food +10
    {
        this.Food = this.Food + 10;
    }
}
