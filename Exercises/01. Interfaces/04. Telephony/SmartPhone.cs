using System.Text.RegularExpressions;

public class SmartPhone : ICallabel, IBrowseable
{
    public string Call(string phoneNum)
    {
        return IsPhoneNum(phoneNum)
                ? $"Calling... {phoneNum}"
                : "Invalid number!";
    }

    public string Browse(string url)
    {
        return IsURL(url)
                ? $"Browsing: {url}!"
                : "Invalid URL!";
    }

    private bool IsPhoneNum(string phoneNum)
    {
        bool containsOnlyDigit = Regex.IsMatch(phoneNum, "^\\d+$");
        return containsOnlyDigit;
    }

    private bool IsURL(string url)
    {
        bool containsDigit = Regex.IsMatch(url, "\\d");
        return !containsDigit;
    }
}