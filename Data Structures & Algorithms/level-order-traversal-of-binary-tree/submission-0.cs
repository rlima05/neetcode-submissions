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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> res = new List<List<int>>();

        if(root == null) return res;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);        

        while(queue.Count > 0)
        {
            int count = queue.Count;
            List<int> level = new List<int>();

            for(var i = 0; i < count; i++)
            {
                TreeNode current = queue.Dequeue();

                level.Add(current.val);

                if(current.left != null) queue.Enqueue(current.left);
                if(current.right != null) queue.Enqueue(current.right);                
            }

            res.Add(level);
        }

        return res;

    }
}

/*
BFS
Add root to queue and to a list
[1]
for each level add to the queue and list, so
[1], [2,3], [4,5,6,7]
*/
