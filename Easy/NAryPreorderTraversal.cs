using AuxiliaryClasses;

namespace Easy;

public class NAryPreorderTraversal
{
    public IList<int> Solve(Node? root, List<int>? l = null)
    {
        l ??= new();

        if (root == null)
        {
            return l;
        }
        
        l.Add(root.val);

        foreach (Node child in root.children)
        {
            Solve(child, l);
        }

        return l;
    }
}