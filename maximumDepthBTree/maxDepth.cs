using System;


// Definition for a binary tree node.

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int MaxDepth(TreeNode root)
    {

        return recursive(root, 0);
    }

    public int recursive(TreeNode node, int currentDepth)
    {
        if (node == null)
            return currentDepth;

        currentDepth++;
        return Math.Max(recursive(node.left, currentDepth), recursive(node.right, currentDepth));
    }
}

