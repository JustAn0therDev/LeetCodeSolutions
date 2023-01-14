namespace Easy;

public class MergeSortedArray
{
    public void Solve(int[] nums1, int m, int[] nums2, int n)
    {
        List<int> ans = new();

        ans.AddRange(nums1.Take(nums1.Length - n));
        ans.AddRange(nums2);

        ans.Sort();

        for (int i = 0; i < nums1.Length; i++)
        {
            nums1[i] = ans[i];
        }
    }
}