namespace Medium;

public class SortColors
{
    public void Solve(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    continue;
                }

                if (nums[i] < nums[j])
                {
                    (nums[j], nums[i]) = (nums[i], nums[j]);
                }
            }
        }
    }
}