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

         var secondHalf = slow.next;
         slow.next = null;
         ListNode prev = null;

         while(secondHalf != null)
         {
            var tmp = secondHalf.next;
            secondHalf.next = prev;
            prev = secondHalf;
            secondHalf = tmp;
         }

        secondHalf = prev;

        var first = head;

        while(secondHalf != null)
        {
            var tmp1 = first.next;
            var tmp2 = secondHalf.next;
            first.next = secondHalf;
            secondHalf.next = tmp1;
            first = tmp1;
            secondHalf = tmp2;
        }
         

         
    }
}

/*
2,4,6,8

Add them to a list
and use two pointers to build a list



*/
