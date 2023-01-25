namespace Easy;

public class DifferenceOfSum
{
    public static int Solve(int[] nums)
    {
        int elementSum = 0;
        int digitSum = 0;
        
        foreach (int num in nums)
        {
            elementSum += num;
            digitSum += num.ToString().Sum(s => int.Parse(s.ToString()));
        }

        return Math.Abs(elementSum - digitSum);
    }
}