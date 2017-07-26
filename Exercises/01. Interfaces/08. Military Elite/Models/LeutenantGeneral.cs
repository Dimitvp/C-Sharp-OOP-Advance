using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral: Private, ILeutenantGeneral
{
    public LeutenantGeneral(string id, string firstName, string lastName, decimal salary, IList<ISoldier> soldiers) 
        : base(id, firstName, lastName, salary)
    {
        Soldiers = soldiers;
    }

    public IList<ISoldier> Soldiers { get; private set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{base.ToString()}");
        sb.AppendLine($"Privates:");
        foreach (var soldier in this.Soldiers)
        {
            sb.AppendLine($" {soldier.ToString()}");
        }
        return sb.ToString().Trim();
    }
}