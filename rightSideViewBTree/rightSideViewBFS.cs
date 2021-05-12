using System;
using.System.Collections.Generics;

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
    public IList<int> RightSideView(TreeNode root)
    {

        if (root == null) return new List<int>();

        var result = new List<int>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var length = queue.Count;
            var count = 0;
            TreeNode currentNode = null;

            while (count < length)
            {
                currentNode = queue.Dequeue();

                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }

                count++;
            }

            result.Add(currentNode.val);
        }

        return result;

    }
}