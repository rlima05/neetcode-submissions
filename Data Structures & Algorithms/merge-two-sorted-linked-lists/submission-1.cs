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
        ListNode head = new ListNode();
        var res = head;

        while(list1 != null && list2 != null)
        {
            if(list1.val < list2.val)
            {
                head.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                head.next = new ListNode(list2.val);
                list2 = list2.next;
            }

            head = head.next;
        }

        if(list1 != null)
            head.next = list1;
        else
            head.next = list2;
            
        return res.next;
    }
}

/*
while list1 and list2 still have nodes
    current.next will be the smaller between l1 and l2
    move next to current
    then next will be the other one

    l1 and l2 next

once loop is finished just add the remaining of the nodes

*/