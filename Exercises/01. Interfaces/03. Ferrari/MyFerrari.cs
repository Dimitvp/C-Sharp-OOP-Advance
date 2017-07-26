using System.Text;

public class MyFerrari : ICar
{
    private string model;
    private string driver;

    public MyFerrari(string driver)
    {
        this.Driver = driver;
    }

    public string Model { get; }
    public string Driver { get; }
    public string Start()
    {
        return "Zadu6avam sA!";
    }

    public string Stop()
    {
        return "Brakes!";
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"488-Spider/{Stop()}/{Start()}/{this.Driver}");
        return sb.ToString();
    }
}
//488-Spider/Brakes!/Zadu6avam sA!/Bat Giorgi