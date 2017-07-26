public class Rebel : IBuyer
{
    //names are unique 
    private string name;
    private int age;
    private string group;
    private int food;//food +5

    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
        this.Food = 0;
    }

    public string Name { get; }
    public int Age { get; }
    public string Group { get;}
    public int Food { get; protected set; }
    public void BuyFood()//food +5
    {
        this.Food = this.Food + 5;
    }
}
