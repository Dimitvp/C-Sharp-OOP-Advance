using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier ,IEngineer
{
    public Engineer(string id, string firstName, string lastName, decimal salary, string corps, IList<IRepair> repairs ) : base(id, firstName, lastName, salary, corps)
    {
        Repairs = repairs;
    }

    public IList<IRepair> Repairs { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Repairs:");
        for (int i = 0; i < this.Repairs.Count; i++)
        {
            sb.AppendLine($"  {this.Repairs[i].ToString()}");
        }

        return sb.ToString().Trim();
    }
}