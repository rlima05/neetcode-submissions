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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        return DFS(p, q);
    }

    private bool DFS(TreeNode p, TreeNode q)
    {
        if(p == null && q == null) return true;
        else if((p == null && q != null)
                || (p != null && q == null))
            return false;
        
        if(p.val != q.val)
            return false;
        
        bool left = DFS(p.left, q.left);
        bool right = DFS(p.right, q.right);

        return left && right;
    }
}


/*
Depth first search
    if one is null and the other is not null
        return false
    if both null return true

    compare is p.val != q.val
        return false
    
    DFS(p left, q left)
    DFS(p right, q right)

    return left && right


*/