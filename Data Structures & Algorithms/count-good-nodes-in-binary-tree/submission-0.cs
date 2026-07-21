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
    public int GoodNodes(TreeNode root) {
       return DFS(root, 0, int.MinValue);
    }

    private int DFS(TreeNode root, int goodNodes, int greatest)
    {
        if(root == null)
            return goodNodes;
        
        if(root.val >= greatest)
        {
            goodNodes++;
            greatest = root.val;
        }

        var left = DFS(root.left, goodNodes, greatest);
        var right = DFS(root.right, left, greatest);

        return right;
    }
}

/*
pointer to the greater number initialized to int.min

DFS through the tree
    check if current > than greater
    true:  
        assign greater to current
        goodNodes++
    
    check left
    then check right sending current count of good nodes 

    return goodNodes


        3
    3       null
4       2
*/