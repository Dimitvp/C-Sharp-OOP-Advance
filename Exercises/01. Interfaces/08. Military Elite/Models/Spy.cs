using System.Text;

public class Spy : Soldier, ISpy
{
    public Spy(string id, string firstName, string lastName, int codeNum) 
        : base(id, firstName, lastName)
    {
        CodeNum = codeNum;
    }
    
    public int CodeNum { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
        sb.AppendLine($"Code Number: {this.CodeNum}");
        return sb.ToString().Trim();
    }
}