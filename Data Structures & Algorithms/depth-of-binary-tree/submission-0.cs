/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int MaxDepth(TreeNode root) {

        return MaxDepth(root, 0);
    }

    private int MaxDepth(TreeNode root, int level)
    {
         if(root == null) return level;

         level++;

         var leftDepth = MaxDepth(root.left, level);
         var rightDepth = MaxDepth(root.right, level);

        return Math.Max(leftDepth, rightDepth);

    }
}
