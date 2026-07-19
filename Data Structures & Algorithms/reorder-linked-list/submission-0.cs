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
    public void ReorderList(ListNode head) {
         var slow = head;
         var fast = head.next;

         while(fast != null && fast.next != null)
         {
            slow = slow.next;
            fast = fast.next.next;
         }

        var second = slow.next;
        ListNode prev = null;
        slow.next = null;
        while(second != null)
        {
            var temp = second.next;
            second.next = prev;
            prev = second;
            second = temp;
        }

        second = prev;
        var first = head;

        while(second != null)
        {
            var tmp1 = first.next;
            var tmp2 = second.next;
            first.next = second;
            second.next = tmp1;
            first = tmp1;
            second = tmp2;
        }
    }
}

/*
2,4,6,8

Add them to a list
and use two pointers to build a list



*/
