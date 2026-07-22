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
    PriorityQueue<int, int> heap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
    public int KthSmallest(TreeNode root, int k) {
           DFS(root, k);

           return heap.Peek();
    }

    private void DFS(TreeNode root, int k)
    {
        if(root == null) return;
        
        heap.Enqueue(root.val, root.val);

        if(heap.Count > k)
            heap.Dequeue();
        
        DFS(root.left, k);
        DFS(root.right, k);
    }
}

/*
Heap
DFS add nodes to the heap
If the count of items in the heap is > k
    remove an item from the heap

keep going

    return the heap.Peek

Edge cases:
    Null node on DFS
        return 

O(n)
O(n)

*/