using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Reflector
{
    //private Type classType = Type.GetType("RichSoilLand");
    //private FieldInfo[] classField = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
    public string TakeProtectedFields()
    {
         Type classType = Type.GetType("RichSoilLand");
         FieldInfo[] classField = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        var sb = new StringBuilder();

        foreach (FieldInfo field in classField.Where(f => f.IsFamily))
        {
            sb.AppendLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}").Replace("family", "protected");
        }

        return sb.ToString().Trim();
    }

    public string TakePrivateFields()
    {
        Type classType = Type.GetType("RichSoilLand");
        FieldInfo[] classField = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        var sb = new StringBuilder();

        foreach (FieldInfo field in classField.Where(f => f.IsPrivate))
        {
            sb.AppendLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
        }

        return sb.ToString().Trim();
    }

    public string TakePublicFields()
    {
        Type classType = Type.GetType("RichSoilLand");
        FieldInfo[] classField = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        var sb = new StringBuilder();

        foreach (FieldInfo field in classField.Where(f => f.IsPublic))
        {
            sb.AppendLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
        }

        return sb.ToString().Trim();
    }

    public string TakeAllFields()
    {
        Type classType = Type.GetType("RichSoilLand");
        FieldInfo[] classField = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        var sb = new StringBuilder();

        foreach (FieldInfo field in classField)
        {
            sb.AppendLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}").Replace("family", "protected");
        }

        return sb.ToString().Trim();
    }
}