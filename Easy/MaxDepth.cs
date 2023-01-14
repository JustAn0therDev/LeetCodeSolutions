using AuxiliaryClasses;

namespace Easy;

public class MaxDepth
{
    public int Solve(TreeNode? root)
    {
        if (root == null) {
            return 0;
        }
        
        int leftDepth = 0;
        int rightDepth = 0;

        if (root.left != null)
        {
            leftDepth += Solve(root.left);
        }

        if (root.right != null)
        {
            rightDepth += Solve(root.right);
        }

        return 1 + (leftDepth > rightDepth ? leftDepth : rightDepth);
    }
}