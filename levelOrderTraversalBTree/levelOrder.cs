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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var currentLevelValues = new List<int>();
            int length = queue.Count;
            int count = 0;

            TreeNode currentNode = null;
            while (count < length)
            {
                currentNode = queue.Dequeue();
                if (currentNode == null) break;
                currentLevelValues.Add(currentNode.val);

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

            if (currentLevelValues.Count > 0)
            {
                result.Add(currentLevelValues);
            }
        }
        return result;
    }
}