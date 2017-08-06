using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class StartUp
{
    static void Main()
    {
        //No Switch Version
        Type harvestingFieldsType = typeof(RichSoilLand);
        FieldInfo[] harvestingFields = harvestingFieldsType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        Dictionary<string, Func<FieldInfo[]>> accModFilters = new Dictionary<string, Func<FieldInfo[]>>()
        {
            {"private", () => harvestingFields.Where(f => f.IsPrivate).ToArray()},
            {"protected", () => harvestingFields.Where(f => f.IsFamily).ToArray()},
            {"public" , () => harvestingFields.Where(f => f.IsPublic).ToArray()},
            {"all", () => harvestingFields}
        };

        FieldInfo[] gatherdFields;
        string requestedAccMod;
        while ((requestedAccMod = Console.ReadLine()) != "HARVEST")
        {
            accModFilters[requestedAccMod]()
                .Select(f =>
                    $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}")
                .ToList()
                .ForEach(r => Console.WriteLine(r.Replace("family", "protected")));
        }

        //My Version
        //Reflector reflector = new Reflector();

        //var command = string.Empty;
        //while ((command = Console.ReadLine()) != "HARVEST")
        //{
        //    switch (command)
        //    {
        //        case "protected":
        //            Console.WriteLine(reflector.TakeProtectedFields());
        //            break;
        //        case "private":
        //            Console.WriteLine(reflector.TakePrivateFields());
        //            break;
        //        case "public":
        //            Console.WriteLine(reflector.TakePublicFields());
        //            break;
        //        case "all":
        //            Console.WriteLine(reflector.TakeAllFields());
        //            break;
        //    }
    }
    }   
}