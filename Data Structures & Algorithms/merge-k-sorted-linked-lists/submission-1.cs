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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == 0) return null;

        for(var i = 1; i < lists.Length; i++)
        {
            lists[i] = Merge(lists[i], lists[i - 1]);
        }

        return lists[lists.Length - 1];
    }

    private ListNode Merge(ListNode l1, ListNode l2)
    {
        var head = new ListNode(0);
        var dummy = head;
        
        while(l1 != null && l2 != null)
        {
            if(l1.val < l2.val)
            {
                dummy.next =  l1;
                l1 = l1.next;
            }
            else
            {
                dummy.next = l2;
                l2 = l2.next;
            }

            dummy = dummy.next;
        }

        if(l1 != null)
            dummy.next = l1;
        if(l2 != null)
            dummy.next = l2;

        return head.next;
    }
}

/*
[0] = 1,2,4
[1] = 1,3,5
[2] = 3, 6

Merge 2 at time
1 and 1-1
2 and 2-1
3 and 3-1
etc

*/