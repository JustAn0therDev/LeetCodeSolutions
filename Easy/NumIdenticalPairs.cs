namespace Easy;

public class NumIdenticalPairs
{
    public static int Solve(int[] nums)
    {
        int pairs = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    pairs++;
                }
            }
        }

        return pairs;
    }
}