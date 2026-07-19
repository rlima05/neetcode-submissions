/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var dummy = new ListNode(0, head);
        var left = dummy;
        var right = head;

        while(n > 0)
        {
            n--;
            right = right.next;
        }

        while(right != null)
        {
            right = right.next;
            left = left.next;
        }

        left.next = left.next.next;

        return dummy.next;
    }
}

/*
Use two pointers, left and right
Create a gap of n spaces between them
then move left and right together
once r reaches the end, it means left.next should be removed.





*/