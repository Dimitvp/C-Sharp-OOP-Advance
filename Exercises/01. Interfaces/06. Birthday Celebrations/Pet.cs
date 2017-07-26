public class Pet : IBirthable
{
    private string name;
    private string birthdata;

    public Pet(string name, string birthdata)
    {
        this.name = name;
        this.Birthdata = birthdata;
    }
    public string Birthdata { get; }
}