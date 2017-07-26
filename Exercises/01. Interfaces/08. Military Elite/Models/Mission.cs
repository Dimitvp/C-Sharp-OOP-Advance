public class Mission : IMission
{
    public string CodeName { get; set; }
    public string State { get; set; }

    public Mission(string codeName, string state)
    {
        CodeName = codeName;
        State = state;
    }

    public override string ToString()
    {
        return $"Code Name: {this.CodeName} State: {this.State}";
    }
}