namespace Medium;

public class IsStrictlyPalindromic
{
    public bool Solve(int n)
    {
        try
        {
            for (int i = 2; i <= (n - 2); i++)
            {
                string s = Convert.ToString(n, n);
                if (string.Join("", s.Reverse()) != s)
                {
                    return false;
                }
            }

            return true;
        }
        catch (ArgumentException)
        {
            return false;
        }
    }
}