using AuxiliaryClasses;

namespace Easy;

public class PreorderTraversal
{
    public IList<int> Solve(TreeNode? root, List<int>? nodes = null)
    {
        if (root == null)
        {
            return nodes!;
        }

        if (nodes == null)
        {
            nodes = new();
        }
        
        nodes.Add(root.val);

        Solve(root.left, nodes);
        Solve(root.right, nodes);

        return nodes;
    }
}