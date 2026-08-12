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
    public bool HasCycle(ListNode head) {
      if(head == null) return false;

      var slow = head;
      var fast = head;

      while(fast != null && fast.next != null)
      {
            slow = slow.next;
            fast = fast.next.next;

                        if(slow == fast) return true;
      }

      return false;
    }
}

/*
slow = head
fast = head.next

while head.next and head.next.next != null
fast = fast.next.next
slow = next
if they meet there is a cycle
*/