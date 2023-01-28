namespace Medium;

public class ThreeSum
{
    public static IList<IList<int>> Solve(int[] nums)
    {
        IList<IList<int>> ans = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                if (nums[i] + nums[left] + nums[right] == 0)
                {
                    ans.Add(new List<int> {nums[i], nums[left], nums[right]});
                    left += 1;
                    while (nums[left] == nums[left - 1] && left < right)
                    {
                        left += 1;
                    }
                } 
                else if (nums[i] + nums[left] + nums[right] > 0)
                {
                    right -= 1;
                }
                else
                {
                    left += 1;
                }
            }
        }
        
        return ans;
    }

    public class Comparer : IEqualityComparer<List<int>>
    {
        public bool Equals(List<int>? x, List<int>? y)
        {
            return x[0] == y[0] && x[1] == y[1] && x[2] == y[2];
        }

        public int GetHashCode(List<int> obj)
        {
            return 1;
        }
    }
}