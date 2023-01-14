namespace Medium;

public class LengthOfLongestSubstring
{
    public int Solve(string s)
    {
        List<char> dp = new();
        int longest = 0;

        for (int i = 0; i < s.Length; i++)
        {
            dp.Add(s[i]);

            for (int j = i + 1; j < s.Length; j++)
            {
                if (dp.Contains(s[j]))
                {
                    break;
                }

                dp.Add(s[j]);
            }

            if (longest < dp.Count)
            {
                longest = dp.Count;
            }

            dp.Clear();
        }

        return longest;
    }
}