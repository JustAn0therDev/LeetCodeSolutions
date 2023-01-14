using System.Text.RegularExpressions;

namespace Easy;

public class IsPalindrome
{
    public bool Solve(string s)
    {
        string treatedString = Regex.Replace(s, "[^A-Za-z0-9]", "").ToLower();
        return treatedString == string.Join("", treatedString.Reverse());
    }
}