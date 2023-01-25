namespace Easy;

public class MaximumCount
{
    public static int Solve(int[] nums)
    {
        int negativeCount = 0;
        int positiveCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                negativeCount++;
            }
            else if (nums[i] > 0)
            {
                positiveCount = nums.Length - i;
                break;
            }
        }

        return Math.Max(positiveCount, negativeCount);
    }
}