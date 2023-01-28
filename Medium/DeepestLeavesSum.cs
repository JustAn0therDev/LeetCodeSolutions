using AuxiliaryClasses;

namespace Medium;

public class DeepestLeavesSum
{
    public static int Solve(TreeNode? root)
    {
        // seems much easier to use BFS.
        Queue<KeyValuePair<TreeNode, int>> q = new();
        Dictionary<TreeNode, int> seenNodeAndLevel = new();

        if (root == null)
        {
            return 0;
        }

        q.Enqueue(new KeyValuePair<TreeNode, int>(root, 1));

        int maxLevel = 1;

        while (q.Count > 0)
        {
            (TreeNode? key, int value) = q.Dequeue();

            seenNodeAndLevel.Add(key, value);

            if (key.left != null)
            {
                q.Enqueue(new KeyValuePair<TreeNode, int>(key.left, value + 1));
                maxLevel = value + 1;
            }
 
            if (key.right != null)
            {
                q.Enqueue(new KeyValuePair<TreeNode, int>(key.right, value + 1));
                maxLevel = value + 1;
            }
        }

        return seenNodeAndLevel
            .Where(w => w.Value == maxLevel)
            .Sum(kv => kv.Key.val);
    }
}