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
    public List<int> RightSideView(TreeNode root) {
        List<int> nodes = new List<int>();

        DFS(root, nodes, 0);

        return nodes;
    }

    private void DFS(TreeNode root, List<int> nodes, int level)
    {
        if(root == null) return;

        if(level >= nodes.Count)
            nodes.Add(root.val);

        level++;

        DFS(root.right, nodes, level);
        DFS(root.left, nodes, level);
    } 
}

/*
DFS problem
    Add root to list
    Go to the left and add to the list, keeping track of the level
    once right is finished go to the left
    if list[level] != null
        go to the next
    otherwise
        add to the list and go to the next

*/