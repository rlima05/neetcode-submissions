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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head = new ListNode(0);
        ListNode res = head;


        while(list1 != null && list2 != null)
        {
            if(list1.val <= list2.val)
            {
                res.next = list1;
                list1 = list1.next;
            }
            else
            {
                res.next = list2;
                list2 = list2.next;
            }

            res = res.next;
        }

        if(list1 != null)
            res.next = list1;
        else if(list2 != null)
            res.next = list2;

        return head.next;
    }
}

/*
loop while both lists have values

curr.next = lit with lowest value
    curr = next
    list = next

after curr.next will be the list with any nodes still, if any


*/