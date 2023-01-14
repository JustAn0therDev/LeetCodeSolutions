using AuxiliaryClasses;

namespace Easy;

public class PathSum
{
    public bool HasPathSum(TreeNode root, int targetSum, int currentSum = 0)
    {
        bool result = false;

        if (root == null)
        {
            return false;
        }

        // it's a leaf node
        if (root.left == null && root.right == null)
        {
            return targetSum == currentSum + root.val;
        }

        if (root.left != null)
        {
            result = HasPathSum(root.left, targetSum, currentSum + root.val);
        }

        if (!result && root.right != null)
        {
            result = HasPathSum(root.right, targetSum, currentSum + root.val);
        }

        return result;
    }
}