using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{
    public Commando(string id, string firstName, string lastName, decimal salary, string corps, IList<IMission> missions) : base(id, firstName, lastName, salary, corps)
    {
        Missions = missions;
    }

    public IList<IMission> Missions { get; }
    public void CompleteMission()
    {
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Missions:");

        foreach (var mission in Missions)
        {
            sb.AppendLine($" {mission}");
        }

        return sb.ToString().Trim();
    }
}