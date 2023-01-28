using Medium;
using AuxiliaryClasses;

TreeNode root = new(38, 
        new TreeNode(43, 
            new TreeNode(16, right: new(71))), 
        new TreeNode(70, new(78, new(27, new TreeNode(71))), new TreeNode(91, new TreeNode(71))
        )
    );
// the final sum should be 6.

Console.WriteLine("\n\nResult: " + DeepestLeavesSum.Solve(root));

// DeepestLeavesSum.Solve(root);
