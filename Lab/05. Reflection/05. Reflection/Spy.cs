using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string className, params string[] fildsNames)
    {
        Type classType = Type.GetType(className);
        FieldInfo[] classField = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
        var sb = new StringBuilder();

        Object classInstance = Activator.CreateInstance(classType, new object[] {});

        sb.AppendLine($"Class under investigation: {className}");

        foreach (FieldInfo field in classField.Where(f => fildsNames.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().Trim();
    }
}