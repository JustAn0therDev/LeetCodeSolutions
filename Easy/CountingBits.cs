namespace Easy;

public class CountingBits
{
    public int[] Solve(int n)
    {
        return Enumerable
            .Range(0, n + 1)
            .Select(
                s => Convert.ToString(s, 2).Count(c => c == '1')
            ).ToArray();
    }
}