namespace Easy;

public class HammingWeight
{
    public int Solve(uint n)
    {
        return Convert.ToString(n, 2).Count(c => c == '1');
    }
}